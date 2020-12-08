using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lr3
{
    public partial class Form1 : Form
    {
        FileSystemExplorer FileSys = new FileSystemExplorer();
        Prompt NameDialog = new Prompt();
        void StartupGritOptions()
        {
            DisplayDirs();
            FolderBox1.Text = FileSys.CurrentFolder;
            dataFileView1.ClearSelection();
        }
        public Form1()
        {
            InitializeComponent();
            FormDesign();
            StartupGritOptions();
        }
        #region Desiign
        void FormDesign()
        {
            //panel
            panel1.Width = ClientRectangle.Width - 10;
            panel1.Height = 4 * ClientRectangle.Height / 5;
            panel1.Location = new Point(5, 5 + menuStrip1.Height);
            //panel1 grid and button
            dataGridView1.Width = panel1.Width / 3;
            dataGridView1.Height = panel1.Height - upper1.Height - 10;
            upper1.Location = new Point(5 + dataGridView1.Width - upper1.Width, 5);
            dataGridView1.Location = new Point(5, upper1.Height + 5);
            FolderBox1.Location = new Point(5, 5);
            FolderBox1.Height = upper1.Height;
            FolderBox1.Width = dataGridView1.Width - upper1.Width;
            dataFileView1.Width = panel1.Width - dataGridView1.Width - 15;
            dataFileView1.Height = dataGridView1.Height;
            dataFileView1.Location = new Point(10 + dataGridView1.Width, upper1.Height + 5);
            comboBox1.Location = new Point(10 + dataGridView1.Width, 5);
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            FormDesign();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            FormDesign();
        }
        #endregion

        #region File view Grids
        private void DisplayDirs()
        {
            try
            {
                dataGridView1.Rows.Clear();
                fileSystemWatcher1.Path = FileSys.CurrentFolder;
                DisplayFiles();
                foreach (var s in FileSys.subdir)
                {
                    dataGridView1.Rows.Add(s);
                }

                dataGridView1.ClearSelection();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            FileSys.Refresh();
            DisplayDirs();
        }
        private void upper_Click(object sender, EventArgs e)
        {
            FileSys.GetUpperPath();
            DisplayDirs();
            FolderBox1.Text = FileSys.CurrentFolder;
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FileSys.CurrentFolder = dataGridView1.SelectedCells[0].Value.ToString();
            FolderBox1.Text = FileSys.CurrentFolder;
            DisplayDirs();
        }
        private void FolderBox1_TextChanged(object sender, EventArgs e)
        {
            FileSys.CurrentFolder = FolderBox1.Text;
            DisplayDirs();
        }
        bool fileFlag = true;
        private void DisplayFiles()
        {
            if (fileFlag)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case (0):
                        FileSys.GetFiles("*");
                        break;
                    case (1):
                        FileSys.GetFiles("*.txt");
                        break;
                    case (2):
                        FileSys.GetFiles("*.exe");
                        break;
                    case (3):
                        FileSys.GetFiles("*.html");
                        break;
                    default:
                        FileSys.GetFiles("*"); break;
                }
            }
            else fileFlag = true;
            dataFileView1.Rows.Clear();
            try
            {
                foreach (var s in FileSys.filesName)
                {
                    dataFileView1.Rows.Add(s);
                }
            }
            catch { }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFiles();
        }
        #endregion

        #region DataGrid Strip menu
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add("Paste");
                m.Items.Add("Create");
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    dataGridView1.Rows[currentMouseOverRow].Selected = true;
                    m.Items.Add("Copy");
                    m.Items.Add("Delete");
                }
                else dataGridView1.ClearSelection();

                m.Show(dataGridView1, new Point(e.X, e.Y));
                m.ItemClicked += m_ItemClicked;
            }
            if (e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow < 0)
                {
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.ToString())
                {
                    case ("Copy"):
                        for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                        {
                            FileSys.Operation.folderBufer[i] = dataGridView1.SelectedCells[i].Value.ToString();
                        }
                        break;
                    case ("Paste"):
                        FileSys.Operation.Copy(FileSys.CurrentFolder);
                        break;
                    case ("Create"):
                        FileSys.Operation.CreateFolder(NameDialog.ShowDialog("Name:", "Give a name to new folder!"),
                            FileSys.CurrentFolder);
                        break;
                    case ("Delete"):
                        for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                        {
                            FileSys.Operation.folderBufer[i] = dataGridView1.SelectedCells[i].Value.ToString();
                        }
                        FileSys.Operation.Delete(FileSys.CurrentFolder);
                        break;
                }
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }
        private void dataFileView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m1 = new ContextMenuStrip();
                m1.Items.Add("Paste");
                m1.Items.Add("Create");
                int currentMouseOverRow = dataFileView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    dataFileView1.Rows[currentMouseOverRow].Selected = true;
                    m1.Items.Add("Copy");
                    m1.Items.Add("Delete");
                    m1.Items.Add("Rename");
                    m1.Items.Add("Open");
                }
                else dataFileView1.ClearSelection();

                m1.Show(dataFileView1, new Point(e.X, e.Y));
                m1.ItemClicked += m1_ItemClicked;
            }
            if (e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = dataFileView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow < 0)
                {
                    dataFileView1.ClearSelection();
                }
            }
        }
        private void m1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.ToString())
                {
                    case ("Copy"):
                        for (int i = 0; i < dataFileView1.SelectedCells.Count; i++)
                        {
                            FileSys.Operation.fileBufer[i] = FileSys.files[dataFileView1.SelectedCells[i].RowIndex];
                        }
                        break;
                    case ("Paste"):
                        FileSys.Operation.Copy(FileSys.CurrentFolder);
                        break;
                    case ("Rename"):
                        if (dataFileView1.SelectedCells.Count > 1)
                            MessageBox.Show("Select one file to rename!");
                        else
                        {
                            FileSys.Operation.Rename(FileSys.files[dataFileView1.SelectedCells[0].RowIndex],
                            NameDialog.ShowDialog("Name:", "Give  name to a file!"));
                        }
                        break;
                    case ("Open"):
                        if (dataFileView1.SelectedCells.Count > 1)
                            MessageBox.Show("Select one file to open!");
                        else
                        {
                            OpenFile();
                        }
                        break;
                    case ("Create"):
                        FileSys.Operation.CreateFile(NameDialog.ShowDialog("Name:", "Give a name to new folder!"),
                            FileSys.CurrentFolder);
                        break;
                    case ("Delete"):
                        for (int i = 0; i < dataFileView1.SelectedCells.Count; i++)
                        {
                            FileSys.Operation.fileBufer[i] = dataFileView1.SelectedCells[i].Value.ToString();
                        }
                        FileSys.Operation.Delete(FileSys.CurrentFolder);
                        break;
                }
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }
        #endregion

        private void scearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFiles();
            NameDialog.ShowFilePicker(FileSys);
            fileFlag = false;
            DisplayFiles();
        }
        private void OpenFile()
        {
            textBox1.Visible = true;
            textBox1.Location = new Point(5, 30);
            textBox1.Width = ClientRectangle.Width - 5;
            textBox1.Height = ClientRectangle.Height - 5;
            textBox1.Text = FileSys.Operation.Read(FileSys.files[dataFileView1.SelectedCells[0].RowIndex]);
            textBox1.Tag = FileSys.files[dataFileView1.SelectedCells[0].RowIndex];
            findAndReplaceToolStripMenuItem.Visible = true;
            Save.Visible = true;
        }

        private void toFilesystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            Save.Visible = false;
            findAndReplaceToolStripMenuItem.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileSys.Operation.Save(textBox1.Tag.ToString(), textBox1.Text);
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = NameDialog.ShowTextReplacer(textBox1.Text, FileSys);
        }
    }

    public class Prompt
    {
        public string ShowFilePicker(FileSystemExplorer FileSys)
        {
            string text = "File name:";
            string caption = "Choose fille scearch options";

            Form prompt = new Form()
            {
                Width = 500,
                Height = 500,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                MinimizeBox = false,
                MaximizeBox = false,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            DateTimePicker timePicker = new DateTimePicker() { Left = 50, Top = 150 };
            Label textLabe2 = new Label() { Left = 50, Top = 125, Text = "File last changed:" };
            NumericUpDown textBox2 = new NumericUpDown() { Left = 50, Top = 225, Width = 200 };
            Label textLabe3 = new Label() { Left = 50, Top = 200, Text = "File size, B:" };
            Button confirmation = new Button()
            {
                Text = "Find!",
                Height = 50,
                Left = 175,
                Width = 150,
                Top = 400,
                DialogResult = DialogResult.OK
            };
            ComboBox ListBox1 = new ComboBox()
            {
                Width = 150,
                Left = 300,
                Top = 50,
                BackColor = prompt.BackColor,
                DropDownStyle = ComboBoxStyle.DropDownList,
                ImeMode = ImeMode.Off
            ,
                Font = new Font("Bradley Hand ITC", 8)
            };
            confirmation.Click += (sender, e) =>
            {
                if (ListBox1.SelectedIndex != -1)
                {
                    switch (ListBox1.SelectedIndex)
                    {
                        case (0):
                            FileSys.GetFiles(textBox.Text);
                            break;
                        case (2):
                            string theDate = timePicker.Value.ToShortDateString();
                            string dateInput = theDate;
                            var parsedDate = DateTime.Parse(dateInput);
                            FileSys.GetFiles(parsedDate);
                            break;
                        case (1):
                            FileSys.GetFiles(textBox2.Value);
                            break;
                        default:
                            FileSys.GetFiles("*"); break;
                    }
                }
                prompt.Close();
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textLabe2);
            prompt.Controls.Add(textLabe3);
            prompt.Controls.Add(ListBox1);
            prompt.Controls.Add(timePicker);
            textBox2.Maximum = 999999999;
            ListBox1.Items.Add("Search by name");
            ListBox1.Items.Add("Search by size");
            ListBox1.Items.Add("Search by date");
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";

        }
        public string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        public string ShowTextReplacer(string text, FileSystemExplorer FileSys)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Find and replace text",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Search text:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Label textLabe2 = new Label() { Left = 50, Top = 95, Text = "And replace with" };
            TextBox textBox2 = new TextBox() { Left = 50, Top = 125, Width = 300 };
            Button confirmation = new Button() { Text = "Replace", Left = 300, Width = 100, Top = 175, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => {
                prompt.Close();
                textBox.Text = FileSys.Operation.Replace(text, textBox.Text, textBox2.Text);
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textLabe2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}


