namespace XMLReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NewScan = new System.Windows.Forms.Button();
            this.Filter_ = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToHtml = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScanValue = new System.Windows.Forms.TextBox();
            this.NextScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\1\\LR\\Cource2OOP\\Lr2\\source.xml", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 450);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // NewScan
            // 
            this.NewScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewScan.Location = new System.Drawing.Point(49, 21);
            this.NewScan.Name = "NewScan";
            this.NewScan.Size = new System.Drawing.Size(130, 42);
            this.NewScan.TabIndex = 2;
            this.NewScan.Text = "New scan";
            this.NewScan.UseVisualStyleBackColor = true;
            this.NewScan.Click += new System.EventHandler(this.NewScan_Click);
            // 
            // Filter_
            // 
            this.Filter_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_.Enabled = false;
            this.Filter_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Filter_.Items.AddRange(new object[] {
            "Name",
            "Facultet",
            "Cafedra",
            "Degree",
            "Status"});
            this.Filter_.Location = new System.Drawing.Point(49, 201);
            this.Filter_.Name = "Filter_";
            this.Filter_.Size = new System.Drawing.Size(279, 33);
            this.Filter_.TabIndex = 4;
            this.Filter_.Tag = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ToHtml);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.method);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ScanValue);
            this.panel1.Controls.Add(this.NextScan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NewScan);
            this.panel1.Controls.Add(this.Filter_);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(472, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 450);
            this.panel1.TabIndex = 5;
            // 
            // ToHtml
            // 
            this.ToHtml.Location = new System.Drawing.Point(207, 240);
            this.ToHtml.Name = "ToHtml";
            this.ToHtml.Size = new System.Drawing.Size(105, 35);
            this.ToHtml.TabIndex = 6;
            this.ToHtml.Text = "To Html";
            this.ToHtml.UseVisualStyleBackColor = true;
            this.ToHtml.Click += new System.EventHandler(this.ToHtml_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scan metod";
            // 
            // method
            // 
            this.method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "DOM",
            "SAX",
            "LINQ"});
            this.method.Location = new System.Drawing.Point(53, 303);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(274, 33);
            this.method.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Value:";
            // 
            // ScanValue
            // 
            this.ScanValue.Enabled = false;
            this.ScanValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScanValue.Location = new System.Drawing.Point(49, 124);
            this.ScanValue.Name = "ScanValue";
            this.ScanValue.Size = new System.Drawing.Size(263, 30);
            this.ScanValue.TabIndex = 7;
            // 
            // NextScan
            // 
            this.NextScan.Enabled = false;
            this.NextScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextScan.Location = new System.Drawing.Point(185, 21);
            this.NextScan.Name = "NextScan";
            this.NextScan.Size = new System.Drawing.Size(131, 42);
            this.NextScan.TabIndex = 6;
            this.NextScan.Text = "Next scan";
            this.NextScan.UseVisualStyleBackColor = true;
            this.NextScan.Click += new System.EventHandler(this.NextScan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose filter:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "XmlReader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button NewScan;
        private System.Windows.Forms.ComboBox Filter_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextScan;
        private System.Windows.Forms.TextBox ScanValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.Button ToHtml;
    }
}

