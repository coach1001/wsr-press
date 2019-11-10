namespace wsrPress
{
    partial class testSelect
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
            System.Windows.Forms.Label tests_idtestsLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label sampleNumberLabel;
            System.Windows.Forms.Label userRateLabel;
            System.Windows.Forms.Label userAreaLabel;
            this.dropPiston = new System.Windows.Forms.Button();
            this.liftPiston = new System.Windows.Forms.Button();
            this.pistonLabel = new System.Windows.Forms.Label();
            this.runTest = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kn_set_idkn_set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testStartForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endCondition0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCondition1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endValue0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xAxisUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yAxisUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource_ = new System.Windows.Forms.BindingSource(this.components);
            this.pressDataSet_ = new wsrPress.pressDataSet();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tests_idtestsComboBox = new System.Windows.Forms.ComboBox();
            this.test_runsBindingSource_ = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sampleNumberTextBox = new System.Windows.Forms.TextBox();
            this.userRateTextBox = new System.Windows.Forms.TextBox();
            this.userAreaTextBox = new System.Windows.Forms.TextBox();
            this.checkLimitSwitch = new System.Windows.Forms.Timer(this.components);
            this.testsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.testsTableAdapter();
            this.test_runsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_runsTableAdapter();
            this.tableAdapterManager_ = new wsrPress.pressDataSetTableAdapters.TableAdapterManager();
            this.calibration_coffTableAdapter_ = new wsrPress.pressDataSetTableAdapters.calibration_coffTableAdapter();
            this.pid_valuesTableAdapter_ = new wsrPress.pressDataSetTableAdapters.pid_valuesTableAdapter();
            this.manualPistonControl = new System.Windows.Forms.Timer(this.components);
            this.maxForceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dispAbs = new System.Windows.Forms.Label();
            tests_idtestsLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            sampleNumberLabel = new System.Windows.Forms.Label();
            userRateLabel = new System.Windows.Forms.Label();
            userAreaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_runsBindingSource_)).BeginInit();
            this.SuspendLayout();
            // 
            // tests_idtestsLabel
            // 
            tests_idtestsLabel.AutoSize = true;
            tests_idtestsLabel.Location = new System.Drawing.Point(368, 43);
            tests_idtestsLabel.Name = "tests_idtestsLabel";
            tests_idtestsLabel.Size = new System.Drawing.Size(31, 13);
            tests_idtestsLabel.TabIndex = 9;
            tests_idtestsLabel.Text = "Test:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(368, 71);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Date:";
            // 
            // sampleNumberLabel
            // 
            sampleNumberLabel.AutoSize = true;
            sampleNumberLabel.Location = new System.Drawing.Point(368, 96);
            sampleNumberLabel.Name = "sampleNumberLabel";
            sampleNumberLabel.Size = new System.Drawing.Size(85, 13);
            sampleNumberLabel.TabIndex = 13;
            sampleNumberLabel.Text = "Sample Number:";
            // 
            // userRateLabel
            // 
            userRateLabel.AutoSize = true;
            userRateLabel.Location = new System.Drawing.Point(368, 122);
            userRateLabel.Name = "userRateLabel";
            userRateLabel.Size = new System.Drawing.Size(88, 13);
            userRateLabel.TabIndex = 15;
            userRateLabel.Text = "User Rate Value:";
            // 
            // userAreaLabel
            // 
            userAreaLabel.AutoSize = true;
            userAreaLabel.Location = new System.Drawing.Point(368, 148);
            userAreaLabel.Name = "userAreaLabel";
            userAreaLabel.Size = new System.Drawing.Size(57, 13);
            userAreaLabel.TabIndex = 17;
            userAreaLabel.Text = "User Area:";
            userAreaLabel.Visible = false;
            // 
            // dropPiston
            // 
            this.dropPiston.Location = new System.Drawing.Point(12, 325);
            this.dropPiston.Name = "dropPiston";
            this.dropPiston.Size = new System.Drawing.Size(120, 56);
            this.dropPiston.TabIndex = 1;
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
            this.liftPiston.TabIndex = 2;
            this.liftPiston.Text = "<F6> Lift Piston";
            this.liftPiston.UseVisualStyleBackColor = true;
            this.liftPiston.Click += new System.EventHandler(this.liftPiston_Click);
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
            // runTest
            // 
            this.runTest.Location = new System.Drawing.Point(537, 325);
            this.runTest.Name = "runTest";
            this.runTest.Size = new System.Drawing.Size(120, 56);
            this.runTest.TabIndex = 4;
            this.runTest.Text = "<F4> Run Test";
            this.runTest.UseVisualStyleBackColor = true;
            this.runTest.Click += new System.EventHandler(this.runTest_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.kn_set_idkn_set,
            this.rateTypeDataGridViewTextBoxColumn,
            this.rateUnitDataGridViewTextBoxColumn,
            this.rateValueDataGridViewTextBoxColumn,
            this.sampleUnit,
            this.sampleRate,
            this.testStartForce,
            this.rateValue,
            this.rateUnit,
            this.rateType,
            this.editable,
            this.endCondition0,
            this.endCondition1,
            this.endValue0,
            this.endValue1,
            this.Column1,
            this.xAxisUnit,
            this.yAxisUnit,
            this.rushSpeed});
            this.dataGridView1.DataSource = this.testsBindingSource_;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(332, 254);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Test";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kn_set_idkn_set
            // 
            this.kn_set_idkn_set.DataPropertyName = "kn_set_idkn_set";
            this.kn_set_idkn_set.HeaderText = "kn_set_idkn_set";
            this.kn_set_idkn_set.Name = "kn_set_idkn_set";
            this.kn_set_idkn_set.ReadOnly = true;
            this.kn_set_idkn_set.Visible = false;
            // 
            // rateTypeDataGridViewTextBoxColumn
            // 
            this.rateTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rateTypeDataGridViewTextBoxColumn.DataPropertyName = "rateType";
            this.rateTypeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.rateTypeDataGridViewTextBoxColumn.HeaderText = "Rate Type";
            this.rateTypeDataGridViewTextBoxColumn.Name = "rateTypeDataGridViewTextBoxColumn";
            this.rateTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateUnitDataGridViewTextBoxColumn
            // 
            this.rateUnitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rateUnitDataGridViewTextBoxColumn.DataPropertyName = "rateUnit";
            this.rateUnitDataGridViewTextBoxColumn.FillWeight = 20F;
            this.rateUnitDataGridViewTextBoxColumn.HeaderText = "Rate Unit";
            this.rateUnitDataGridViewTextBoxColumn.Name = "rateUnitDataGridViewTextBoxColumn";
            this.rateUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateValueDataGridViewTextBoxColumn
            // 
            this.rateValueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rateValueDataGridViewTextBoxColumn.DataPropertyName = "rateValue";
            this.rateValueDataGridViewTextBoxColumn.FillWeight = 20F;
            this.rateValueDataGridViewTextBoxColumn.HeaderText = "Rate Value";
            this.rateValueDataGridViewTextBoxColumn.Name = "rateValueDataGridViewTextBoxColumn";
            this.rateValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sampleUnit
            // 
            this.sampleUnit.DataPropertyName = "sampleUnit";
            this.sampleUnit.HeaderText = "sampleUnit";
            this.sampleUnit.Name = "sampleUnit";
            this.sampleUnit.ReadOnly = true;
            this.sampleUnit.Visible = false;
            // 
            // sampleRate
            // 
            this.sampleRate.DataPropertyName = "sampleRate";
            this.sampleRate.HeaderText = "sampleRate";
            this.sampleRate.Name = "sampleRate";
            this.sampleRate.ReadOnly = true;
            this.sampleRate.Visible = false;
            // 
            // testStartForce
            // 
            this.testStartForce.DataPropertyName = "testStartForce";
            this.testStartForce.HeaderText = "testStartForce";
            this.testStartForce.Name = "testStartForce";
            this.testStartForce.ReadOnly = true;
            this.testStartForce.Visible = false;
            // 
            // rateValue
            // 
            this.rateValue.DataPropertyName = "rateValue";
            this.rateValue.HeaderText = "rateValue";
            this.rateValue.Name = "rateValue";
            this.rateValue.ReadOnly = true;
            this.rateValue.Visible = false;
            // 
            // rateUnit
            // 
            this.rateUnit.DataPropertyName = "rateUnit";
            this.rateUnit.HeaderText = "rateUnit";
            this.rateUnit.Name = "rateUnit";
            this.rateUnit.ReadOnly = true;
            this.rateUnit.Visible = false;
            // 
            // rateType
            // 
            this.rateType.DataPropertyName = "rateType";
            this.rateType.HeaderText = "rateType";
            this.rateType.Name = "rateType";
            this.rateType.ReadOnly = true;
            this.rateType.Visible = false;
            // 
            // editable
            // 
            this.editable.DataPropertyName = "editable";
            this.editable.HeaderText = "editable";
            this.editable.Name = "editable";
            this.editable.ReadOnly = true;
            this.editable.Visible = false;
            // 
            // endCondition0
            // 
            this.endCondition0.DataPropertyName = "endCondition0";
            this.endCondition0.HeaderText = "endCondition0";
            this.endCondition0.Name = "endCondition0";
            this.endCondition0.ReadOnly = true;
            this.endCondition0.Visible = false;
            // 
            // endCondition1
            // 
            this.endCondition1.DataPropertyName = "endCondition1";
            this.endCondition1.HeaderText = "endCondition1";
            this.endCondition1.Name = "endCondition1";
            this.endCondition1.ReadOnly = true;
            this.endCondition1.Visible = false;
            // 
            // endValue0
            // 
            this.endValue0.DataPropertyName = "endValue0";
            this.endValue0.HeaderText = "endValue0";
            this.endValue0.Name = "endValue0";
            this.endValue0.ReadOnly = true;
            this.endValue0.Visible = false;
            // 
            // endValue1
            // 
            this.endValue1.DataPropertyName = "endValue1";
            this.endValue1.HeaderText = "endValue1";
            this.endValue1.Name = "endValue1";
            this.endValue1.ReadOnly = true;
            this.endValue1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idtests";
            this.Column1.HeaderText = "testId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // xAxisUnit
            // 
            this.xAxisUnit.DataPropertyName = "xAxisUnit";
            this.xAxisUnit.HeaderText = "xAxisUnit";
            this.xAxisUnit.Name = "xAxisUnit";
            this.xAxisUnit.ReadOnly = true;
            this.xAxisUnit.Visible = false;
            // 
            // yAxisUnit
            // 
            this.yAxisUnit.DataPropertyName = "yAxisUnit";
            this.yAxisUnit.HeaderText = "yAxisUnit";
            this.yAxisUnit.Name = "yAxisUnit";
            this.yAxisUnit.ReadOnly = true;
            this.yAxisUnit.Visible = false;
            // 
            // rushSpeed
            // 
            this.rushSpeed.DataPropertyName = "rushSpeed";
            this.rushSpeed.HeaderText = "rushSpeed";
            this.rushSpeed.Name = "rushSpeed";
            this.rushSpeed.ReadOnly = true;
            this.rushSpeed.Visible = false;
            // 
            // testsBindingSource_
            // 
            this.testsBindingSource_.DataMember = "tests";
            this.testsBindingSource_.DataSource = this.pressDataSet_;
            // 
            // pressDataSet_
            // 
            this.pressDataSet_.DataSetName = "pressDataSet";
            this.pressDataSet_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(411, 325);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(120, 56);
            this.back.TabIndex = 3;
            this.back.Text = "<F3> Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Tests";
            // 
            // tests_idtestsComboBox
            // 
            this.tests_idtestsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_runsBindingSource_, "tests_idtests", true));
            this.tests_idtestsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.test_runsBindingSource_, "tests_idtests", true));
            this.tests_idtestsComboBox.DataSource = this.testsBindingSource_;
            this.tests_idtestsComboBox.DisplayMember = "name";
            this.tests_idtestsComboBox.Enabled = false;
            this.tests_idtestsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tests_idtestsComboBox.FormattingEnabled = true;
            this.tests_idtestsComboBox.Location = new System.Drawing.Point(457, 40);
            this.tests_idtestsComboBox.Name = "tests_idtestsComboBox";
            this.tests_idtestsComboBox.Size = new System.Drawing.Size(200, 21);
            this.tests_idtestsComboBox.TabIndex = 10;
            this.tests_idtestsComboBox.ValueMember = "idtests";
            // 
            // test_runsBindingSource_
            // 
            this.test_runsBindingSource_.DataMember = "test_runs";
            this.test_runsBindingSource_.DataSource = this.pressDataSet_;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd MMM yyyy  HH:mm:ss";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.test_runsBindingSource_, "date", true));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(457, 67);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 12;
            // 
            // sampleNumberTextBox
            // 
            this.sampleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_runsBindingSource_, "sampleNumber", true));
            this.sampleNumberTextBox.Location = new System.Drawing.Point(457, 93);
            this.sampleNumberTextBox.Name = "sampleNumberTextBox";
            this.sampleNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.sampleNumberTextBox.TabIndex = 14;
            // 
            // userRateTextBox
            // 
            this.userRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.testsBindingSource_, "editable", true));
            this.userRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.testsBindingSource_, "rateValue", true));
            this.userRateTextBox.Location = new System.Drawing.Point(457, 119);
            this.userRateTextBox.Name = "userRateTextBox";
            this.userRateTextBox.Size = new System.Drawing.Size(200, 20);
            this.userRateTextBox.TabIndex = 16;
            // 
            // userAreaTextBox
            // 
            this.userAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.testsBindingSource_, "editable", true));
            this.userAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.test_runsBindingSource_, "userArea", true));
            this.userAreaTextBox.Location = new System.Drawing.Point(457, 145);
            this.userAreaTextBox.Name = "userAreaTextBox";
            this.userAreaTextBox.Size = new System.Drawing.Size(200, 20);
            this.userAreaTextBox.TabIndex = 18;
            this.userAreaTextBox.Text = "0";
            this.userAreaTextBox.Visible = false;
            // 
            // checkLimitSwitch
            // 
            this.checkLimitSwitch.Tick += new System.EventHandler(this.checkLimitSwitch_Tick);
            // 
            // testsTableAdapter_
            // 
            this.testsTableAdapter_.ClearBeforeFill = true;
            // 
            // test_runsTableAdapter_
            // 
            this.test_runsTableAdapter_.ClearBeforeFill = true;
            // 
            // tableAdapterManager_
            // 
            this.tableAdapterManager_.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager_.calibration_coffTableAdapter = null;
            this.tableAdapterManager_.calibration_pointsTableAdapter = null;
            this.tableAdapterManager_.direction_channelsTableAdapter = null;
            this.tableAdapterManager_.displacement_channelsTableAdapter = null;
            this.tableAdapterManager_.force_channelsTableAdapter = null;
            this.tableAdapterManager_.general_settingsTableAdapter = null;
            this.tableAdapterManager_.kn_setTableAdapter = null;
            this.tableAdapterManager_.limit_channelsTableAdapter = null;
            this.tableAdapterManager_.motor_channelsTableAdapter = null;
            this.tableAdapterManager_.pid_valuesTableAdapter = null;
            this.tableAdapterManager_.reportsTableAdapter = null;
            this.tableAdapterManager_.test_run_samplesTableAdapter = null;
            this.tableAdapterManager_.test_runsTableAdapter = this.test_runsTableAdapter_;
            this.tableAdapterManager_.testsTableAdapter = this.testsTableAdapter_;
            this.tableAdapterManager_.UpdateOrder = wsrPress.pressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calibration_coffTableAdapter_
            // 
            this.calibration_coffTableAdapter_.ClearBeforeFill = true;
            // 
            // pid_valuesTableAdapter_
            // 
            this.pid_valuesTableAdapter_.ClearBeforeFill = true;
            // 
            // manualPistonControl
            // 
            this.manualPistonControl.Tick += new System.EventHandler(this.manualPistonControl_Tick);
            // 
            // maxForceTextBox
            // 
            this.maxForceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.testsBindingSource_, "editable", true));
            this.maxForceTextBox.Location = new System.Drawing.Point(457, 172);
            this.maxForceTextBox.Name = "maxForceTextBox";
            this.maxForceTextBox.Size = new System.Drawing.Size(200, 20);
            this.maxForceTextBox.TabIndex = 19;
            this.maxForceTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Maximum Force:";
            // 
            // dispAbs
            // 
            this.dispAbs.AutoSize = true;
            this.dispAbs.Location = new System.Drawing.Point(588, 306);
            this.dispAbs.Name = "dispAbs";
            this.dispAbs.Size = new System.Drawing.Size(69, 13);
            this.dispAbs.TabIndex = 23;
            this.dispAbs.Text = "displacement";
            this.dispAbs.Visible = false;
            // 
            // testSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 392);
            this.Controls.Add(this.dispAbs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxForceTextBox);
            this.Controls.Add(tests_idtestsLabel);
            this.Controls.Add(this.tests_idtestsComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(sampleNumberLabel);
            this.Controls.Add(this.sampleNumberTextBox);
            this.Controls.Add(userRateLabel);
            this.Controls.Add(this.userRateTextBox);
            this.Controls.Add(userAreaLabel);
            this.Controls.Add(this.userAreaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.runTest);
            this.Controls.Add(this.pistonLabel);
            this.Controls.Add(this.liftPiston);
            this.Controls.Add(this.dropPiston);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "testSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Select";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.testSelect_FormClosing);
            this.Load += new System.EventHandler(this.testSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.testSelect_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.testSelect_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_runsBindingSource_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dropPiston;
        private System.Windows.Forms.Button liftPiston;
        private System.Windows.Forms.Label pistonLabel;
        private System.Windows.Forms.Button runTest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testsBindingSource_;
        private pressDataSetTableAdapters.testsTableAdapter testsTableAdapter_;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource test_runsBindingSource_;
        private pressDataSetTableAdapters.test_runsTableAdapter test_runsTableAdapter_;
        private pressDataSetTableAdapters.TableAdapterManager tableAdapterManager_;
        private System.Windows.Forms.ComboBox tests_idtestsComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox sampleNumberTextBox;
        private System.Windows.Forms.TextBox userRateTextBox;
        private System.Windows.Forms.TextBox userAreaTextBox;
        private pressDataSet pressDataSet_;
        private System.Windows.Forms.Timer checkLimitSwitch;
        private pressDataSetTableAdapters.calibration_coffTableAdapter calibration_coffTableAdapter_;
        private pressDataSetTableAdapters.pid_valuesTableAdapter pid_valuesTableAdapter_;
        private System.Windows.Forms.Timer manualPistonControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kn_set_idkn_set;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn testStartForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editable;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCondition0;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCondition1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endValue0;
        private System.Windows.Forms.DataGridViewTextBoxColumn endValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAxisUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn yAxisUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushSpeed;
        private System.Windows.Forms.TextBox maxForceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dispAbs;
    }
}