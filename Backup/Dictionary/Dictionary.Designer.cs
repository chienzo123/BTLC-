namespace dictionary
{
    partial class Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.listBoxWord = new System.Windows.Forms.ListBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.rbAnhViet = new System.Windows.Forms.RadioButton();
            this.rbVietAnh = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // themTuToolStripMenuItem
            // 
            this.themTuToolStripMenuItem.Name = "themTuToolStripMenuItem";
            this.themTuToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.themTuToolStripMenuItem.Text = "Format";
            this.themTuToolStripMenuItem.Click += new System.EventHandler(this.themTuToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(32, 95);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(208, 20);
            this.txtKeyWord.TabIndex = 1;
            this.txtKeyWord.TextChanged += new System.EventHandler(this.txtKeyWord_TextChanged);
            this.txtKeyWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyWord_KeyDown);
            // 
            // listBoxWord
            // 
            this.listBoxWord.FormattingEnabled = true;
            this.listBoxWord.Location = new System.Drawing.Point(32, 220);
            this.listBoxWord.Name = "listBoxWord";
            this.listBoxWord.Size = new System.Drawing.Size(208, 329);
            this.listBoxWord.Sorted = true;
            this.listBoxWord.TabIndex = 2;
            this.listBoxWord.SelectedIndexChanged += new System.EventHandler(this.listBoxWord_SelectedIndexChanged);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(278, 95);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(428, 454);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            this.rtbContent.ZoomFactor = 1.5F;
            this.rtbContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.rtbContent_MouseDoubleClick);
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // rbAnhViet
            // 
            this.rbAnhViet.AutoSize = true;
            this.rbAnhViet.Checked = true;
            this.rbAnhViet.Location = new System.Drawing.Point(20, 19);
            this.rbAnhViet.Name = "rbAnhViet";
            this.rbAnhViet.Size = new System.Drawing.Size(65, 17);
            this.rbAnhViet.TabIndex = 4;
            this.rbAnhViet.TabStop = true;
            this.rbAnhViet.Text = "Anh-Việt";
            this.rbAnhViet.UseVisualStyleBackColor = true;
            this.rbAnhViet.CheckedChanged += new System.EventHandler(this.rbAnhViet_CheckedChanged);
            // 
            // rbVietAnh
            // 
            this.rbVietAnh.AutoSize = true;
            this.rbVietAnh.Location = new System.Drawing.Point(117, 19);
            this.rbVietAnh.Name = "rbVietAnh";
            this.rbVietAnh.Size = new System.Drawing.Size(65, 17);
            this.rbVietAnh.TabIndex = 5;
            this.rbVietAnh.Text = "Việt-Anh";
            this.rbVietAnh.UseVisualStyleBackColor = true;
            this.rbVietAnh.CheckedChanged += new System.EventHandler(this.rbVietAnh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAnhViet);
            this.groupBox1.Controls.Add(this.rbVietAnh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Từ điển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách mục từ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Từ điển Anh - Việt + Việt - Anh";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(742, 578);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.listBoxWord);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Dictionary_Resize);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.ToolStripMenuItem themTuToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxWord;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.RadioButton rbAnhViet;
        private System.Windows.Forms.RadioButton rbVietAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

