using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace wsrPress
{
    public partial class viewResults : Form
    {
        Image testRunGraph;
        imageConversion imgCon = new imageConversion();
        Bitmap bitmap;
                   

        public viewResults()
        {
            InitializeComponent();
            toFilter.Value = DateTime.Now.AddMonths(1);
            fromFilter.Value = DateTime.Now.AddMonths(-1);
        }

        private void viewResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pressDataSet.test_run_samples' table. You can move, or remove it, as needed.
            this.test_run_samplesTableAdapter_.Fill(this.pressDataSet_.test_run_samples);
            this.testResultTableAdapter_.Fill(this.pressDataSet_.testResult);
            this.testComboSelectTableAdapter_.Fill(this.pressDataSet_.testComboSelect);
            
        }

        private void testResultDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try {
                Int32 idTestRun = Convert.ToInt32(testResultDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                string base64Image = test_runsTableAdapter_.getTestRunGraph(idTestRun);
                byte[] bytesImage = Convert.FromBase64String(base64Image);
                testRunGraph = imgCon.byteArrayToImage(bytesImage);
                testGraphPicBox.Image = testRunGraph;

                this.test_run_samplesTableAdapter_.FillByIdTestRun(this.pressDataSet_.test_run_samples,idTestRun);
            }
            catch { }
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            generateReportForm();
        
        }

        private void generateReportForm()
        {
            int i = 0;
            try
            {
                StreamWriter sw = new StreamWriter("print.txt");
                String sw_="";
                sw_+="Sample Number: " + testResultDataGridView.SelectedRows[0].Cells[3].Value.ToString() + Environment.NewLine;
                sw_+="Test :" + testResultDataGridView.SelectedRows[0].Cells[4].Value.ToString() + Environment.NewLine;
                sw_+="Date Time :" + testResultDataGridView.SelectedRows[0].Cells[5].Value.ToString() + Environment.NewLine;
                sw_ += Environment.NewLine;
                sw_+= "Max Force (kN) :" + Convert.ToDouble(testResultDataGridView.SelectedRows[0].Cells[2].Value).ToString("###0.000") + Environment.NewLine;
                sw_+="Displacement (mm) at Max Force :" + Convert.ToDouble(testResultDataGridView.SelectedRows[0].Cells[1].Value).ToString("###0.00") + Environment.NewLine;  
                sw_+=Environment.NewLine;

                
                sw_+="Displacement (mm)   Force (kN)   Time (seconds)" + Environment.NewLine;
            
                for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    sw_+=Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value).ToString("###0.000") + "   "+                    
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value).ToString("###0.000") + "   "+
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value).ToString("###0.000") + Environment.NewLine;                        
                    
                }
                sw.Write(sw_);

                sw.Flush();
                sw.Close();
                
                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                //generateReportForm();
                ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;

                //dataGridView1
                printPreviewDialog1.ShowDialog();

            }
            catch (Exception ex)
            {

            }
        }
        private void viewResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                generateReportForm();
            }
            else if (e.KeyCode.ToString() == "F3")
            {
                this.Close();
            }
            else if (e.KeyCode.ToString() == "F5")
            {
                deleteResult_(Convert.ToUInt32(testResultDataGridView.SelectedRows[0].Cells[0].Value));
            }
        }
        private void back__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void filterDataGrid()
        {
            string test="";
            string serial;
            testResultBindingSource_.RemoveFilter();
            
            if (testFilterCombo.Text == "ALL TEST") test = ""; else test = testFilterCombo.Text;
            if (sampleFilter.Text.Length == 0) serial = ""; else serial = sampleFilter.Text;

            if (toFilter.Value < fromFilter.Value) toFilter.Value = fromFilter.Value;
            
            string start = Convert.ToDateTime(fromFilter.Value).ToString("yyyy-MM-dd");
            string end = Convert.ToDateTime(toFilter.Value).AddDays(1).ToString("yyyy-MM-dd");

            var Filter = string.Format(
                "([{0}] >= '{1}' AND [{0}] <= '{2}' AND [{3}] like '%{4}%' AND [{5}] like '%{6}%')",
                "date", start, end, "name", test, "sampleNumber", serial);
            Console.WriteLine(Filter);
           

            testResultBindingSource_.Filter = Filter;
            testResultDataGridView.Refresh();

        }
        private void sampleFilter_TextChanged(object sender, EventArgs e)
        {
            filterDataGrid();
        }
        private void testFilter_TextChanged(object sender, EventArgs e)
        {
            filterDataGrid();
        }
        private void fromFilter_ValueChanged(object sender, EventArgs e)
        {
           filterDataGrid();
        }
        private void toFilter_ValueChanged(object sender, EventArgs e)
        {
            filterDataGrid();
        }
        private void testFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(testFilterCombo.Text);
            filterDataGrid();
        }
        private void deleteResult_Click(object sender, EventArgs e)
        {
            try
            {
                deleteResult_(Convert.ToUInt32(testResultDataGridView.SelectedRows[0].Cells[0].Value));
            }
            catch { }
            
        }

        private void deleteResult_(UInt32 id)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete Test Run", MessageBoxButtons.YesNo);
            if (res.ToString() == "Yes")
            {
                try
                {
                    test_runsTableAdapter_.DeleteWithId(id);
                    test_run_samplesTableAdapter_.DeleteSamplesById(id);
                    testResultTableAdapter_.Fill(pressDataSet_.testResult);
                }
                catch
                {

                }
               
            }
            else
            {

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StreamReader sr = new StreamReader("print.txt");
            Font vFont = new Font("Verdana", 10);
            //e.Graphics.DrawImage(bitmap, 0, 0);
            Graphics g = e.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            linesPerPage = e.MarginBounds.Height / vFont.GetHeight(g) ;
            while(count < linesPerPage && ((line = sr.ReadLine())!=null )){
                yPos = topMargin+(count*vFont.GetHeight(g));
                g.DrawString(line,vFont,Brushes.Black,leftMargin,yPos, new StringFormat());
                count++;
            }

            if(line != null){
                e.HasMorePages = true;
            }
            else{
                e.HasMorePages = false;
            }

            sr.Close();
            
        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
