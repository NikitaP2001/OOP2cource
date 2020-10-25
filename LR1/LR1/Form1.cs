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
        public Form1()
        {
            InitializeComponent();
            FillGrid();     
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            workbook = WorkBook.Load("test.xlsx");
            sheet = workbook.WorkSheets.First();
            UpdateTable();
        }
        private void FillGrid()
        {
            for (int i = 0; i < ExcelGrid.Columns.Count*5; i++)
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
            WorkBook workbook = WorkBook.Load("test.xlsx");
            WorkSheet sheet = workbook.WorkSheets.First();
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
            try
            {
                sheet[ExcelGrid.Columns[e.ColumnIndex].HeaderText + (e.RowIndex + 1).ToString()].Formula =
                    ExcelGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
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
                workbook.SaveAs("test.xlsx");
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            for (int i = 0; i < ExcelGrid.Columns.Count; i++)
            {
                for (int j = 0; j < ExcelGrid.Rows.Count; j++)
                {
                    ExcelGrid.Rows[j].Cells[i].Value =
                    sheet[ExcelGrid.Columns[i].HeaderText + (j + 1).ToString()].Value.ToString();
                }
            }
        }
    }
} 
