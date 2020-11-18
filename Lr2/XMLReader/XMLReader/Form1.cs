﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLReader
{
    public partial class Form1 : Form
    {
        Doc a = new Doc();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "New scan")
            {
                button1.Text = "First scan";
                button2.Enabled = false;
                ScanValue.Enabled = false;
                Filter_.Enabled = false;
                method.Enabled = true;
                a.reset();
            } 
            else
            {
                switch (method.SelectedIndex)
                {
                    case 0:
                        a.Dom();
                        break;
                    case 1:
                        a.SaxTr();
                        break;
                    case 2:
                        a.Linq();
                        break;
                }
                richTextBox1.Text = a.DocToString();
                button1.Text = "New scan";
                button2.Enabled = true;
                ScanValue.Enabled = true;
                Filter_.Enabled = true;
                method.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            switch (Filter_.SelectedIndex)
            {
                case 0:
                    a.filter(ScanValue.Text, "Name");
                    break;
                case 1:
                    a.filter(ScanValue.Text, "Facultet");
                    break;
                case 2:
                    a.filter(ScanValue.Text, "Cafedra");
                    break;
                case 3:
                    a.filter(ScanValue.Text, "Degree");
                    break;
                case 4:
                    a.filter(ScanValue.Text, "Status");
                    break;
            }
            richTextBox1.Text = a.DocToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = a.TransformXMLToHTML();
            System.IO.File.WriteAllText(@"C:\Users\1\LR\Cource2OOP\Lr2\res.html", content);
        }
    }
}