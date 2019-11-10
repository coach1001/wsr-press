namespace wsrPress
{
    partial class testRun
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
            this.checkLimitSwitch = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PacingErrorText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mmAtMaxForce = new System.Windows.Forms.TextBox();
            this.maxForce = new System.Windows.Forms.TextBox();
            this.samplesDataGrid_ = new System.Windows.Forms.DataGridView();
            this.sampleNumber_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displacement_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.displacementTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadTextBox = new System.Windows.Forms.TextBox();
            this.emergencyStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.testGraph = new ZedGraph.ZedGraphControl();
            this.graphUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.samplingTimer = new System.Windows.Forms.Timer(this.components);
            this.approachTimer = new System.Windows.Forms.Timer(this.components);
            this.labelUpdater = new System.Windows.Forms.Timer(this.components);
            this.testOverChecker = new System.Windows.Forms.Timer(this.components);
            this.mainTestTimer = new System.Windows.Forms.Timer(this.components);
            this.test_runsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_runsTableAdapter();
            this.test_run_samplesTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_run_samplesTableAdapter();
            this.pressDataSet_ = new wsrPress.pressDataSet();
            this.general_settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_settingsTableAdapter = new wsrPress.pressDataSetTableAdapters.general_settingsTableAdapter();
            this.tableAdapterManager = new wsrPress.pressDataSetTableAdapters.TableAdapterManager();
            this.cubePressOpenValveTimer = new System.Windows.Forms.Timer(this.components);
            this.cubePressTestOverOpenValveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataGrid_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkLimitSwitch
            // 
            this.checkLimitSwitch.Tick += new System.EventHandler(this.checkLimitSwitch_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.PacingErrorText);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.mmAtMaxForce);
            this.splitContainer1.Panel1.Controls.Add(this.maxForce);
            this.splitContainer1.Panel1.Controls.Add(this.samplesDataGrid_);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.displacementTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.loadTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.emergencyStop);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.elapsedTimeTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.debugLabel);
            this.splitContainer1.Panel2.Controls.Add(this.testGraph);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 585);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 1;
            // 
            // PacingErrorText
            // 
            this.PacingErrorText.Location = new System.Drawing.Point(174, 23);
            this.PacingErrorText.Name = "PacingErrorText";
            this.PacingErrorText.Size = new System.Drawing.Size(100, 20);
            this.PacingErrorText.TabIndex = 11;
            this.PacingErrorText.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "@Max Load";
            // 
            // mmAtMaxForce
            // 
            this.mmAtMaxForce.Cursor = System.Windows.Forms.Cursors.Default;
            this.mmAtMaxForce.Enabled = false;
            this.mmAtMaxForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmAtMaxForce.ForeColor = System.Drawing.Color.Red;
            this.mmAtMaxForce.Location = new System.Drawing.Point(161, 200);
            this.mmAtMaxForce.Name = "mmAtMaxForce";
            this.mmAtMaxForce.Size = new System.Drawing.Size(114, 31);
            this.mmAtMaxForce.TabIndex = 9;
            // 
            // maxForce
            // 
            this.maxForce.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxForce.Enabled = false;
            this.maxForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxForce.ForeColor = System.Drawing.Color.Red;
            this.maxForce.Location = new System.Drawing.Point(161, 130);
            this.maxForce.Name = "maxForce";
            this.maxForce.Size = new System.Drawing.Size(114, 31);
            this.maxForce.TabIndex = 8;
            // 
            // samplesDataGrid_
            // 
            this.samplesDataGrid_.AllowUserToAddRows = false;
            this.samplesDataGrid_.AllowUserToDeleteRows = false;
            this.samplesDataGrid_.BackgroundColor = System.Drawing.Color.White;
            this.samplesDataGrid_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samplesDataGrid_.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleNumber_,
            this.displacement_,
            this.load_,
            this.time_});
            this.samplesDataGrid_.Location = new System.Drawing.Point(17, 241);
            this.samplesDataGrid_.MultiSelect = false;
            this.samplesDataGrid_.Name = "samplesDataGrid_";
            this.samplesDataGrid_.ReadOnly = true;
            this.samplesDataGrid_.RowHeadersVisible = false;
            this.samplesDataGrid_.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.samplesDataGrid_.Size = new System.Drawing.Size(258, 270);
            this.samplesDataGrid_.TabIndex = 7;
            // 
            // sampleNumber_
            // 
            this.sampleNumber_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sampleNumber_.DataPropertyName = "sampleSequence";
            this.sampleNumber_.FillWeight = 20F;
            this.sampleNumber_.HeaderText = "Sample #";
            this.sampleNumber_.Name = "sampleNumber_";
            this.sampleNumber_.ReadOnly = true;
            this.sampleNumber_.Visible = false;
            // 
            // displacement_
            // 
            this.displacement_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displacement_.DataPropertyName = "displacementMm";
            this.displacement_.FillWeight = 50F;
            this.displacement_.HeaderText = "Displacement (mm)";
            this.displacement_.Name = "displacement_";
            this.displacement_.ReadOnly = true;
            // 
            // load_
            // 
            this.load_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.load_.DataPropertyName = "forcekN";
            this.load_.FillWeight = 50F;
            this.load_.HeaderText = "Load (kN)";
            this.load_.Name = "load_";
            this.load_.ReadOnly = true;
            // 
            // time_
            // 
            this.time_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time_.DataPropertyName = "timeSeconds";
            this.time_.FillWeight = 30F;
            this.time_.HeaderText = "Time (seconds)";
            this.time_.Name = "time_";
            this.time_.ReadOnly = true;
            this.time_.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Displacement";
            // 
            // displacementTextBox
            // 
            this.displacementTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.displacementTextBox.Enabled = false;
            this.displacementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displacementTextBox.Location = new System.Drawing.Point(17, 200);
            this.displacementTextBox.Name = "displacementTextBox";
            this.displacementTextBox.Size = new System.Drawing.Size(114, 31);
            this.displacementTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Load";
            // 
            // loadTextBox
            // 
            this.loadTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadTextBox.Enabled = false;
            this.loadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTextBox.Location = new System.Drawing.Point(17, 130);
            this.loadTextBox.Name = "loadTextBox";
            this.loadTextBox.Size = new System.Drawing.Size(114, 31);
            this.loadTextBox.TabIndex = 3;
            // 
            // emergencyStop
            // 
            this.emergencyStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyStop.ForeColor = System.Drawing.Color.Red;
            this.emergencyStop.Location = new System.Drawing.Point(12, 517);
            this.emergencyStop.Name = "emergencyStop";
            this.emergencyStop.Size = new System.Drawing.Size(263, 56);
            this.emergencyStop.TabIndex = 2;
            this.emergencyStop.Text = "<F3> Emergency Stop";
            this.emergencyStop.UseVisualStyleBackColor = true;
            this.emergencyStop.Click += new System.EventHandler(this.emergencyStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elapsed Time";
            // 
            // elapsedTimeTextBox
            // 
            this.elapsedTimeTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.elapsedTimeTextBox.Enabled = false;
            this.elapsedTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeTextBox.Location = new System.Drawing.Point(17, 49);
            this.elapsedTimeTextBox.Name = "elapsedTimeTextBox";
            this.elapsedTimeTextBox.Size = new System.Drawing.Size(258, 35);
            this.elapsedTimeTextBox.TabIndex = 0;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugLabel.Location = new System.Drawing.Point(513, 548);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(51, 20);
            this.debugLabel.TabIndex = 1;
            this.debugLabel.Text = "label5";
            this.debugLabel.Visible = false;
            // 
            // testGraph
            // 
            this.testGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testGraph.Location = new System.Drawing.Point(0, 0);
            this.testGraph.Name = "testGraph";
            this.testGraph.ScrollGrace = 0D;
            this.testGraph.ScrollMaxX = 0D;
            this.testGraph.ScrollMaxY = 0D;
            this.testGraph.ScrollMaxY2 = 0D;
            this.testGraph.ScrollMinX = 0D;
            this.testGraph.ScrollMinY = 0D;
            this.testGraph.ScrollMinY2 = 0D;
            this.testGraph.Size = new System.Drawing.Size(836, 585);
            this.testGraph.TabIndex = 0;
            // 
            // graphUpdateTimer
            // 
            this.graphUpdateTimer.Tick += new System.EventHandler(this.graphUpdateTimer_Tick);
            // 
            // samplingTimer
            // 
            this.samplingTimer.Interval = 5;
            this.samplingTimer.Tick += new System.EventHandler(this.samplingTimer_Tick);
            // 
            // approachTimer
            // 
            this.approachTimer.Tick += new System.EventHandler(this.approachTimer_Tick);
            // 
            // labelUpdater
            // 
            this.labelUpdater.Interval = 20;
            this.labelUpdater.Tick += new System.EventHandler(this.labelUpdater_Tick);
            // 
            // testOverChecker
            // 
            this.testOverChecker.Interval = 10;
            this.testOverChecker.Tick += new System.EventHandler(this.testOverChecker_Tick);
            // 
            // mainTestTimer
            // 
            this.mainTestTimer.Interval = 1;
            this.mainTestTimer.Tick += new System.EventHandler(this.mainTestTimer_Tick);
            // 
            // test_runsTableAdapter_
            // 
            this.test_runsTableAdapter_.ClearBeforeFill = true;
            // 
            // test_run_samplesTableAdapter_
            // 
            this.test_run_samplesTableAdapter_.ClearBeforeFill = true;
            // 
            // pressDataSet_
            // 
            this.pressDataSet_.DataSetName = "pressDataSet";
            this.pressDataSet_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // general_settingsBindingSource
            // 
            this.general_settingsBindingSource.DataMember = "general_settings";
            this.general_settingsBindingSource.DataSource = this.pressDataSet_;
            // 
            // general_settingsTableAdapter
            // 
            this.general_settingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.calibration_coffTableAdapter = null;
            this.tableAdapterManager.calibration_pointsTableAdapter = null;
            this.tableAdapterManager.direction_channelsTableAdapter = null;
            this.tableAdapterManager.displacement_channelsTableAdapter = null;
            this.tableAdapterManager.force_channelsTableAdapter = null;
            this.tableAdapterManager.general_settingsTableAdapter = null;
            this.tableAdapterManager.kn_setTableAdapter = null;
            this.tableAdapterManager.limit_channelsTableAdapter = null;
            this.tableAdapterManager.motor_channelsTableAdapter = null;
            this.tableAdapterManager.pid_valuesTableAdapter = null;
            this.tableAdapterManager.reportsTableAdapter = null;
            this.tableAdapterManager.test_run_samplesTableAdapter = this.test_run_samplesTableAdapter_;
            this.tableAdapterManager.test_runsTableAdapter = this.test_runsTableAdapter_;
            this.tableAdapterManager.testsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = wsrPress.pressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cubePressOpenValveTimer
            // 
            this.cubePressOpenValveTimer.Interval = 3000;
            this.cubePressOpenValveTimer.Tick += new System.EventHandler(this.cubePressOpenValveTimer_Tick);
            this.cubePressTestOverOpenValveTimer.Interval = 10000;
            this.cubePressTestOverOpenValveTimer.Tick += new System.EventHandler(this.cubePressTestOverOpenValveTimer_Tick);
            // 
            // testRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 585);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "testRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.testRun_FormClosing);
            this.Load += new System.EventHandler(this.testRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.testRun_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samplesDataGrid_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.general_settingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer checkLimitSwitch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ZedGraph.ZedGraphControl testGraph;
        private System.Windows.Forms.Timer graphUpdateTimer;
        private System.Windows.Forms.TextBox elapsedTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emergencyStop;
        private System.Windows.Forms.Timer samplingTimer;
        private System.Windows.Forms.Timer approachTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox displacementTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loadTextBox;
        private System.Windows.Forms.Timer labelUpdater;
        private System.Windows.Forms.Timer testOverChecker;
        private System.Windows.Forms.Timer mainTestTimer;
        private pressDataSetTableAdapters.test_runsTableAdapter test_runsTableAdapter_;
        private pressDataSetTableAdapters.test_run_samplesTableAdapter test_run_samplesTableAdapter_;
        private pressDataSet pressDataSet_;
        private System.Windows.Forms.DataGridView samplesDataGrid_;
        private System.Windows.Forms.TextBox mmAtMaxForce;
        private System.Windows.Forms.TextBox maxForce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleNumber_;
        private System.Windows.Forms.DataGridViewTextBoxColumn displacement_;
        private System.Windows.Forms.DataGridViewTextBoxColumn load_;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_;
        private System.Windows.Forms.TextBox PacingErrorText;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.BindingSource general_settingsBindingSource;
        private pressDataSetTableAdapters.general_settingsTableAdapter general_settingsTableAdapter;
        private pressDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer cubePressOpenValveTimer;
        private System.Windows.Forms.Timer cubePressTestOverOpenValveTimer;
    }
}