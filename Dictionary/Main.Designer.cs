namespace dictionary
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxTuDien = new System.Windows.Forms.TextBox();
            this.listBoxTuDien = new System.Windows.Forms.ListBox();
            this.richTextBoxTuDien = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThongTin = new System.Windows.Forms.Button();
            this.buttonQuanLy = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDich = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTuDien
            // 
            this.textBoxTuDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxTuDien.Location = new System.Drawing.Point(40, 140);
            this.textBoxTuDien.Multiline = true;
            this.textBoxTuDien.Name = "textBoxTuDien";
            this.textBoxTuDien.Size = new System.Drawing.Size(194, 31);
            this.textBoxTuDien.TabIndex = 0;
            this.textBoxTuDien.TextChanged += new System.EventHandler(this.textBoxTuDien_TextChanged);
            this.textBoxTuDien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTuDien_KeyDown);
            this.textBoxTuDien.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxTuDien_MouseDoubleClick);
            // 
            // listBoxTuDien
            // 
            this.listBoxTuDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxTuDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTuDien.ForeColor = System.Drawing.Color.Black;
            this.listBoxTuDien.FormattingEnabled = true;
            this.listBoxTuDien.ItemHeight = 19;
            this.listBoxTuDien.Location = new System.Drawing.Point(40, 223);
            this.listBoxTuDien.Name = "listBoxTuDien";
            this.listBoxTuDien.Size = new System.Drawing.Size(194, 346);
            this.listBoxTuDien.TabIndex = 1;
            this.listBoxTuDien.SelectedIndexChanged += new System.EventHandler(this.listBoxTuDien_SelectedIndexChanged);
            // 
            // richTextBoxTuDien
            // 
            this.richTextBoxTuDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxTuDien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTuDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBoxTuDien.Location = new System.Drawing.Point(325, 305);
            this.richTextBoxTuDien.Name = "richTextBoxTuDien";
            this.richTextBoxTuDien.Size = new System.Drawing.Size(382, 273);
            this.richTextBoxTuDien.TabIndex = 2;
            this.richTextBoxTuDien.Text = "";
            this.richTextBoxTuDien.TextChanged += new System.EventHandler(this.richTextBoxTuDien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(36, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(36, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách từ :";
            // 
            // buttonThongTin
            // 
            this.buttonThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonThongTin.Image = ((System.Drawing.Image)(resources.GetObject("buttonThongTin.Image")));
            this.buttonThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongTin.Location = new System.Drawing.Point(463, 140);
            this.buttonThongTin.Name = "buttonThongTin";
            this.buttonThongTin.Size = new System.Drawing.Size(111, 31);
            this.buttonThongTin.TabIndex = 5;
            this.buttonThongTin.Text = "Thông Tin";
            this.buttonThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThongTin.UseVisualStyleBackColor = true;
            this.buttonThongTin.Click += new System.EventHandler(this.buttonThongTin_Click);
            // 
            // buttonQuanLy
            // 
            this.buttonQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLy.Image")));
            this.buttonQuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLy.Location = new System.Drawing.Point(325, 140);
            this.buttonQuanLy.Name = "buttonQuanLy";
            this.buttonQuanLy.Size = new System.Drawing.Size(106, 31);
            this.buttonQuanLy.TabIndex = 5;
            this.buttonQuanLy.Text = "Quản Lý";
            this.buttonQuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuanLy.UseVisualStyleBackColor = true;
            this.buttonQuanLy.Click += new System.EventHandler(this.buttonQuanLy_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoat.Location = new System.Drawing.Point(606, 140);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(101, 31);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "TỪ ĐIỂN ANH - VIỆT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "MADE BY TEAM 7";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDich
            // 
            this.txtDich.Enabled = false;
            this.txtDich.Location = new System.Drawing.Point(325, 223);
            this.txtDich.Multiline = true;
            this.txtDich.Name = "txtDich";
            this.txtDich.Size = new System.Drawing.Size(299, 43);
            this.txtDich.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(240, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 30);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.lịchSửToolStripMenuItem.Text = "Lịch sử";
            this.lịchSửToolStripMenuItem.Click += new System.EventHandler(this.lịchSửToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 601);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonQuanLy);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThongTin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxTuDien);
            this.Controls.Add(this.listBoxTuDien);
            this.Controls.Add(this.textBoxTuDien);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(754, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(754, 640);
            this.Name = "Main";
            this.Text = "Từ điển Toán học Anh - Việt !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTuDien;
        private System.Windows.Forms.ListBox listBoxTuDien;
        private System.Windows.Forms.RichTextBox richTextBoxTuDien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThongTin;
        private System.Windows.Forms.Button buttonQuanLy;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDich;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
    }
}