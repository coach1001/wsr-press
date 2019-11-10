namespace wsrPress
{
    partial class SetCommPort
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pressDataSet1 = new wsrPress.pressDataSet();
            this.general_settingsTableAdapter1 = new wsrPress.pressDataSetTableAdapters.general_settingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Comm Port and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pressDataSet1
            // 
            this.pressDataSet1.DataSetName = "pressDataSet";
            this.pressDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // general_settingsTableAdapter1
            // 
            this.general_settingsTableAdapter1.ClearBeforeFill = true;
            // 
            // SetCommPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 77);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "SetCommPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cant Open Communications";
            ((System.ComponentModel.ISupportInitialize)(this.pressDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private pressDataSet pressDataSet1;
        private pressDataSetTableAdapters.general_settingsTableAdapter general_settingsTableAdapter1;
    }
}