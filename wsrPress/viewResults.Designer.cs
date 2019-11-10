namespace wsrPress
{
    partial class viewResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewResults));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.testResultBindingNavigator_ = new System.Windows.Forms.BindingNavigator(this.components);
            this.testResultBindingSource_ = new System.Windows.Forms.BindingSource(this.components);
            this.pressDataSet_ = new wsrPress.pressDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testResultDataGridView = new System.Windows.Forms.DataGridView();
            this.testrunsBindingSource_ = new System.Windows.Forms.BindingSource(this.components);
            this.testGraphPicBox = new System.Windows.Forms.PictureBox();
            this.fromFilter = new System.Windows.Forms.DateTimePicker();
            this.sampleFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toFilter = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generateReport = new System.Windows.Forms.Button();
            this.back_ = new System.Windows.Forms.Button();
            this.tableAdapterManager_ = new wsrPress.pressDataSetTableAdapters.TableAdapterManager();
            this.test_runsTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_runsTableAdapter();
            this.testResultTableAdapter_ = new wsrPress.pressDataSetTableAdapters.testResultTableAdapter();
            this.testFilterCombo = new System.Windows.Forms.ComboBox();
            this.testComboSelectTableAdapter_ = new wsrPress.pressDataSetTableAdapters.testComboSelectTableAdapter();
            this.deleteResult = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timeSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forcekNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displacementMm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testrunsamplesBindingSource_ = new System.Windows.Forms.BindingSource(this.components);
            this.test_run_samplesTableAdapter_ = new wsrPress.pressDataSetTableAdapters.test_run_samplesTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.idtest_runs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingNavigator_)).BeginInit();
            this.testResultBindingNavigator_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testrunsBindingSource_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGraphPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testrunsamplesBindingSource_)).BeginInit();
            this.SuspendLayout();
            // 
            // testResultBindingNavigator_
            // 
            this.testResultBindingNavigator_.AddNewItem = null;
            this.testResultBindingNavigator_.BackColor = System.Drawing.SystemColors.ControlLight;
            this.testResultBindingNavigator_.BindingSource = this.testResultBindingSource_;
            this.testResultBindingNavigator_.CountItem = this.bindingNavigatorCountItem;
            this.testResultBindingNavigator_.DeleteItem = null;
            this.testResultBindingNavigator_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.testResultBindingNavigator_.Location = new System.Drawing.Point(0, 0);
            this.testResultBindingNavigator_.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testResultBindingNavigator_.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testResultBindingNavigator_.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testResultBindingNavigator_.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testResultBindingNavigator_.Name = "testResultBindingNavigator_";
            this.testResultBindingNavigator_.PositionItem = this.bindingNavigatorPositionItem;
            this.testResultBindingNavigator_.Size = new System.Drawing.Size(1352, 25);
            this.testResultBindingNavigator_.TabIndex = 0;
            this.testResultBindingNavigator_.Text = "bindingNavigator1";
            this.testResultBindingNavigator_.Visible = false;
            // 
            // testResultBindingSource_
            // 
            this.testResultBindingSource_.DataMember = "testResult";
            this.testResultBindingSource_.DataSource = this.pressDataSet_;
            this.testResultBindingSource_.Sort = "";
            // 
            // pressDataSet_
            // 
            this.pressDataSet_.DataSetName = "pressDataSet";
            this.pressDataSet_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // testResultDataGridView
            // 
            this.testResultDataGridView.AllowUserToAddRows = false;
            this.testResultDataGridView.AllowUserToDeleteRows = false;
            this.testResultDataGridView.AutoGenerateColumns = false;
            this.testResultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.testResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtest_runs,
            this.testResultmm,
            this.testResult,
            this.sampleNumber,
            this.name,
            this.date});
            this.testResultDataGridView.DataSource = this.testResultBindingSource_;
            this.testResultDataGridView.Location = new System.Drawing.Point(12, 86);
            this.testResultDataGridView.MultiSelect = false;
            this.testResultDataGridView.Name = "testResultDataGridView";
            this.testResultDataGridView.ReadOnly = true;
            this.testResultDataGridView.RowHeadersVisible = false;
            this.testResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testResultDataGridView.Size = new System.Drawing.Size(369, 510);
            this.testResultDataGridView.StandardTab = true;
            this.testResultDataGridView.TabIndex = 5;
            this.testResultDataGridView.SelectionChanged += new System.EventHandler(this.testResultDataGridView_SelectionChanged);
            // 
            // testrunsBindingSource_
            // 
            this.testrunsBindingSource_.DataMember = "test_runs";
            this.testrunsBindingSource_.DataSource = this.pressDataSet_;
            // 
            // testGraphPicBox
            // 
            this.testGraphPicBox.Location = new System.Drawing.Point(387, 86);
            this.testGraphPicBox.Name = "testGraphPicBox";
            this.testGraphPicBox.Size = new System.Drawing.Size(412, 510);
            this.testGraphPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testGraphPicBox.TabIndex = 2;
            this.testGraphPicBox.TabStop = false;
            // 
            // fromFilter
            // 
            this.fromFilter.Location = new System.Drawing.Point(49, 35);
            this.fromFilter.Name = "fromFilter";
            this.fromFilter.Size = new System.Drawing.Size(113, 20);
            this.fromFilter.TabIndex = 1;
            this.fromFilter.ValueChanged += new System.EventHandler(this.fromFilter_ValueChanged);
            // 
            // sampleFilter
            // 
            this.sampleFilter.Location = new System.Drawing.Point(232, 35);
            this.sampleFilter.Name = "sampleFilter";
            this.sampleFilter.Size = new System.Drawing.Size(149, 20);
            this.sampleFilter.TabIndex = 3;
            this.sampleFilter.TextChanged += new System.EventHandler(this.sampleFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "From:";
            // 
            // toFilter
            // 
            this.toFilter.Location = new System.Drawing.Point(49, 59);
            this.toFilter.Name = "toFilter";
            this.toFilter.Size = new System.Drawing.Size(113, 20);
            this.toFilter.TabIndex = 2;
            this.toFilter.ValueChanged += new System.EventHandler(this.toFilter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sample #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Test:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ran Tests - Filter";
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(670, 9);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(129, 45);
            this.generateReport.TabIndex = 14;
            this.generateReport.Text = "<F2> Print Report";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // back_
            // 
            this.back_.Location = new System.Drawing.Point(805, 10);
            this.back_.Name = "back_";
            this.back_.Size = new System.Drawing.Size(129, 45);
            this.back_.TabIndex = 15;
            this.back_.Text = "<F3> Back";
            this.back_.UseVisualStyleBackColor = true;
            this.back_.Click += new System.EventHandler(this.back__Click);
            // 
            // tableAdapterManager_
            // 
            this.tableAdapterManager_.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager_.calibration_coffTableAdapter = null;
            this.tableAdapterManager_.calibration_pointsTableAdapter = null;
            this.tableAdapterManager_.Connection = null;
            this.tableAdapterManager_.direction_channelsTableAdapter = null;
            this.tableAdapterManager_.displacement_channelsTableAdapter = null;
            this.tableAdapterManager_.force_channelsTableAdapter = null;
            
            this.tableAdapterManager_.kn_setTableAdapter = null;
            this.tableAdapterManager_.limit_channelsTableAdapter = null;
            this.tableAdapterManager_.motor_channelsTableAdapter = null;
            this.tableAdapterManager_.pid_valuesTableAdapter = null;
            this.tableAdapterManager_.reportsTableAdapter = null;
            this.tableAdapterManager_.test_run_samplesTableAdapter = null;
            this.tableAdapterManager_.test_runsTableAdapter = null;
            this.tableAdapterManager_.testsTableAdapter = null;
            this.tableAdapterManager_.UpdateOrder = wsrPress.pressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // test_runsTableAdapter_
            // 
            this.test_runsTableAdapter_.ClearBeforeFill = true;
            // 
            // testResultTableAdapter_
            // 
            this.testResultTableAdapter_.ClearBeforeFill = true;
            // 
            // testFilterCombo
            // 
            this.testFilterCombo.DataSource = this.pressDataSet_;
            this.testFilterCombo.DisplayMember = "testComboSelect.Name";
            this.testFilterCombo.FormattingEnabled = true;
            this.testFilterCombo.Location = new System.Drawing.Point(232, 59);
            this.testFilterCombo.Name = "testFilterCombo";
            this.testFilterCombo.Size = new System.Drawing.Size(149, 21);
            this.testFilterCombo.TabIndex = 16;
            this.testFilterCombo.ValueMember = "testComboSelect.Name";
            this.testFilterCombo.SelectedIndexChanged += new System.EventHandler(this.testFilterCombo_SelectedIndexChanged);
            // 
            // testComboSelectTableAdapter_
            // 
            this.testComboSelectTableAdapter_.ClearBeforeFill = true;
            // 
            // deleteResult
            // 
            this.deleteResult.ForeColor = System.Drawing.Color.Red;
            this.deleteResult.Location = new System.Drawing.Point(233, 4);
            this.deleteResult.Name = "deleteResult";
            this.deleteResult.Size = new System.Drawing.Size(148, 23);
            this.deleteResult.TabIndex = 17;
            this.deleteResult.Text = "<F5> Delete Result ";
            this.deleteResult.UseVisualStyleBackColor = true;
            this.deleteResult.Click += new System.EventHandler(this.deleteResult_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeSecondsDataGridViewTextBoxColumn,
            this.forcekNDataGridViewTextBoxColumn,
            this.displacementMm});
            this.dataGridView1.DataSource = this.testrunsamplesBindingSource_;
            this.dataGridView1.Location = new System.Drawing.Point(805, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(158, 510);
            this.dataGridView1.TabIndex = 18;
            // 
            // timeSecondsDataGridViewTextBoxColumn
            // 
            this.timeSecondsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeSecondsDataGridViewTextBoxColumn.DataPropertyName = "timeSeconds";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.timeSecondsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.timeSecondsDataGridViewTextBoxColumn.FillWeight = 30F;
            this.timeSecondsDataGridViewTextBoxColumn.HeaderText = "Time (s)";
            this.timeSecondsDataGridViewTextBoxColumn.Name = "timeSecondsDataGridViewTextBoxColumn";
            this.timeSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // forcekNDataGridViewTextBoxColumn
            // 
            this.forcekNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.forcekNDataGridViewTextBoxColumn.DataPropertyName = "forcekN";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.forcekNDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.forcekNDataGridViewTextBoxColumn.FillWeight = 30F;
            this.forcekNDataGridViewTextBoxColumn.HeaderText = "Force (kN)";
            this.forcekNDataGridViewTextBoxColumn.Name = "forcekNDataGridViewTextBoxColumn";
            this.forcekNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displacementMm
            // 
            this.displacementMm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displacementMm.DataPropertyName = "displacementMm";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.displacementMm.DefaultCellStyle = dataGridViewCellStyle5;
            this.displacementMm.FillWeight = 40F;
            this.displacementMm.HeaderText = "Displacement (mm)";
            this.displacementMm.Name = "displacementMm";
            this.displacementMm.ReadOnly = true;
            // 
            // testrunsamplesBindingSource_
            // 
            this.testrunsamplesBindingSource_.DataMember = "test_run_samples";
            this.testrunsamplesBindingSource_.DataSource = this.pressDataSet_;
            // 
            // test_run_samplesTableAdapter_
            // 
            this.test_run_samplesTableAdapter_.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // idtest_runs
            // 
            this.idtest_runs.DataPropertyName = "idtest_runs";
            this.idtest_runs.HeaderText = "idtest_runs";
            this.idtest_runs.Name = "idtest_runs";
            this.idtest_runs.ReadOnly = true;
            this.idtest_runs.Visible = false;
            // 
            // testResultmm
            // 
            this.testResultmm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testResultmm.DataPropertyName = "testResultmm";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.testResultmm.DefaultCellStyle = dataGridViewCellStyle1;
            this.testResultmm.FillWeight = 20F;
            this.testResultmm.HeaderText = "Displacement At Max Force (mm)";
            this.testResultmm.Name = "testResultmm";
            this.testResultmm.ReadOnly = true;
            // 
            // testResult
            // 
            this.testResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.testResult.DataPropertyName = "testResult";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.testResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.testResult.FillWeight = 15F;
            this.testResult.HeaderText = "Max Force (kN)";
            this.testResult.Name = "testResult";
            this.testResult.ReadOnly = true;
            // 
            // sampleNumber
            // 
            this.sampleNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sampleNumber.DataPropertyName = "sampleNumber";
            this.sampleNumber.FillWeight = 18F;
            this.sampleNumber.HeaderText = "Sample #";
            this.sampleNumber.Name = "sampleNumber";
            this.sampleNumber.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 17F;
            this.name.HeaderText = "Test";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.FillWeight = 20F;
            this.date.HeaderText = "Date &Time";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // viewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteResult);
            this.Controls.Add(this.testFilterCombo);
            this.Controls.Add(this.back_);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sampleFilter);
            this.Controls.Add(this.fromFilter);
            this.Controls.Add(this.testGraphPicBox);
            this.Controls.Add(this.testResultDataGridView);
            this.Controls.Add(this.testResultBindingNavigator_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "viewResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Results";
            this.Load += new System.EventHandler(this.viewResults_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewResults_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingNavigator_)).EndInit();
            this.testResultBindingNavigator_.ResumeLayout(false);
            this.testResultBindingNavigator_.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testrunsBindingSource_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGraphPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testrunsamplesBindingSource_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource testResultBindingSource_;
        private pressDataSetTableAdapters.testResultTableAdapter testResultTableAdapter_;
        private pressDataSetTableAdapters.TableAdapterManager tableAdapterManager_;
        private System.Windows.Forms.BindingNavigator testResultBindingNavigator_;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView testResultDataGridView;
        private System.Windows.Forms.PictureBox testGraphPicBox;
        private pressDataSetTableAdapters.test_runsTableAdapter test_runsTableAdapter_;
        private pressDataSet pressDataSet_;
        private System.Windows.Forms.DataGridViewTextBoxColumn displacmenetMmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker fromFilter;
        private System.Windows.Forms.TextBox sampleFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.Button back_;
        private System.Windows.Forms.ComboBox testFilterCombo;
        private pressDataSetTableAdapters.testComboSelectTableAdapter testComboSelectTableAdapter_;
        private System.Windows.Forms.Button deleteResult;
        private System.Windows.Forms.BindingSource testrunsBindingSource_;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource testrunsamplesBindingSource_;
        private pressDataSetTableAdapters.test_run_samplesTableAdapter test_run_samplesTableAdapter_;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forcekNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displacementMm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtest_runs;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResultmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn testResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}