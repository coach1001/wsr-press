using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wsrPress
{
    public partial class testSelect : Form
    {
        int piston = 0; //0-Idle 1-Lift 2-Drop
        pressController cbr;
        testParams testParam;
        bool rangeMinExceeded = false;
        bool rangeMaxExceeded = false;

        public testSelect(pressController cbr_,testParams testParam_)
        {
            InitializeComponent();
            cbr = cbr_;
            testParam = testParam_;

            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();
        }

        private void testSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F5")
            {
                if (!rangeMaxExceeded)
                {
                    if (piston == 0) { pistonLabel.Text = "PISTON DROPPING!"; piston = 1; piston_down(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }
                }
            }
            else if (e.KeyCode.ToString() == "F6")
            {
                if (!rangeMinExceeded)
                {
                    if (piston == 0) { pistonLabel.Text = "PISTON RISING!"; piston = 2; piston_up(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }
                }
            }
            else if (e.KeyCode.ToString() == "s" || e.KeyCode.ToString() == "S")
            {
                dispAbs.Visible = true;                
            }
        }

        private void testSelect_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F5")
            {
                if (piston == 1) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }
            }
            else if (e.KeyCode.ToString() == "F6")
            {
                if (piston == 2) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }

            }
            else if (e.KeyCode.ToString() == "F3") { this.Close(); }
            else if (e.KeyCode.ToString() == "F4") { runTestForm(); }
        }

        private void dropPiston_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rangeMaxExceeded)
            {
                if (piston == 0) { pistonLabel.Text = "PISTON DROPPING!"; piston = 1; piston_down(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }
            }
        }

        private void dropPiston_MouseUp(object sender, MouseEventArgs e)
        {
            if (piston == 1) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }
        }

        private void liftPiston_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rangeMinExceeded)
            {
                if (piston == 0) { pistonLabel.Text = "PISTON RISING!"; piston = 2; piston_up(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }
            }
        }

        private void liftPiston_MouseUp(object sender, MouseEventArgs e)
        {
            if (piston == 2) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }
        }

        private void testSelect_Load(object sender, EventArgs e)
        {
            this.test_runsBindingSource_.AddNew();
            //this.test_runsTableAdapter_.Fill(this.pressDataSet_.test_runs);            
            this.testsTableAdapter_.Fill(this.pressDataSet_.tests);

            this.dateDateTimePicker.Value = DateTime.Now;
            this.sampleNumberTextBox.Text = "Default - "+DateTime.Now.ToString();
            this.userAreaTextBox.Text = "0";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void runTest_Click(object sender, EventArgs e)
        {
            runTestForm();
        }
        private void runTestForm()
        {
            for(int i=0;i<=4;i++)
            {
                testParam.forceReadings[i] = 0.0f;
                testParam.dispReadings[i] = 0.0f;
            }
            this.Validate();
            DialogResult res;
            res = MessageBox.Show("Are you sure you?", "Run Test", MessageBoxButtons.YesNo);
            if (res.ToString() == "Yes")
            {
                try
                {
                    testParam.pidSetPoint = 0;
                    testParam.setPointTimeMultiplier = 1;
                    testParam.pidCurrPoint = 0;
                    testParam.pidError = 0;
                    testParam.pidPreError = 0;
                    testParam.pidOutput = 0;
                    testParam.pidPaceError = 0;
                    testParam.startForce = 0.05f;
                    testParam.pidIntegral = 0;
                    testParam.pidProportional = 0;
                    testParam.pidDerivative = 0;
                    testParam.prevTime = 0;

                    int kn_set = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
                    calibration_coffTableAdapter_.FillBykNSet(pressDataSet_.calibration_coff, kn_set);

                    testParam.forceCoff[0] = Convert.ToDouble(pressDataSet_.calibration_coff[0]["A"]);
                    testParam.forceCoff[1] = Convert.ToDouble(pressDataSet_.calibration_coff[0]["B"]);
                    testParam.forceCoff[2] = Convert.ToDouble(pressDataSet_.calibration_coff[0]["C"]);
                    testParam.forceCoff[3] = Convert.ToDouble(pressDataSet_.calibration_coff[0]["D"]);

                    testParam.rateType = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    testParam.rateUnit = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    testParam.rateValue = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                    testParam.startForce = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[7].Value);
                    testParam.endCondition0 = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                    testParam.endCondition1 = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                    testParam.endConditionValue0 = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[14].Value);
                    testParam.endConditionValue1 = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[15].Value);

                    if (dataGridView1.SelectedRows[0].Cells["endCondition0"].Value.ToString() == "MAXFORCE")
                    {
                        testParam.endCondition0 = dataGridView1.SelectedRows[0].Cells["endCondition0"].Value.ToString();
                        testParam.endConditionValue0 = Convert.ToDouble(maxForceTextBox.Text);
                        Console.WriteLine(testParam.endCondition0.ToString());
                        Console.WriteLine(testParam.endConditionValue0.ToString());
                    }
                    
                    testParam.sampleNumber = sampleNumberTextBox.Text;
                    testParam.dateTime = dateDateTimePicker.Value;
                    testParam.testypeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[16].Value);
                    testParam.userRate = Convert.ToDouble(userRateTextBox.Text);
                    testParam.userArea = Convert.ToDouble(userAreaTextBox.Text);

                    testParam.xAxisUnit = Convert.ToString(dataGridView1.SelectedRows[0].Cells[17].Value);
                    testParam.yAxisUnit = Convert.ToString(dataGridView1.SelectedRows[0].Cells[18].Value);
                    testParam.rushSpeed = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[19].Value);
                    
                    if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "DISPLACEMENT")
                    {
                        testParam.pidCurrPoint = testParam.dispReadings[3];
                        pid_valuesTableAdapter_.FillByRateType(pressDataSet_.pid_values, "DISPLACEMENT");                        
                        testParam.P = Convert.ToDouble(pressDataSet_.pid_values[0]["P"]);
                        testParam.I = Convert.ToDouble(pressDataSet_.pid_values[0]["I"]);
                        testParam.D = Convert.ToDouble(pressDataSet_.pid_values[0]["D"]);
                        testParam.C = Convert.ToDouble(pressDataSet_.pid_values[0]["C"]);

                        if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[11].Value))
                        {
                            testParam.setPointTimeMultiplier = Convert.ToDouble(userRateTextBox.Text)/60.0f;
                        }
                        else
                        {
                            testParam.setPointTimeMultiplier = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value) / 60.0f;
                        }
                        
                        testParam.sampleRate = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value);
                        testParam.sampleUnit = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        testParam.YAxisTitle = "mm";
                        testParam.XAxisTitle = "Time in Seconds";
                        testParam.YSeriesTitle = "mm";
                        testParam.GraphTitle = "Running Test:"+dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    }
                    else if(dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "FORCE")
                    {
                        testParam.pidCurrPoint = testParam.forceReadings[3];
                        pid_valuesTableAdapter_.FillByRateType(pressDataSet_.pid_values,"FORCE");
                        testParam.P = Convert.ToDouble(pressDataSet_.pid_values[0]["P"]);
                        testParam.I = Convert.ToDouble(pressDataSet_.pid_values[0]["I"]);
                        testParam.D = Convert.ToDouble(pressDataSet_.pid_values[0]["D"]);
                        testParam.C = Convert.ToDouble(pressDataSet_.pid_values[0]["C"]);

                        if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[11].Value))
                        {
                            testParam.setPointTimeMultiplier = Convert.ToDouble(userRateTextBox.Text)/60.0f;
                        }
                        else
                        {
                            testParam.setPointTimeMultiplier = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value) / 60.0f;
                        }

                        testParam.sampleRate = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value);
                        testParam.sampleUnit = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        testParam.YAxisTitle = "kN";
                        testParam.XAxisTitle = "Time in Seconds";
                        testParam.YSeriesTitle = "kN";
                        testParam.GraphTitle = "Running Test:"+dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    }
                    checkLimitSwitch.Enabled = false;
                    checkLimitSwitch.Stop();
                    testParam.dispReadings[1] = 0.0f;
                    testParam.forceReadings[1] = 0.0f;
                    testRun testRun_ = new testRun(cbr, testParam);
                    testRun_.ShowDialog();
                    checkLimitSwitch.Enabled = true;
                    checkLimitSwitch.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.ToString());
                }
            }
            else
            {

            }
        }

        private void checkLimitSwitch_Tick(object sender, EventArgs e)
        {
            int limit = check_limits();
            dispAbs.Text = testParam.dispReadings[0].ToString("####.##");
            if (limit == 1)
            {                
                piston = 0;
                piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop();
                pistonLabel.Text = "LIMIT! PISTON IDLE";
            }
            else if (limit == 2)
            {                
                piston = 0;
                piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop();
                pistonLabel.Text = "LIMIT! PISTON IDLE";
            }
            else if (rangeMaxExceeded || rangeMinExceeded)
            {
                piston = 0;
                piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop();
                pistonLabel.Text = "LIMIT! PISTON IDLE";
            }
        }

        private void reversePiston()
        {
            if (piston == 1)
            {
                piston = 2; piston_up();
            }
            else if (piston == 2)
            {
                piston = 1; piston_down();
            }
        }

        private int check_limits()
        {
            UInt32 value;
            //cbr.getDevice();

            testParam.dispReadings[0] = ((cbr.returnInputChannel(testParam.dispChannel) - testParam.potMin) / (testParam.potMax - testParam.potMin)) * testParam.potRange;

            value = cbr.returnInputChannel(testParam.limitChannel[0]);

            if (value < testParam.limitChannel[2])
            {
                return 1;
            }
            else if (value > testParam.limitChannel[3])
            {
                return 2;
            }
            else if (testParam.dispReadings[0] > testParam.potRangeMax)
            {
                rangeMaxExceeded = true;
                rangeMinExceeded = false;
            }
            else if (testParam.dispReadings[0] < testParam.potRangeMin)
            {
                rangeMinExceeded = true;
                rangeMaxExceeded = false;
            }
            else
            {
                rangeMinExceeded = false;
                rangeMaxExceeded = false;
            }            
            return 0;
        }

        private void piston_stop()
        {
            cbr.setOutputChannel(testParam.motorChannel[0], 0);
            cbr.setOutputChannel(testParam.directionChannel0, 0);
            cbr.setOutputChannel(testParam.directionChannel1, 0);
            //cbr.setDevice();
        }

        private void piston_up()
        {
            cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionUpValues[0]));
            cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionUpValues[1]));

            if (testParam.pressType == "CBR")
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.motorChannel[3]));
            }
            else if (testParam.testDirection && testParam.pressType == "CUBE")
            {
                cbr.setOutputChannel(testParam.motorChannel[0], 0);
            }
            else
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.motorChannel[3]));
            }

        }
        private void piston_down()
        {
            cbr.setOutputChannel(testParam.directionChannel0, Convert.ToUInt32(testParam.directionDownValues[0]));
            cbr.setOutputChannel(testParam.directionChannel1, Convert.ToUInt32(testParam.directionDownValues[1]));
            if (testParam.pressType == "CBR")
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.motorChannel[3]));
            }
            else if (testParam.testDirection && testParam.pressType == "CUBE")
            {
                cbr.setOutputChannel(testParam.motorChannel[0], Convert.ToUInt32(testParam.motorChannel[3]));
            }
            else
            {
                cbr.setOutputChannel(testParam.motorChannel[0], 0);
            }
        }

        private void manualPistonControl_Tick(object sender, EventArgs e)
        {
            //cbr.setDevice();
        }

        private void testSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkLimitSwitch.Enabled = false;
            checkLimitSwitch.Stop();
        }

        private void liftPiston_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {            
            if (dataGridView1.SelectedRows[0].Cells["endCondition0"].Value.ToString() == "MAXFORCE")
            {                
                maxForceTextBox.Visible = true;
                label2.Visible = true;
                maxForceTextBox.Text = dataGridView1.SelectedRows[0].Cells["endValue0"].Value.ToString();
            }
            else
            {
                maxForceTextBox.Visible = false;
                label2.Visible = false;
            }                        
        }
    }
}

