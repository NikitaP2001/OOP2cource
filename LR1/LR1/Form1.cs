using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;


namespace LR1
{
    public partial class Form1 : Form
    {
        WorkSheet sheet;
        WorkBook workbook;
        char header = 'A';
        public Form1()
        {
            InitializeComponent(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            workbook = WorkBook.Create(ExcelFileFormat.XLSX);
            workbook.Metadata.Author = "User";
            sheet = workbook.CreateWorkSheet("new_sheet");
            UpdateTable();
        }
        private void FillGrid()
        {
            for (int i = 0; i < ExcelGrid.Columns.Count*4; i++)
            {
                ExcelGrid.Rows.Add();
            }
            
        }

        //Numerating created rows

        private void ExcelGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ExcelGrid.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        //Edit cell formula

        private void ExcelGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Formula == "")
            {
                ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Value.ToString();
            } else
            {
                ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Formula;
            }
        }

        //Return cell value in grid

        private void ExcelGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try //try to write grid value as Excel cell formula. If formula contains mistake we get exeption
            {   sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Formula = 
                    ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Value.ToString();
            }
            catch 
            {
                sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Formula = "";
                try
                {
                    sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Value =
                     ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                catch
                {
                    sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Value = "";
                }
            }
            finally
            {
                UpdateTable();
            }


        }

        private void UpdateTable()
        {
            for (int i = 0; i < ExcelGrid.Columns.Count; i++)
            {
                for (int j = 0; j < ExcelGrid.Rows.Count; j++)
                {
                    try
                    {
                    ExcelGrid.Rows[j].Cells[i].Value =
                    sheet[ExcelGrid.Columns[i].HeaderText + (j + 1).ToString()].Value.ToString();
                    }
                    catch
                    {
                        ExcelGrid.Rows[j].Cells[i].Value = "Error";
                    }

                }
            }
        }

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {          

            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|xls files (*.xls)|*.xls";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog1.FileName);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|xls files (*.xls)|*.xls";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                workbook = WorkBook.Load(openFileDialog1.FileName);
                sheet = workbook.WorkSheets.First();
                UpdateTable();
            }
        }
          //Creating new bottom rows and right cols
        private void ExcelGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex +1 == ExcelGrid.ColumnCount) //Cheack where user click
            {
                ExcelGrid.Columns.Add(((char)(header + 1)).ToString(), ((char)(header + 1)).ToString());
                header = (char)(header + 1);
            }
            if (e.RowIndex + 1 == ExcelGrid.RowCount)   //Cheack where user click
            {
                ExcelGrid.Rows.Add();
            }
        }
          //Ask user realy want to terminate process
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Configure the message box to be displayed
            string messageBoxText = "Do you want to save changes?";
            string caption = "MyExcel";
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning ;
            // Display message box
            DialogResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            EventArgs y = new EventArgs();
            // Process message box results
            switch (result) 
            {
                case DialogResult.Yes:
                    saveToolStripMenuItem_Click(sender, y);  //invoking save dialog method
                    break;
                case DialogResult.No:
                    //Form closing
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;  //Cancel closing
                    break;
            }

        }
    }
} 
