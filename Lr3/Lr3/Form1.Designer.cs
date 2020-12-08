namespace Lr3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.upper1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataFileView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderBox1 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toFilesystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // upper1
            // 
            this.upper1.Location = new System.Drawing.Point(175, 3);
            this.upper1.Name = "upper1";
            this.upper1.Size = new System.Drawing.Size(40, 40);
            this.upper1.TabIndex = 1;
            this.upper1.Text = "up";
            this.upper1.UseVisualStyleBackColor = true;
            this.upper1.Click += new System.EventHandler(this.upper_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(212, 475);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // File
            // 
            this.File.HeaderText = "Folder";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataFileView1);
            this.panel1.Controls.Add(this.FolderBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.upper1);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 541);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "All files",
            "Text files(*.txt)",
            "Exe files(*.exe)",
            "Html file(*.html)"});
            this.comboBox1.Location = new System.Drawing.Point(221, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataFileView1
            // 
            this.dataFileView1.AllowUserToAddRows = false;
            this.dataFileView1.AllowUserToDeleteRows = false;
            this.dataFileView1.AllowUserToResizeColumns = false;
            this.dataFileView1.AllowUserToResizeRows = false;
            this.dataFileView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFileView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataFileView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataFileView1.ColumnHeadersHeight = 25;
            this.dataFileView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataFileView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFileView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataFileView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataFileView1.Location = new System.Drawing.Point(222, 54);
            this.dataFileView1.Name = "dataFileView1";
            this.dataFileView1.ReadOnly = true;
            this.dataFileView1.RowHeadersVisible = false;
            this.dataFileView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataFileView1.RowTemplate.Height = 28;
            this.dataFileView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFileView1.Size = new System.Drawing.Size(843, 489);
            this.dataFileView1.TabIndex = 4;
            this.dataFileView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataFileView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Files";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FolderBox1
            // 
            this.FolderBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderBox1.Location = new System.Drawing.Point(10, 8);
            this.FolderBox1.Name = "FolderBox1";
            this.FolderBox1.Size = new System.Drawing.Size(155, 26);
            this.FolderBox1.TabIndex = 3;
            this.FolderBox1.TextChanged += new System.EventHandler(this.FolderBox1_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.textToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scearchToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // scearchToolStripMenuItem
            // 
            this.scearchToolStripMenuItem.Image = global::Lr3.Properties.Resources.Zoom_16x;
            this.scearchToolStripMenuItem.Name = "scearchToolStripMenuItem";
            this.scearchToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.scearchToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.scearchToolStripMenuItem.Text = "Scearch";
            this.scearchToolStripMenuItem.Click += new System.EventHandler(this.scearchToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toFilesystemToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toFilesystemToolStripMenuItem
            // 
            this.toFilesystemToolStripMenuItem.Name = "toFilesystemToolStripMenuItem";
            this.toFilesystemToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.toFilesystemToolStripMenuItem.Text = "To Filesystem";
            this.toFilesystemToolStripMenuItem.Click += new System.EventHandler(this.toFilesystemToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAndReplaceToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.findAndReplaceToolStripMenuItem.Text = "Find and replace";
            this.findAndReplaceToolStripMenuItem.Visible = false;
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(804, 622);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 45);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "";
            this.textBox1.Text = "";
            this.textBox1.Visible = false;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1006, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 39);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1078, 694);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button upper1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.TextBox FolderBox1;
        private System.Windows.Forms.DataGridView dataFileView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toFilesystemToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
    }
}

