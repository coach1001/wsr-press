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
    public partial class mainMenu : Form
    {
        int piston = 0; //0-Idle 1-Lift 2-Drop
        pressController cbr;       
        testParams testParam = new testParams();
        bool rangeMinExceeded =  false;
        bool rangeMaxExceeded = false;

        public mainMenu()
        {
            InitializeComponent();
            //checkLimitSwitch.Enabled = true;
            //checkLimitSwitch.Start();          
        }
        

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F5")
            {
                if (!rangeMaxExceeded)
                {
                    if (piston == 0) { pistonLabel.Text = "PISTON DROPPING!"; piston = 1; piston_down(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }                    
                }
            }
            else if(e.KeyCode.ToString() == "F6")
            {
                if (!rangeMinExceeded)
                {
                    if (piston == 0) { pistonLabel.Text = "PISTON RISING!"; piston = 2; piston_up(); manualPistonControl.Enabled = true; manualPistonControl.Start(); }                    
                }
            } else if (e.KeyCode.ToString() == "s" || e.KeyCode.ToString() == "S")
            {
                dispAbs.Visible = true;
            }

            else if (e.KeyCode.ToString() == "F3") { this.Close(); }
            else if (e.KeyCode.ToString() == "F1")
            {
                openTest();
            }
            else if (e.KeyCode.ToString() == "F12")
            {
                openDebugWindow();
            }
            else if (e.KeyCode.ToString() == "F2")
            {
                openViewResults();
            }
        }

        private void MainMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F5")
            {
                if (piston == 1) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }
            }
            else if (e.KeyCode.ToString() == "F6")
            {
                if (piston == 2) { pistonLabel.Text = "PISTON IDLE"; piston = 0; piston_stop(); manualPistonControl.Enabled = false; manualPistonControl.Stop(); }
            }
            
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

        private void runTest_Click(object sender, EventArgs e)
        {
            openTest();
        }
        private void openTest(){
            piston_stop();
            testSelect testSelectForm = new testSelect(cbr,testParam);
            checkLimitSwitch.Enabled = false;
            checkLimitSwitch.Stop();
            testSelectForm.ShowDialog();
            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();            
        }

        private void openDebugWindow()
        {
            piston_stop();
            debugWindow debug = new debugWindow(cbr);
            debug.ShowDialog();
            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pressDataSet_.displacement_channels' table. You can move, or remove it, as needed.
           
            motor_channelsTableAdapter_.Fill(pressDataSet_.motor_channels);
            limit_channelsTableAdapter_.Fill(pressDataSet_.limit_channels);
            direction_channelsTableAdapter_.Fill(pressDataSet_.direction_channels);
            force_channelsTableAdapter_.Fill(pressDataSet_.force_channels);
            displacement_channelsTableAdapter_.Fill(pressDataSet_.displacement_channels);
            general_settingsTableAdapter1.Fill(pressDataSet_.general_settings);

            testParam.forceChannel = Convert.ToInt32(pressDataSet_.force_channels[0]["inputChannel"]);
            //cbr.divider = Convert.ToInt32(pressDataSet_.force_channels[0]["avgNumPoints"]);
           // Console.WriteLine(cbr.divider.ToString());
            string port = pressDataSet_.general_settings[0]["port"].ToString();
            int baud = Convert.ToInt32(pressDataSet_.general_settings[0]["baudRate"]);
            testParam.pressType = pressDataSet_.general_settings[0]["machineType"].ToString();
            testParam.testDirection = Convert.ToBoolean(pressDataSet_.general_settings[0]["testDirection"]);

            
            testParam.dispChannel  = Convert.ToInt32(pressDataSet_.displacement_channels[0]["inputChannel"]);
            
            testParam.dispCoff[0] = Convert.ToDouble(pressDataSet_.displacement_channels[0]["A"]);
            testParam.dispCoff[1] = Convert.ToDouble(pressDataSet_.displacement_channels[0]["B"]);
            testParam.dispCoff[2] = Convert.ToDouble(pressDataSet_.displacement_channels[0]["C"]);
            testParam.dispCoff[3] = Convert.ToDouble(pressDataSet_.displacement_channels[0]["D"]);

            testParam.motorChannel[0] = Convert.ToInt32(pressDataSet_.motor_channels[0]["outputChannel"]);
            testParam.motorChannel[1] = Convert.ToInt32(pressDataSet_.motor_channels[0]["motorIdleSpeed"]);
            testParam.motorChannel[2] = Convert.ToInt32(pressDataSet_.motor_channels[0]["approachSpeed"]);
            testParam.motorChannel[3] = Convert.ToInt32(pressDataSet_.motor_channels[0]["manualSpeed"]);
            testParam.motorChannel[4] = Convert.ToInt32(pressDataSet_.motor_channels[0]["maxRawValue"]);

            testParam.limitChannel[0] = Convert.ToInt32(pressDataSet_.limit_channels[0]["input_channel"]);
            testParam.limitChannel[2] = Convert.ToInt32(pressDataSet_.limit_channels[0]["lower_limit"]);
            testParam.limitChannel[3] = Convert.ToInt32(pressDataSet_.limit_channels[0]["upper_limit"]);

            testParam.directionChannel0 = Convert.ToInt32(pressDataSet_.direction_channels[0]["outputChannel0"]);
            testParam.directionChannel1 = Convert.ToInt32(pressDataSet_.direction_channels[0]["outputChannel1"]);

            testParam.directionUpValues[0] = Convert.ToInt32(pressDataSet_.direction_channels[0]["upChannel0Value"]);
            testParam.directionUpValues[1] = Convert.ToInt32(pressDataSet_.direction_channels[0]["upChannel1Value"]);

            testParam.directionDownValues[0] = Convert.ToInt32(pressDataSet_.direction_channels[0]["downChannel0Value"]);
            testParam.directionDownValues[1] = Convert.ToInt32(pressDataSet_.direction_channels[0]["downChannel1Value"]);

            testParam.potMin = Convert.ToDouble(pressDataSet_.displacement_channels[0]["minRawValue"]);
            testParam.potMax = Convert.ToDouble(pressDataSet_.displacement_channels[0]["maxRawValue"]);
            testParam.potRange = Convert.ToDouble(pressDataSet_.displacement_channels[0]["C"]);
            testParam.potRangeMin = Convert.ToDouble(pressDataSet_.displacement_channels[0]["A"]);
            testParam.potRangeMax = Convert.ToDouble(pressDataSet_.displacement_channels[0]["B"]);
            //Console.WriteLine(testParam.potMin + " " + testParam.potMax + " " + testParam.potRange);

            try
            {                
                cbr = new pressController(port,baud);
            }catch(Exception ex)
            {
                SetCommPort sc =  new SetCommPort();
                sc.ShowDialog();
                Environment.Exit(0);
            }
            
            cbr.pressSerialPort.DiscardInBuffer();
            cbr.pressSerialPort.DiscardOutBuffer();

            cbr.writeReadDevice();
            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();          
            
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
            if(piston == 1)
            {
                piston = 2; piston_up();
            }
            else if(piston == 2)
            {
                piston = 1; piston_down();
            }
        }

        private int check_limits()
        {
            UInt32 value;
            //cbr.getDevice();
            label1.Text = cbr.returnInputChannel(0).ToString();            
            label2.Text = cbr.returnInputChannel(1).ToString();
            label3.Text = cbr.returnInputChannel(2).ToString();
            label4.Text = cbr.returnInputChannel(3).ToString();
            label5.Text = cbr.returnInputChannel(4).ToString();
            label6.Text = cbr.returnInputChannel(5).ToString();
            label7.Text = cbr.returnInputChannel(6).ToString();
            label8.Text = cbr.returnInputChannel(7).ToString();
            
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
            } else
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
        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                cbr.pressSerialPort.Close();                
            }
            
        }

        private void openViewResults()
        {
            piston_stop();
            viewResults viewResults_ = new viewResults();
            viewResults_.ShowDialog();
            checkLimitSwitch.Enabled = true;
            checkLimitSwitch.Start();      
        }

        private void results_Click(object sender, EventArgs e)
        {
            openViewResults();
        }
      
    }
}


