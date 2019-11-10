using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace wsrPress
{
    public partial class testRun : Form
    {
        pressController cbr;
        testParams testParam;
        imageConversion imgConv = new imageConversion();
        Boolean testDirection = true;
        double testMaxForce = 120.0;
        int testOverCounter = 0;

        struct sample
        {
            public UInt32 sequence;
            public double kNReading;
            public double mmReading;
            public double secTime;
        };

        UInt32 sampleNumber = 0;

        sample[] samples = new sample[5000];

        int testOver = 0;
        string testOverReason = "";

        double nextSample;
        double nextSample_save;

        public testRun(pressController cbr_, testParams testParam_)
        {
            InitializeComponent();
            cbr = cbr_;
            testParam = testParam_;
            testParam.testStopwatch.Reset();

            nextSample_save = nextSample = testParam.sampleRate;

            Console.WriteLine(testParam.rateUnit);

            GraphPane myPane = testGraph.GraphPane;
            myPane.IsFontsScaled = false;

            RollingPointPairList list = new RollingPointPairList(72000);
            LineItem curve = myPane.AddCurve(testParam.YSeriesTitle, list, Color.Blue, SymbolType.None);

            Console.WriteLine("SetPointMultiplier:" + testParam.setPointTimeMultiplier
                + " RateValue:" + testParam.rateValue
                + " RateType:" + testParam.rateType
                + " SampleRate:" + testParam.sampleRate
                + " SampleUnit:" + testParam.sampleUnit);

            Console.WriteLine("EndCondition0:" + testParam.endCondition0 + " EndConditionValue0:" + testParam.endConditionValue0
                + " EndCondition1:" + testParam.endCondition1 + " EndConditionValue1:" + testParam.endConditionValue1
                );

            if (testParam.xAxisUnit == "seconds")
            {
                curve.Label.Text = "Time vs. Load";
            }
            else if (testParam.xAxisUnit == "mm")
            {
                curve.Label.Text = "Displacement vs. Load";
            }

            curve.Line.Width = 1.5f;
            curve.Line.IsSmooth = true;
            curve.Line.IsAntiAlias = true;
            curve.Line.SmoothTension = 0.1f;

            myPane.XAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Min = 0;

            myPane.Title.Text = testParam.GraphTitle;

            if (testParam.xAxisUnit == "mm")
            {
                testParam.XAxisTimeWindow = 12;
                myPane.XAxis.Scale.Max = testParam.XAxisTimeWindow;
                myPane.XAxis.Scale.MinorStep = testParam.XAxisTimeWindow / 100.0f;
                myPane.XAxis.Scale.MajorStep = testParam.XAxisTimeWindow / 10.0f;
                myPane.XAxis.Title.Text = "Displacement (mm)";
            }
            else if (testParam.xAxisUnit == "seconds")
            {
                testParam.XAxisTimeWindow = 720;
                myPane.XAxis.Scale.Max = testParam.XAxisTimeWindow;
                myPane.XAxis.Scale.MinorStep = testParam.XAxisTimeWindow / 100.0f;
                myPane.XAxis.Scale.MajorStep = testParam.XAxisTimeWindow / 10.0f;
                myPane.XAxis.Title.Text = "Time (seconds)";
            }

            if (testParam.yAxisUnit == "force")
            {
                float max_ = 250.0f;
                if (testParam.pressType == "CUBE")
                {
                    max_ = 2000.0f;
                }
                else if (testParam.GraphTitle == "Running Test:UCS")
                {
                    max_ = 200.0f;
                }
                else
                {
                    max_ = 50.0f;
                }
                myPane.YAxis.Scale.Max = max_;
                myPane.YAxis.Scale.MinorStep = max_ / 100.0f;
                myPane.YAxis.Scale.MajorStep = max_ / 10.0f;
                myPane.YAxis.Title.Text = "Load (kN)";
            }

            testGraph.AxisChange();

            testParam.forceReadings[0] = 0;
            testParam.forceReadings[1] = 0;
            testParam.forceReadings[2] = 0;
            testParam.forceReadings[3] = 0;
            testParam.forceReadings[4] = 0;

            testParam.dispReadings[0] = 0;
            testParam.dispReadings[1] = 0;
            testParam.dispReadings[2] = 0;
            testParam.dispReadings[3] = 0;
            testParam.dispReadings[4] = 0;

            testParam.Adjust = 0;

            setForceZero();
            setReadings();

            //save_sample();
            labelUpdater.Enabled = true;
            labelUpdater.Start();

            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();

            testOverChecker.Enabled = true;
            testOverChecker.Start();

            approachTimer.Enabled = true;
            approachTimer.Interval = 5;
            approachTimer.Start();

            testOverCounter = 0;
        }
        private void approachTimer_Tick(object sender, EventArgs e)
        {
            if (testDirection)
            {
                cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionDownValues[0]));
                cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionDownValues[1]));
            }
            else
            {
                cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionUpValues[0]));
                cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionUpValues[1]));
            }

            if (testParam.pressType == "CBR")
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.rushSpeed));
            }
            else
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.motorChannel[3])); // Manual Speed
            }

            setReadings();
            if (testParam.pressType == "CBR")
            {
                if (testParam.forceReadings[3] > 0.04)
                {
                    cbr.setOutputChannel(testParam.motorChannel[0], 0);
                }
                else
                {

                }
            }

            if (testParam.forceReadings[3] > testParam.startForce)
            {
                if (testParam.pressType == "CBR")
                {
                    cbr.setOutputChannel(testParam.motorChannel[0], 0);
                    killTimers();
                    killMotor();
                    startTest();
                }
                else
                {
                    killTimers();
                    // OPEN VALVE
                    if (testDirection)
                    {
                        cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionDownValues[0] > 0 ? 0 : 1));
                        cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionDownValues[1] > 0 ? 0 : 1));
                    }
                    else
                    {
                        cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionUpValues[0] > 0 ? 0 : 1));
                        cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionUpValues[1] > 0 ? 0 : 1));
                    }
                    cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.rushSpeed)); 
                    this.cubePressOpenValveTimer.Enabled = true;
                    this.cubePressOpenValveTimer.Start();
                }

            }
        }

        private void cubePressOpenValveTimer_Tick(object sender, EventArgs e)
        {
            this.cubePressOpenValveTimer.Enabled = false;
            this.cubePressOpenValveTimer.Stop();
            this.startTest();
        }
        
        private void startTest()
        {
            setDisplacementZero();
            setReadings();
            save_sample();

            checkLimitSwitch.Start();
            labelUpdater.Start();
            testOverChecker.Start();

            testParam.testStopwatch.Start();
            samplingTimer.Enabled = true;
            samplingTimer.Start();
            graphUpdateTimer.Enabled = true;
            graphUpdateTimer.Start();
            mainTestTimer.Enabled = true;
            mainTestTimer.Interval = 5;
            mainTestTimer.Start();
        }
        
        private void killTimers()
        {
            approachTimer.Enabled = false;
            approachTimer.Stop();
            checkLimitSwitch.Stop();
            labelUpdater.Stop();
            testOverChecker.Stop();
        }
        private void killMotor()
        {
            cbr.setOutputChannel(testParam.motorChannel[0], 0);
            cbr.setOutputChannel(testParam.motorChannel[0], 0);
            cbr.setOutputChannel(testParam.motorChannel[0], 0);
        }

        private void labelUpdater_Tick(object sender, EventArgs e)
        {
            TimeSpan timerTimeSpan = testParam.testStopwatch.Elapsed;
            loadTextBox.Text = testParam.forceReadings[3].ToString("###0.00 kN");
            displacementTextBox.Text = testParam.dispReadings[3].ToString("###0.00 mm ");

            maxForce.Text = testParam.forceReadings[4].ToString("###0.00 kN");
            mmAtMaxForce.Text = testParam.dispReadings[4].ToString("###0.00 mm");
            elapsedTimeTextBox.Text = string.Format("{0:HH:mm:ss.ff}", new DateTime(timerTimeSpan.Ticks));
            PacingErrorText.Text = testParam.pidPaceError.ToString();
        }

        private void graphUpdateTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan timerTimeSpan = testParam.testStopwatch.Elapsed;
            if (testGraph.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = testGraph.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            double time = testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0;

            if (testParam.xAxisUnit == "seconds")
            {
                list.Add(time, testParam.forceReadings[4]);
                Scale xScale = testGraph.GraphPane.XAxis.Scale;
                if (time > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - testParam.XAxisTimeWindow;
                }
            }
            else if (testParam.xAxisUnit == "mm")
            {
                list.Add(testParam.dispReadings[3], testParam.forceReadings[3]);
                Scale xScale = testGraph.GraphPane.XAxis.Scale;
                if (testParam.dispReadings[3] > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = testParam.dispReadings[4] + xScale.MajorStep;
                    xScale.Min = xScale.Max - testParam.XAxisTimeWindow;
                }
            }
            testGraph.Invalidate();
        }
        private void samplingTimer_Tick(object sender, EventArgs e)
        {
            double elapsedTime = testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0f;

            if (testParam.sampleUnit == "mm")
            {
                try
                {
                    if (testParam.dispReadings[3] > nextSample)
                    {
                        save_sample();
                        nextSample_save += testParam.sampleRate;
                        nextSample = testParam.dispReadings[3] + testParam.sampleRate;
                    }
                }
                catch { }
            }
            else if (testParam.sampleUnit == "sec")
            {
                try
                {
                    if (elapsedTime > nextSample)
                    {
                        save_sample();
                        nextSample_save += testParam.sampleRate;
                        nextSample = elapsedTime + testParam.sampleRate;
                    }
                }
                catch { }
            }
        }
        private void mainTestTimer_Tick(object sender, EventArgs e)
        {
            setReadings();
            if (testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0f > 10)
            {
                Console.WriteLine(testParam.forceReadings[3] + " " + testParam.forceReadings[4] * testParam.endConditionValue0);

                if (testParam.endCondition0 == "PERC")
                {

                    if (testParam.forceReadings[3] < testParam.forceReadings[4] * testParam.endConditionValue0)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop(); testOver = 3; testOverReason = "Sample Failed!";
                        }

                    }
                }
                else if (testParam.endCondition0 == "DISPLACEMENT")
                {
                    if (testParam.dispReadings[4] > testParam.endConditionValue0)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop();
                            testOver = 4; testOverReason = "Displacment over " + testParam.endConditionValue0.ToString() + "mm!";
                        }
                    }
                }
                else if (testParam.endCondition0 == "TIME")
                {
                    if ((testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0f) > testParam.endConditionValue0)
                    {
                        mainTestTimer.Enabled = false; mainTestTimer.Stop(); testOver = 5; testOverReason = "Test Time overrun!";
                    }
                }
                else if (testParam.endCondition0 == "MAXFORCE")
                {
                    if (testParam.forceReadings[3] > testParam.endConditionValue0)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop();
                            testOver = 5; testOverReason = "Force over " + testParam.endConditionValue0.ToString() + "kN!";
                        }
                    }
                }
                else if (testParam.endCondition0 == "NONE") { }

                if (testParam.endCondition1 == "PERC")
                {
                    if (testParam.forceReadings[3] < testParam.forceReadings[4] * testParam.endConditionValue1)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop(); testOver = 3; testOverReason = "Sample Failed!";
                        }
                    }
                }
                else if (testParam.endCondition1 == "DISPLACEMENT")
                {
                    if (testParam.dispReadings[4] > testParam.endConditionValue1)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop();
                            testOver = 4; testOverReason = "Displacment over " + testParam.endConditionValue1.ToString() + "mm!";
                        }
                    }
                }
                else if (testParam.endCondition1 == "TIME")
                {
                    if ((testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0f) > testParam.endConditionValue1)
                    {
                        mainTestTimer.Enabled = false; mainTestTimer.Stop(); testOver = 5; testOverReason = "Test Time overrun!";
                    }
                }
                else if (testParam.endCondition1 == "MAXFORCE")
                {
                    if (testParam.forceReadings[3] > testParam.endConditionValue1)
                    {
                        testOverCounter += 1;
                        if (testOverCounter > 50)
                        {
                            mainTestTimer.Enabled = false; mainTestTimer.Stop();
                            testOver = 5; testOverReason = "Force over " + testParam.endConditionValue1.ToString() + "kN!";
                        }
                    }
                }
                else if (testParam.endCondition1 == "NONE") { }
            }

            cbr.setOutputChannel(testParam.motorChannel[0], testParam.pid_motor());
        }
        private void checkLimitSwitch_Tick(object sender, EventArgs e)
        {
            UInt32 value;
            //cbr.getDevice();
            value = cbr.returnInputChannel(testParam.limitChannel[0]);
            if (value < testParam.limitChannel[2])
            {
                piston_stop();
                testOver = 1;
                testOverReason = "Limit Switch!";
            }
            else if (value > testParam.limitChannel[3])
            {
                piston_stop();
                testOver = 1;
                testOverReason = "Limit Switch!";
            }
            else if (testParam.forceReadings[3] > testMaxForce)
            {
                piston_stop();
                testOver = 1;
                testOverReason = "Press Maximum Force Reached!";
            }
        }
        private void testOverChecker_Tick(object sender, EventArgs e)
        {
            if (testOver > 0)
            {
                piston_stop();
                approachTimer.Enabled = false; approachTimer.Stop();
                testOverChecker.Enabled = false; testOverChecker.Stop();
                checkLimitSwitch.Enabled = false; checkLimitSwitch.Stop();
                labelUpdater.Enabled = false; labelUpdater.Stop();
                samplingTimer.Enabled = false; samplingTimer.Stop();
                graphUpdateTimer.Enabled = false; graphUpdateTimer.Stop();
                mainTestTimer.Enabled = false; mainTestTimer.Stop();

                testParam.testStopwatch.Stop(); testParam.testStopwatch.Reset();

                DialogResult res = MessageBox.Show(testOverReason + ", Save Results?", "Test Over", MessageBoxButtons.YesNo);
                if (res.ToString() == "Yes")
                {
                    Int32 runId;
                    byte[] image = imgConv.imageToByteArray(testGraph.GraphPane.GetImage(640, 480, 100));
                    string base64Image = Convert.ToBase64String(image);

                    try
                    {
                        test_runsTableAdapter_.Insert(
                        testParam.testypeId,
                        testParam.dateTime,
                        testParam.sampleNumber,
                        testParam.userRate,
                        testParam.userArea,
                        testParam.rateType,
                        testParam.forceReadings[4],
                        base64Image, testParam.dispReadings[4]);

                        runId = Convert.ToInt32(test_runsTableAdapter_.LastTestInserted().ToString());
                        if (sampleNumber > 0)
                        {
                            for (int j = 0; j < sampleNumber; j++)
                            {
                                test_run_samplesTableAdapter_.Insert(runId,
                                samples[j].sequence, samples[j].kNReading, samples[j].mmReading, samples[j].secTime);
                            }
                        }
                    }
                    catch { }
                    this.closeTestValveTimer();
                }
                else if (res.ToString() == "No")
                {
                    this.closeTestValveTimer();
                }
            }
        }

        private void closeTestValveTimer()
        {
            if (testDirection)
            {
                cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionDownValues[0] > 0 ? 0 : 1));
                cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionDownValues[1] > 0 ? 0 : 1));
            }
            else
            {
                cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionUpValues[0] > 0 ? 0 : 1));
                cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionUpValues[1] > 0 ? 0 : 1));
            }
            this.cubePressTestOverOpenValveTimer.Enabled = true;
            this.cubePressTestOverOpenValveTimer.Start();
        }            
            
        private void setReadings()
        {
            //cbr.getDevice();

            testParam.forceReadings[0] = cbr.returnInputChannel(testParam.forceChannel);
            testParam.forceReadings[2] = testParam.forceReadings[0] - testParam.forceReadings[1];
            testParam.forceReadings[3] =
                testParam.forceCoff[0] * Math.Pow(testParam.forceReadings[2], 3) +
                testParam.forceCoff[1] * Math.Pow(testParam.forceReadings[2], 2) +
                testParam.forceCoff[2] * testParam.forceReadings[2] + testParam.forceCoff[3];

            if (testParam.forceReadings[3] < 0)
            {
                testParam.forceReadings[3] = 0.0f;
            }

            testParam.dispReadings[0] = ((cbr.returnInputChannel(testParam.dispChannel) - testParam.potMin) / (testParam.potMax - testParam.potMin)) * testParam.potRange;
            testParam.dispReadings[2] = testParam.dispReadings[0] - testParam.dispReadings[1];
            testParam.dispReadings[3] = testParam.dispReadings[2];
            //0 Current //1 Zero //2 Zerod Value //3 Analogue Value

            if (mainTestTimer.Enabled)
            {
                if (testParam.forceReadings[3] > testParam.forceReadings[4])
                {
                    testParam.forceReadings[4] = testParam.forceReadings[3];
                    testParam.dispReadings[4] = testParam.dispReadings[3];
                }

                //if (testParam.dispReadings[3] > testParam.dispReadings[4])
                //{
                //    testParam.dispReadings[4] = testParam.dispReadings[3];                    
                //}
            }
        }
        private void setForceZero()
        {
            testParam.forceReadings[1] = 0.0f;  //          
            for (int i = 0; i <= 299; i++)
            {
                //cbr.getDevice();
                testParam.forceReadings[1] += cbr.returnInputChannel(testParam.forceChannel);
            }
            testParam.forceReadings[1] = testParam.forceReadings[1] / 300;
        }
        private void setDisplacementZero()
        {
            testParam.dispReadings[1] = 0;
            for (int i = 0; i <= 31; i++)
            {
                //cbr.getDevice();                
                testParam.dispReadings[1] += cbr.returnInputChannel(testParam.dispChannel);
            }
            testParam.dispReadings[1] = testParam.dispReadings[1] / 32;

            testParam.dispReadings[1] = ((testParam.dispReadings[1] - testParam.potMin) / (testParam.potMax - testParam.potMin)) * testParam.potRange;
        }
        private void piston_stop()
        {
            cbr.setOutputChannel(testParam.motorChannel[0], 0);
            cbr.setOutputChannel(testParam.directionChannel0, 0);
            cbr.setOutputChannel(testParam.directionChannel1, 0);
            //cbr.setDevice();
        }
        private void save_sample()
        {
            samples[sampleNumber].sequence = sampleNumber + 1;
            samples[sampleNumber].kNReading = testParam.forceReadings[3];

            if (testParam.rateUnit == "mm/min")
            {
                if (sampleNumber > 0)
                    samples[sampleNumber].mmReading = nextSample_save;
                else
                    samples[sampleNumber].mmReading = 0;

            }
            else
            {
                samples[sampleNumber].mmReading = testParam.dispReadings[3];
            }


            samples[sampleNumber].secTime = testParam.testStopwatch.Elapsed.TotalMilliseconds / 1000.0f;

            samplesDataGrid_.Rows.Add(samples[sampleNumber].sequence.ToString(),
               samples[sampleNumber].mmReading.ToString("###0.000"),
                samples[sampleNumber].kNReading.ToString("###0.000"),
                samples[sampleNumber].secTime.ToString()
                );
            sampleNumber += 1;

            samplesDataGrid_.FirstDisplayedScrollingRowIndex = samplesDataGrid_.RowCount - 1;
            samplesDataGrid_.Rows[samplesDataGrid_.RowCount - 1].Selected = true;
        }
        private void testRun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F3")
            {
                piston_stop();
                testOver = 2;
                testOverReason = "Emergency Stop!";
            }

            if (e.KeyCode.ToString() == "F9" || e.KeyCode.ToString() == "s" || e.KeyCode.ToString() == "S")
            {
                debugLabel.Visible = true;
                debugLabel.Text = "ADC : " + testParam.forceReadings[2].ToString("#######") + " FORCE : " + testParam.forceReadings[3].ToString("#####.00");
            }
        }
        private void emergencyStop_Click(object sender, EventArgs e)
        {
            piston_stop();
            testOver = 2;
            testOverReason = "Emergency Stop!";
        }
        private void testRun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pressDataSet_.general_settings' table. You can move, or remove it, as needed.
            this.general_settingsTableAdapter.Fill(this.pressDataSet_.general_settings);
            // TODO: This line of code loads data into the 'pressDataSet_.general_settings' table. You can move, or remove it, as needed.
            this.general_settingsTableAdapter.Fill(this.pressDataSet_.general_settings);
            // TODO: This line of code loads data into the 'pressDataSet_.general_settings' table. You can move, or remove it, as needed.
            this.general_settingsTableAdapter.Fill(this.pressDataSet_.general_settings);
            // TODO: This line of code loads data into the 'pressDataSet_.general_settings' table. You can move, or remove it, as needed.
            this.general_settingsTableAdapter.Fill(this.pressDataSet_.general_settings);

            testDirection = Convert.ToBoolean(this.pressDataSet_.general_settings[0][4]);
            testMaxForce = Convert.ToDouble(this.pressDataSet_.general_settings[0][5]);
            //MessageBox.Show(testMaxForce.ToString());
        }
        private void testRun_FormClosing(object sender, FormClosingEventArgs e)
        {
            piston_stop();

            approachTimer.Enabled = false; approachTimer.Stop();
            testOverChecker.Enabled = false; testOverChecker.Stop();
            checkLimitSwitch.Enabled = false; checkLimitSwitch.Stop();
            labelUpdater.Enabled = false; labelUpdater.Stop();
            samplingTimer.Enabled = false; samplingTimer.Stop();
            graphUpdateTimer.Enabled = false; graphUpdateTimer.Stop();
            mainTestTimer.Enabled = false; mainTestTimer.Stop();
        }

        private void cubePressTestOverOpenValveTimer_Tick(object sender, EventArgs e)
        {
            this.cubePressTestOverOpenValveTimer.Enabled = false;
            this.cubePressTestOverOpenValveTimer.Stop();
            this.Close();
        }
    }
}