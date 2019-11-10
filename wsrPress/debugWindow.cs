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
    public partial class debugWindow : Form
    {
        pressController cbr;

        pressDataSet.general_settingsRow gsetRow;
        pressDataSet.calibration_coffRow coffRow;

        public debugWindow(pressController cbr_)
        {
            InitializeComponent();
            cbr = cbr_;

            calibration_coffTableAdapter1.FillBykNSet(pressDataSet1.calibration_coff, 2);
            general_settingsTableAdapter1.Fill(pressDataSet1.general_settings);            
            
            gsetRow = pressDataSet1.general_settings[0];
            coffRow = pressDataSet1.calibration_coff[0];
                        
            aValue.Text = coffRow["A"].ToString();
            bValue.Text = coffRow["B"].ToString();
            cValue.Text = coffRow["C"].ToString();
            dValue.Text = coffRow["D"].ToString();
            comPort.Text = gsetRow["port"].ToString();
           
            //readDevice.Enabled = true;
            //readDevice.Start();
            //setDevice.Enabled = true;
            //setDevice.Start();
            labelUpdater.Enabled = true;
            labelUpdater.Start();

        }


        private void readDevice_Tick(object sender, EventArgs e)
        {
            cbr.getDevice();
        }

        private void outputChannel0_Scroll(object sender, EventArgs e)
        {
            cbr.setOutputChannel(0, Convert.ToUInt32(outputChannel0.Value));
            pwm0Box.Text = outputChannel0.Value.ToString();
        }

        private void outputChannel1_Scroll(object sender, EventArgs e)
        {
            cbr.setOutputChannel(1, Convert.ToUInt32(outputChannel0.Value));
            pwm1Box.Text = outputChannel1.Value.ToString();            
        }

        private void outputChannel2_CheckedChanged(object sender, EventArgs e)
        {
            cbr.setOutputChannel(2, Convert.ToUInt32(outputChannel2.Checked));
        }

        private void outputChannel3_CheckedChanged(object sender, EventArgs e)
        {
            cbr.setOutputChannel(3, Convert.ToUInt32(outputChannel3.Checked));
        }

        private void outputChannel4_CheckedChanged(object sender, EventArgs e)
        {
            cbr.setOutputChannel(4, Convert.ToUInt32(outputChannel4.Checked));
        }

        private void outputChannel5_CheckedChanged(object sender, EventArgs e)
        {
            cbr.setOutputChannel(5, Convert.ToUInt32(outputChannel5.Checked));
        }

        private void outputChannel6_CheckedChanged(object sender, EventArgs e)
        {
            cbr.setOutputChannel(6, Convert.ToUInt32(outputChannel6.Checked));
        }

        private void setDevice_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Device : "+ cbr.outputChannel[2].ToString()+ ' ' + cbr.outputChannel[3].ToString()+ ' ' +cbr.outputChannel[4].ToString());
            Console.WriteLine("UI : " + outputChannel2.CheckState.ToString() + ' ' + outputChannel3.CheckState.ToString() + ' ' + outputChannel4.CheckState.ToString());
            cbr.setOutputChannel(2, Convert.ToUInt32(outputChannel2.Checked));
            cbr.setOutputChannel(3, Convert.ToUInt32(outputChannel3.Checked));
            cbr.setOutputChannel(4, Convert.ToUInt32(outputChannel4.Checked));
            //cbr.setDevice();
        }

        private void debugWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //readDevice.Enabled = false;
            //readDevice.Stop();
            //setDevice.Enabled = false;
            //setDevice.Stop();
        }

        private void debugWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "S")
            labelUpdater.Stop();
        }

        private void debugWindow_Load(object sender, EventArgs e)
        {

        }

        private void labelUpdater_Tick(object sender, EventArgs e)
        {
            inputChannel0.Text = cbr.returnInputChannel(0).ToString();
            inputChannel1.Text = cbr.returnInputChannel(1).ToString();
            inputChannel2.Text = cbr.returnInputChannel(2).ToString();
            inputChannel3.Text = cbr.returnInputChannel(3).ToString();
            inputChannel4.Text = cbr.returnInputChannel(4).ToString();
            inputChannel5.Text = cbr.returnInputChannel(5).ToString();
            inputChannel6.Checked = Convert.ToBoolean(cbr.returnInputChannel(6));
            inputChannel7.Checked = Convert.ToBoolean(cbr.returnInputChannel(7));

        }

        private void debugWindow_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if(e.KeyCode.ToString()=="S")
            labelUpdater.Start();
        }

        private void btnPWM0add_Click(object sender, EventArgs e)
        {
            if ((outputChannel0.Value + 1) > 16000)
                outputChannel0.Value = 16000;
            else
                outputChannel0.Value += 1;
            
            pwm0Box.Text = outputChannel0.Value.ToString();
            cbr.setOutputChannel(0, Convert.ToUInt32(outputChannel0.Value));
        
        }

        private void btnPWM0sub_Click(object sender, EventArgs e)
        {
            if ((outputChannel0.Value - 1) < 0)
                outputChannel0.Value = 0;
            else
                outputChannel0.Value -= 1;
            
            pwm0Box.Text = outputChannel0.Value.ToString();
            cbr.setOutputChannel(0, Convert.ToUInt32(outputChannel0.Value));
        
        }

        private void btnPWM0sub5_Click(object sender, EventArgs e)
        {
            if ((outputChannel0.Value - 5) < 0)
                outputChannel0.Value = 0;
            else
                outputChannel0.Value -= 5;
            
            pwm0Box.Text = outputChannel0.Value.ToString();
            cbr.setOutputChannel(0, Convert.ToUInt32(outputChannel0.Value));
        
        }

        private void btnPWM0add5_Click(object sender, EventArgs e)
        {
            if ((outputChannel0.Value + 5) > 16000)
                outputChannel0.Value = 16000;
            else
                outputChannel0.Value += 5;
            
            pwm0Box.Text = outputChannel0.Value.ToString();
            cbr.setOutputChannel(0, Convert.ToUInt32(outputChannel0.Value));
        
        }

        private void resetCoff_()
        {
            aValue.Text = coffRow["A"].ToString();
            bValue.Text = coffRow["B"].ToString();
            cValue.Text = coffRow["C"].ToString();
            dValue.Text = coffRow["D"].ToString();
            comPort.Text = gsetRow["port"].ToString();
        }

        private void saveCoff_()
        {
            
            try
            {
                coffRow["A"] = Convert.ToDouble(aValue.Text);
                coffRow["B"] = Convert.ToDouble(bValue.Text);
                coffRow["C"] = Convert.ToDouble(cValue.Text);
                coffRow["D"] = Convert.ToDouble(dValue.Text);
                gsetRow["port"] = comPort.Text.ToString();
                

                calibration_coffTableAdapter1.Update(coffRow);
                //general_settingsTableAdapter1.Update(gsetRow);
                general_settingsTableAdapter1.UpdateComPort(comPort.Text);

                calibration_coffTableAdapter1.FillBykNSet(pressDataSet1.calibration_coff, 2);
                general_settingsTableAdapter1.Fill(pressDataSet1.general_settings);
                gsetRow = pressDataSet1.general_settings[0];
                coffRow = pressDataSet1.calibration_coff[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void resetCoff_Click(object sender, EventArgs e)
        {
            resetCoff_();
            saveCoff_();
        }

        private void saveCoff_Click(object sender, EventArgs e)
        {
            saveCoff_();
        }

    }
}
