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
    public partial class SetCommPort : Form
    {
        
        public SetCommPort()
        {
            InitializeComponent();
            general_settingsTableAdapter1.Fill(pressDataSet1.general_settings);
            textBox1.Text = pressDataSet1.general_settings[0]["port"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            general_settingsTableAdapter1.UpdateComPort(textBox1.Text);
            Environment.Exit(0);
        }
    }
}
