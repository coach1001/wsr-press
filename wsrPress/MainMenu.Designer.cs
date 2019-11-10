namespace wsrPress
{
    partial class mainMenu
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
            this.runTest = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dropPiston = new System.Windows.Forms.Button();
            this.liftPiston = new System.Windows.Forms.Button();
            this.pistonLabel = new System.Windows.Forms.Label();
            this.checkLimitSwitch = new System.Windows.Forms.Timer(this.components);
            this.manualPistonControl = new System.Windows.Forms.Timer(this.components);
            this.motor_channelsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.motor_channelsTableAdapter();
            this.limit_channelsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.limit_channelsTableAdapter();
            this.pressDataSet_ = new wsrPress.pressDataSet();
            this.direction_channelsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.direction_channelsTableAdapter();
            this.force_channelsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.force_channelsTableAdapter();
            this.displacement_channelsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.displacement_channelsTableAdapter();
            this.debugGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test_runsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_runsTableAdapter();
            this.general_settingsTableAdapter1 = new wsrPress.pressDataSetTableAdapters.general_settingsTableAdapter();
            this.dispAbs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).BeginInit();
            this.debugGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // runTest
            // 
            this.runTest.Location = new System.Drawing.Point(12, 12);
            this.runTest.Name = "runTest";
            this.runTest.Size = new System.Drawing.Size(252, 56);
            this.runTest.TabIndex = 0;
            this.runTest.Text = "<F1> Run Test ";
            this.runTest.UseVisualStyleBackColor = true;
            this.runTest.Click += new System.EventHandler(this.runTest_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(12, 74);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(252, 56);
            this.results.TabIndex = 1;
            this.results.Text = "<F2> View Results ";
            this.results.UseVisualStyleBackColor = true;
            this.results.Click += new System.EventHandler(this.results_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 136);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(252, 56);
            this.exit.TabIndex = 2;
            this.exit.Text = "<F3> Exit ";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dropPiston
            // 
            this.dropPiston.Location = new System.Drawing.Point(12, 325);
            this.dropPiston.Name = "dropPiston";
            this.dropPiston.Size = new System.Drawing.Size(120, 56);
            this.dropPiston.TabIndex = 3;
            this.dropPiston.Text = "<F5> Drop Piston";
            this.dropPiston.UseVisualStyleBackColor = true;
            this.dropPiston.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dropPiston_MouseDown);
            this.dropPiston.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dropPiston_MouseUp);
            // 
            // liftPiston
            // 
            this.liftPiston.Location = new System.Drawing.Point(144, 325);
            this.liftPiston.Name = "liftPiston";
            this.liftPiston.Size = new System.Drawing.Size(120, 56);
            this.liftPiston.TabIndex = 4;
            this.liftPiston.Text = "<F6> Lift Piston";
            this.liftPiston.UseVisualStyleBackColor = true;
            this.liftPiston.MouseDown += new System.Windows.Forms.MouseEventHandler(this.liftPiston_MouseDown);
            this.liftPiston.MouseUp += new System.Windows.Forms.MouseEventHandler(this.liftPiston_MouseUp);
            // 
            // pistonLabel
            // 
            this.pistonLabel.AutoSize = true;
            this.pistonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pistonLabel.ForeColor = System.Drawing.Color.Red;
            this.pistonLabel.Location = new System.Drawing.Point(12, 297);
            this.pistonLabel.Name = "pistonLabel";
            this.pistonLabel.Size = new System.Drawing.Size(152, 25);
            this.pistonLabel.TabIndex = 5;
            this.pistonLabel.Text = "PISTON IDLE";
            // 
            // checkLimitSwitch
            // 
            this.checkLimitSwitch.Tick += new System.EventHandler(this.checkLimitSwitch_Tick);
            // 
            // manualPistonControl
            // 
            this.manualPistonControl.Tick += new System.EventHandler(this.manualPistonControl_Tick);
            // 
            // motor_channelsTableAdapter_
            // 
            this.motor_channelsTableAdapter_.ClearBeforeFill = true;
            // 
            // limit_channelsTableAdapter_
            // 
            this.limit_channelsTableAdapter_.ClearBeforeFill = true;
            // 
            // pressDataSet_
            // 
            this.pressDataSet_.DataSetName = "pressDataSet";
            this.pressDataSet_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // direction_channelsTableAdapter_
            // 
            this.direction_channelsTableAdapter_.ClearBeforeFill = true;
            // 
            // force_channelsTableAdapter_
            // 
            this.force_channelsTableAdapter_.ClearBeforeFill = true;
            // 
            // displacement_channelsTableAdapter_
            // 
            this.displacement_channelsTableAdapter_.ClearBeforeFill = true;
            // 
            // debugGroup
            // 
            this.debugGroup.Controls.Add(this.label8);
            this.debugGroup.Controls.Add(this.label7);
            this.debugGroup.Controls.Add(this.label6);
            this.debugGroup.Controls.Add(this.label5);
            this.debugGroup.Controls.Add(this.label4);
            this.debugGroup.Controls.Add(this.label3);
            this.debugGroup.Controls.Add(this.label2);
            this.debugGroup.Controls.Add(this.label1);
            this.debugGroup.Location = new System.Drawing.Point(15, 202);
            this.debugGroup.Name = "debugGroup";
            this.debugGroup.Size = new System.Drawing.Size(248, 92);
            this.debugGroup.TabIndex = 6;
            this.debugGroup.TabStop = false;
            this.debugGroup.Text = "Debug Group";
            this.debugGroup.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // test_runsTableAdapter_
            // 
            this.test_runsTableAdapter_.ClearBeforeFill = true;
            // 
            // general_settingsTableAdapter1
            // 
            this.general_settingsTableAdapter1.ClearBeforeFill = true;
            // 
            // dispAbs
            // 
            this.dispAbs.AutoSize = true;
            this.dispAbs.Location = new System.Drawing.Point(193, 306);
            this.dispAbs.Name = "dispAbs";
            this.dispAbs.Size = new System.Drawing.Size(69, 13);
            this.dispAbs.TabIndex = 22;
            this.dispAbs.Text = "displacement";
            this.dispAbs.Visible = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 393);
            this.Controls.Add(this.dispAbs);
            this.Controls.Add(this.debugGroup);
            this.Controls.Add(this.pistonLabel);
            this.Controls.Add(this.liftPiston);
            this.Controls.Add(this.dropPiston);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.results);
            this.Controls.Add(this.runTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainMenu_FormClosing);
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).EndInit();
            this.debugGroup.ResumeLayout(false);
            this.debugGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runTest;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button dropPiston;
        private System.Windows.Forms.Button liftPiston;
        private System.Windows.Forms.Label pistonLabel;
        private pressDataSetTableAdapters.motor_channelsTableAdapter motor_channelsTableAdapter_;
        private pressDataSetTableAdapters.limit_channelsTableAdapter limit_channelsTableAdapter_;
        private pressDataSet pressDataSet_;
        private pressDataSetTableAdapters.direction_channelsTableAdapter direction_channelsTableAdapter_;
        private System.Windows.Forms.Timer checkLimitSwitch;
        private pressDataSetTableAdapters.force_channelsTableAdapter force_channelsTableAdapter_;
        private pressDataSetTableAdapters.displacement_channelsTableAdapter displacement_channelsTableAdapter_;
        private System.Windows.Forms.Timer manualPistonControl;
        private System.Windows.Forms.GroupBox debugGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private pressDataSetTableAdapters.test_runsTableAdapter test_runsTableAdapter_;
        private pressDataSetTableAdapters.general_settingsTableAdapter general_settingsTableAdapter1;
        private System.Windows.Forms.Label dispAbs;
    }
}