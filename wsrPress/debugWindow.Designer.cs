namespace wsrPress
{
    partial class debugWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.readDevice = new System.Windows.Forms.Timer(this.components);
            this.inputChannel0 = new System.Windows.Forms.TextBox();
            this.inputChannel1 = new System.Windows.Forms.TextBox();
            this.inputChannel2 = new System.Windows.Forms.TextBox();
            this.inputChannel3 = new System.Windows.Forms.TextBox();
            this.inputChannel4 = new System.Windows.Forms.TextBox();
            this.inputChannel6 = new System.Windows.Forms.CheckBox();
            this.inputChannel7 = new System.Windows.Forms.CheckBox();
            this.outputChannel2 = new System.Windows.Forms.CheckBox();
            this.outputChannel3 = new System.Windows.Forms.CheckBox();
            this.outputChannel4 = new System.Windows.Forms.CheckBox();
            this.outputChannel5 = new System.Windows.Forms.CheckBox();
            this.outputChannel0 = new System.Windows.Forms.TrackBar();
            this.outputChannel1 = new System.Windows.Forms.TrackBar();
            this.outputChannel6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputChannel5 = new System.Windows.Forms.TextBox();
            this.setDevice = new System.Windows.Forms.Timer(this.components);
            this.pwm0Box = new System.Windows.Forms.TextBox();
            this.pwm1Box = new System.Windows.Forms.TextBox();
            this.labelUpdater = new System.Windows.Forms.Timer(this.components);
            this.btnPWM0add = new System.Windows.Forms.Button();
            this.btnPWM0sub = new System.Windows.Forms.Button();
            this.btnPWM0sub5 = new System.Windows.Forms.Button();
            this.btnPWM0add5 = new System.Windows.Forms.Button();
            this.aValue = new System.Windows.Forms.TextBox();
            this.bValue = new System.Windows.Forms.TextBox();
            this.cValue = new System.Windows.Forms.TextBox();
            this.dValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calibration_coffTableAdapter1 = new wsrPress.pressDataSetTableAdapters.calibration_coffTableAdapter();
            this.pressDataSet1 = new wsrPress.pressDataSet();
            this.resetCoff = new System.Windows.Forms.Button();
            this.saveCoff = new System.Windows.Forms.Button();
            this.general_settingsTableAdapter1 = new wsrPress.pressDataSetTableAdapters.general_settingsTableAdapter();
            this.comPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outputChannel0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChannel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // readDevice
            // 
            this.readDevice.Enabled = true;
            this.readDevice.Interval = 1;
            this.readDevice.Tick += new System.EventHandler(this.readDevice_Tick);
            // 
            // inputChannel0
            // 
            this.inputChannel0.Enabled = false;
            this.inputChannel0.Location = new System.Drawing.Point(13, 29);
            this.inputChannel0.Name = "inputChannel0";
            this.inputChannel0.Size = new System.Drawing.Size(100, 20);
            this.inputChannel0.TabIndex = 0;
            // 
            // inputChannel1
            // 
            this.inputChannel1.Enabled = false;
            this.inputChannel1.Location = new System.Drawing.Point(120, 29);
            this.inputChannel1.Name = "inputChannel1";
            this.inputChannel1.Size = new System.Drawing.Size(100, 20);
            this.inputChannel1.TabIndex = 1;
            // 
            // inputChannel2
            // 
            this.inputChannel2.Enabled = false;
            this.inputChannel2.Location = new System.Drawing.Point(227, 28);
            this.inputChannel2.Name = "inputChannel2";
            this.inputChannel2.Size = new System.Drawing.Size(100, 20);
            this.inputChannel2.TabIndex = 2;
            // 
            // inputChannel3
            // 
            this.inputChannel3.Enabled = false;
            this.inputChannel3.Location = new System.Drawing.Point(334, 28);
            this.inputChannel3.Name = "inputChannel3";
            this.inputChannel3.Size = new System.Drawing.Size(100, 20);
            this.inputChannel3.TabIndex = 3;
            // 
            // inputChannel4
            // 
            this.inputChannel4.Enabled = false;
            this.inputChannel4.Location = new System.Drawing.Point(441, 29);
            this.inputChannel4.Name = "inputChannel4";
            this.inputChannel4.Size = new System.Drawing.Size(100, 20);
            this.inputChannel4.TabIndex = 4;
            // 
            // inputChannel6
            // 
            this.inputChannel6.AutoSize = true;
            this.inputChannel6.Enabled = false;
            this.inputChannel6.Location = new System.Drawing.Point(13, 55);
            this.inputChannel6.Name = "inputChannel6";
            this.inputChannel6.Size = new System.Drawing.Size(62, 17);
            this.inputChannel6.TabIndex = 5;
            this.inputChannel6.Text = "Limit - 0";
            this.inputChannel6.UseVisualStyleBackColor = true;
            // 
            // inputChannel7
            // 
            this.inputChannel7.AutoSize = true;
            this.inputChannel7.Enabled = false;
            this.inputChannel7.Location = new System.Drawing.Point(120, 55);
            this.inputChannel7.Name = "inputChannel7";
            this.inputChannel7.Size = new System.Drawing.Size(59, 17);
            this.inputChannel7.TabIndex = 6;
            this.inputChannel7.Text = "Limit -1";
            this.inputChannel7.UseVisualStyleBackColor = true;
            // 
            // outputChannel2
            // 
            this.outputChannel2.AutoSize = true;
            this.outputChannel2.Location = new System.Drawing.Point(13, 121);
            this.outputChannel2.Name = "outputChannel2";
            this.outputChannel2.Size = new System.Drawing.Size(68, 17);
            this.outputChannel2.TabIndex = 7;
            this.outputChannel2.Text = "Valve - 0";
            this.outputChannel2.UseVisualStyleBackColor = true;
            this.outputChannel2.CheckedChanged += new System.EventHandler(this.outputChannel2_CheckedChanged);
            // 
            // outputChannel3
            // 
            this.outputChannel3.AutoSize = true;
            this.outputChannel3.Location = new System.Drawing.Point(87, 121);
            this.outputChannel3.Name = "outputChannel3";
            this.outputChannel3.Size = new System.Drawing.Size(68, 17);
            this.outputChannel3.TabIndex = 8;
            this.outputChannel3.Text = "Valve - 1";
            this.outputChannel3.UseVisualStyleBackColor = true;
            this.outputChannel3.CheckedChanged += new System.EventHandler(this.outputChannel3_CheckedChanged);
            // 
            // outputChannel4
            // 
            this.outputChannel4.AutoSize = true;
            this.outputChannel4.Location = new System.Drawing.Point(167, 121);
            this.outputChannel4.Name = "outputChannel4";
            this.outputChannel4.Size = new System.Drawing.Size(53, 17);
            this.outputChannel4.TabIndex = 9;
            this.outputChannel4.Text = "Relay";
            this.outputChannel4.UseVisualStyleBackColor = true;
            this.outputChannel4.CheckedChanged += new System.EventHandler(this.outputChannel4_CheckedChanged);
            // 
            // outputChannel5
            // 
            this.outputChannel5.AutoSize = true;
            this.outputChannel5.Location = new System.Drawing.Point(226, 121);
            this.outputChannel5.Name = "outputChannel5";
            this.outputChannel5.Size = new System.Drawing.Size(48, 17);
            this.outputChannel5.TabIndex = 10;
            this.outputChannel5.Text = "SSR";
            this.outputChannel5.UseVisualStyleBackColor = true;
            this.outputChannel5.CheckedChanged += new System.EventHandler(this.outputChannel5_CheckedChanged);
            // 
            // outputChannel0
            // 
            this.outputChannel0.LargeChange = 500;
            this.outputChannel0.Location = new System.Drawing.Point(62, 154);
            this.outputChannel0.Maximum = 16000;
            this.outputChannel0.Name = "outputChannel0";
            this.outputChannel0.Size = new System.Drawing.Size(479, 45);
            this.outputChannel0.SmallChange = 100;
            this.outputChannel0.TabIndex = 11;
            this.outputChannel0.TickStyle = System.Windows.Forms.TickStyle.None;
            this.outputChannel0.Scroll += new System.EventHandler(this.outputChannel0_Scroll);
            // 
            // outputChannel1
            // 
            this.outputChannel1.LargeChange = 500;
            this.outputChannel1.Location = new System.Drawing.Point(61, 189);
            this.outputChannel1.Maximum = 16000;
            this.outputChannel1.Name = "outputChannel1";
            this.outputChannel1.Size = new System.Drawing.Size(480, 45);
            this.outputChannel1.SmallChange = 100;
            this.outputChannel1.TabIndex = 12;
            this.outputChannel1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.outputChannel1.Scroll += new System.EventHandler(this.outputChannel1_Scroll);
            // 
            // outputChannel6
            // 
            this.outputChannel6.AutoSize = true;
            this.outputChannel6.Location = new System.Drawing.Point(280, 121);
            this.outputChannel6.Name = "outputChannel6";
            this.outputChannel6.Size = new System.Drawing.Size(83, 17);
            this.outputChannel6.TabIndex = 13;
            this.outputChannel6.Text = "Reset Proxy";
            this.outputChannel6.UseVisualStyleBackColor = true;
            this.outputChannel6.CheckedChanged += new System.EventHandler(this.outputChannel6_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "PWM - 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PWM - 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "HX711 - 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "HX711 - 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "ADC - 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ADC - 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "ADC - 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ADC - 3";
            // 
            // inputChannel5
            // 
            this.inputChannel5.Enabled = false;
            this.inputChannel5.Location = new System.Drawing.Point(547, 29);
            this.inputChannel5.Name = "inputChannel5";
            this.inputChannel5.Size = new System.Drawing.Size(100, 20);
            this.inputChannel5.TabIndex = 21;
            // 
            // setDevice
            // 
            this.setDevice.Interval = 10;
            this.setDevice.Tick += new System.EventHandler(this.setDevice_Tick);
            // 
            // pwm0Box
            // 
            this.pwm0Box.Enabled = false;
            this.pwm0Box.Location = new System.Drawing.Point(547, 154);
            this.pwm0Box.Name = "pwm0Box";
            this.pwm0Box.Size = new System.Drawing.Size(100, 20);
            this.pwm0Box.TabIndex = 23;
            // 
            // pwm1Box
            // 
            this.pwm1Box.Enabled = false;
            this.pwm1Box.Location = new System.Drawing.Point(547, 189);
            this.pwm1Box.Name = "pwm1Box";
            this.pwm1Box.Size = new System.Drawing.Size(100, 20);
            this.pwm1Box.TabIndex = 24;
            // 
            // labelUpdater
            // 
            this.labelUpdater.Interval = 10;
            this.labelUpdater.Tick += new System.EventHandler(this.labelUpdater_Tick);
            // 
            // btnPWM0add
            // 
            this.btnPWM0add.Location = new System.Drawing.Point(742, 152);
            this.btnPWM0add.Name = "btnPWM0add";
            this.btnPWM0add.Size = new System.Drawing.Size(33, 23);
            this.btnPWM0add.TabIndex = 25;
            this.btnPWM0add.Text = ">";
            this.btnPWM0add.UseVisualStyleBackColor = true;
            this.btnPWM0add.Click += new System.EventHandler(this.btnPWM0add_Click);
            // 
            // btnPWM0sub
            // 
            this.btnPWM0sub.Location = new System.Drawing.Point(703, 152);
            this.btnPWM0sub.Name = "btnPWM0sub";
            this.btnPWM0sub.Size = new System.Drawing.Size(33, 23);
            this.btnPWM0sub.TabIndex = 26;
            this.btnPWM0sub.Text = "<";
            this.btnPWM0sub.UseVisualStyleBackColor = true;
            this.btnPWM0sub.Click += new System.EventHandler(this.btnPWM0sub_Click);
            // 
            // btnPWM0sub5
            // 
            this.btnPWM0sub5.Location = new System.Drawing.Point(664, 152);
            this.btnPWM0sub5.Name = "btnPWM0sub5";
            this.btnPWM0sub5.Size = new System.Drawing.Size(33, 23);
            this.btnPWM0sub5.TabIndex = 27;
            this.btnPWM0sub5.Text = "<<";
            this.btnPWM0sub5.UseVisualStyleBackColor = true;
            this.btnPWM0sub5.Click += new System.EventHandler(this.btnPWM0sub5_Click);
            // 
            // btnPWM0add5
            // 
            this.btnPWM0add5.Location = new System.Drawing.Point(781, 152);
            this.btnPWM0add5.Name = "btnPWM0add5";
            this.btnPWM0add5.Size = new System.Drawing.Size(33, 23);
            this.btnPWM0add5.TabIndex = 28;
            this.btnPWM0add5.Text = ">>";
            this.btnPWM0add5.UseVisualStyleBackColor = true;
            this.btnPWM0add5.Click += new System.EventHandler(this.btnPWM0add5_Click);
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(682, 6);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(139, 20);
            this.aValue.TabIndex = 29;
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(682, 33);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(139, 20);
            this.bValue.TabIndex = 30;
            // 
            // cValue
            // 
            this.cValue.Location = new System.Drawing.Point(682, 59);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(139, 20);
            this.cValue.TabIndex = 31;
            // 
            // dValue
            // 
            this.dValue.Location = new System.Drawing.Point(682, 85);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(139, 20);
            this.dValue.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "D";
            // 
            // calibration_coffTableAdapter1
            // 
            this.calibration_coffTableAdapter1.ClearBeforeFill = true;
            // 
            // pressDataSet1
            // 
            this.pressDataSet1.DataSetName = "pressDataSet";
            this.pressDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resetCoff
            // 
            this.resetCoff.Location = new System.Drawing.Point(665, 111);
            this.resetCoff.Name = "resetCoff";
            this.resetCoff.Size = new System.Drawing.Size(75, 23);
            this.resetCoff.TabIndex = 37;
            this.resetCoff.Text = "Reset";
            this.resetCoff.UseVisualStyleBackColor = true;
            this.resetCoff.Click += new System.EventHandler(this.resetCoff_Click);
            // 
            // saveCoff
            // 
            this.saveCoff.Location = new System.Drawing.Point(746, 111);
            this.saveCoff.Name = "saveCoff";
            this.saveCoff.Size = new System.Drawing.Size(75, 23);
            this.saveCoff.TabIndex = 38;
            this.saveCoff.Text = "Save";
            this.saveCoff.UseVisualStyleBackColor = true;
            this.saveCoff.Click += new System.EventHandler(this.saveCoff_Click);
            // 
            // general_settingsTableAdapter1
            // 
            this.general_settingsTableAdapter1.ClearBeforeFill = true;
            // 
            // comPort
            // 
            this.comPort.Location = new System.Drawing.Point(520, 111);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(139, 20);
            this.comPort.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(456, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Comm Port";
            // 
            // debugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 230);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.saveCoff);
            this.Controls.Add(this.resetCoff);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dValue);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.btnPWM0add5);
            this.Controls.Add(this.btnPWM0sub5);
            this.Controls.Add(this.btnPWM0sub);
            this.Controls.Add(this.btnPWM0add);
            this.Controls.Add(this.pwm1Box);
            this.Controls.Add(this.pwm0Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputChannel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputChannel6);
            this.Controls.Add(this.outputChannel1);
            this.Controls.Add(this.outputChannel0);
            this.Controls.Add(this.outputChannel5);
            this.Controls.Add(this.outputChannel4);
            this.Controls.Add(this.outputChannel3);
            this.Controls.Add(this.outputChannel2);
            this.Controls.Add(this.inputChannel7);
            this.Controls.Add(this.inputChannel6);
            this.Controls.Add(this.inputChannel4);
            this.Controls.Add(this.inputChannel3);
            this.Controls.Add(this.inputChannel2);
            this.Controls.Add(this.inputChannel1);
            this.Controls.Add(this.inputChannel0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "debugWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debug Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.debugWindow_FormClosing);
            this.Load += new System.EventHandler(this.debugWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.debugWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.debugWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.outputChannel0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputChannel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer readDevice;
        private System.Windows.Forms.TextBox inputChannel0;
        private System.Windows.Forms.TextBox inputChannel1;
        private System.Windows.Forms.TextBox inputChannel2;
        private System.Windows.Forms.TextBox inputChannel3;
        private System.Windows.Forms.TextBox inputChannel4;
        private System.Windows.Forms.CheckBox inputChannel6;
        private System.Windows.Forms.CheckBox inputChannel7;
        private System.Windows.Forms.CheckBox outputChannel2;
        private System.Windows.Forms.CheckBox outputChannel3;
        private System.Windows.Forms.CheckBox outputChannel4;
        private System.Windows.Forms.CheckBox outputChannel5;
        private System.Windows.Forms.TrackBar outputChannel0;
        private System.Windows.Forms.TrackBar outputChannel1;
        private System.Windows.Forms.CheckBox outputChannel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputChannel5;
        private System.Windows.Forms.Timer setDevice;
        private System.Windows.Forms.TextBox pwm0Box;
        private System.Windows.Forms.TextBox pwm1Box;
        private System.Windows.Forms.Timer labelUpdater;
        private System.Windows.Forms.Button btnPWM0add;
        private System.Windows.Forms.Button btnPWM0sub;
        private System.Windows.Forms.Button btnPWM0sub5;
        private System.Windows.Forms.Button btnPWM0add5;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.TextBox dValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private pressDataSetTableAdapters.calibration_coffTableAdapter calibration_coffTableAdapter1;
        private pressDataSet pressDataSet1;
        private System.Windows.Forms.Button resetCoff;
        private System.Windows.Forms.Button saveCoff;
        private pressDataSetTableAdapters.general_settingsTableAdapter general_settingsTableAdapter1;
        private System.Windows.Forms.TextBox comPort;
        private System.Windows.Forms.Label label13;
    }
}