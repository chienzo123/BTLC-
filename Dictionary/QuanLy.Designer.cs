namespace dictionary
{
    partial class formQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLy));
            this.dgvTuDien = new System.Windows.Forms.DataGridView();
            this.buttonReLoad = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.txtPhienAm = new System.Windows.Forms.TextBox();
            this.richTextBoxNghiaTiengViet = new System.Windows.Forms.RichTextBox();
            this.comboBoxLoaiTu = new System.Windows.Forms.ComboBox();
            this.textBoxTuTiengAnh = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spelling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.means = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuDien)).BeginInit();
            this.panelQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTuDien
            // 
            this.dgvTuDien.AllowUserToOrderColumns = true;
            this.dgvTuDien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTuDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idx,
            this.word,
            this.wordtype,
            this.spelling,
            this.means});
            this.dgvTuDien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvTuDien.Location = new System.Drawing.Point(44, 379);
            this.dgvTuDien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvTuDien.Name = "dgvTuDien";
            this.dgvTuDien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTuDien.Size = new System.Drawing.Size(880, 316);
            this.dgvTuDien.TabIndex = 0;
            this.dgvTuDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuDien_CellContentClick);
            // 
            // buttonReLoad
            // 
            this.buttonReLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonReLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonReLoad.Image")));
            this.buttonReLoad.Location = new System.Drawing.Point(43, 305);
            this.buttonReLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReLoad.Name = "buttonReLoad";
            this.buttonReLoad.Size = new System.Drawing.Size(120, 38);
            this.buttonReLoad.TabIndex = 1;
            this.buttonReLoad.Text = "Reload";
            this.buttonReLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReLoad.UseVisualStyleBackColor = true;
            this.buttonReLoad.Click += new System.EventHandler(this.buttonReLoad_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonThoat.Image = ((System.Drawing.Image)(resources.GetObject("buttonThoat.Image")));
            this.buttonThoat.Location = new System.Drawing.Point(808, 304);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(116, 38);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.Location = new System.Drawing.Point(621, 305);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(103, 38);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.Location = new System.Drawing.Point(245, 305);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(107, 38);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Image = ((System.Drawing.Image)(resources.GetObject("buttonSua.Image")));
            this.buttonSua.Location = new System.Drawing.Point(435, 304);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(104, 38);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.Red;
            this.buttonLuu.Image = ((System.Drawing.Image)(resources.GetObject("buttonLuu.Image")));
            this.buttonLuu.Location = new System.Drawing.Point(808, 114);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(116, 39);
            this.buttonLuu.TabIndex = 11;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.Red;
            this.buttonHuy.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.Image")));
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(808, 218);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(116, 38);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.Controls.Add(this.label5);
            this.panelQuanLy.Controls.Add(this.label4);
            this.panelQuanLy.Controls.Add(this.label3);
            this.panelQuanLy.Controls.Add(this.label6);
            this.panelQuanLy.Controls.Add(this.txtPhienAm);
            this.panelQuanLy.Controls.Add(this.richTextBoxNghiaTiengViet);
            this.panelQuanLy.Controls.Add(this.comboBoxLoaiTu);
            this.panelQuanLy.Controls.Add(this.textBoxTuTiengAnh);
            this.panelQuanLy.Location = new System.Drawing.Point(45, 55);
            this.panelQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(755, 230);
            this.panelQuanLy.TabIndex = 12;
            // 
            // txtPhienAm
            // 
            this.txtPhienAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhienAm.Location = new System.Drawing.Point(322, 166);
            this.txtPhienAm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhienAm.Name = "txtPhienAm";
            this.txtPhienAm.Size = new System.Drawing.Size(357, 30);
            this.txtPhienAm.TabIndex = 5;
            // 
            // richTextBoxNghiaTiengViet
            // 
            this.richTextBoxNghiaTiengViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNghiaTiengViet.Location = new System.Drawing.Point(323, 62);
            this.richTextBoxNghiaTiengViet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxNghiaTiengViet.Name = "richTextBoxNghiaTiengViet";
            this.richTextBoxNghiaTiengViet.Size = new System.Drawing.Size(357, 30);
            this.richTextBoxNghiaTiengViet.TabIndex = 2;
            this.richTextBoxNghiaTiengViet.Text = "";
            // 
            // comboBoxLoaiTu
            // 
            this.comboBoxLoaiTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiTu.FormattingEnabled = true;
            this.comboBoxLoaiTu.Location = new System.Drawing.Point(4, 166);
            this.comboBoxLoaiTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLoaiTu.Name = "comboBoxLoaiTu";
            this.comboBoxLoaiTu.Size = new System.Drawing.Size(263, 33);
            this.comboBoxLoaiTu.TabIndex = 1;
            // 
            // textBoxTuTiengAnh
            // 
            this.textBoxTuTiengAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTuTiengAnh.Location = new System.Drawing.Point(4, 62);
            this.textBoxTuTiengAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTuTiengAnh.Name = "textBoxTuTiengAnh";
            this.textBoxTuTiengAnh.Size = new System.Drawing.Size(263, 30);
            this.textBoxTuTiengAnh.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // idx
            // 
            this.idx.DataPropertyName = "idx";
            this.idx.FillWeight = 71.402F;
            this.idx.HeaderText = "Mã từ";
            this.idx.MinimumWidth = 3;
            this.idx.Name = "idx";
            this.idx.Width = 60;
            // 
            // word
            // 
            this.word.DataPropertyName = "word";
            this.word.FillWeight = 116.4921F;
            this.word.HeaderText = "Từ Tiếng Anh";
            this.word.MinimumWidth = 6;
            this.word.Name = "word";
            this.word.Width = 120;
            // 
            // wordtype
            // 
            this.wordtype.DataPropertyName = "wordtype";
            this.wordtype.FillWeight = 142.132F;
            this.wordtype.HeaderText = "Loại Từ";
            this.wordtype.MinimumWidth = 6;
            this.wordtype.Name = "wordtype";
            this.wordtype.Width = 125;
            // 
            // spelling
            // 
            this.spelling.DataPropertyName = "spelling";
            this.spelling.HeaderText = "Phiên âm";
            this.spelling.MinimumWidth = 6;
            this.spelling.Name = "spelling";
            this.spelling.Width = 125;
            // 
            // means
            // 
            this.means.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.means.DataPropertyName = "means";
            this.means.FillWeight = 69.97396F;
            this.means.HeaderText = "Nghĩa Tiếng Việt";
            this.means.MinimumWidth = 6;
            this.means.Name = "means";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Từ tiếng Anh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại từ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nghĩa tiếng Việt :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phiên Âm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ TỪ ĐIỂN";
            // 
            // formQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(939, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonReLoad);
            this.Controls.Add(this.dgvTuDien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(957, 757);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(957, 757);
            this.Name = "formQuanLy";
            this.ShowInTaskbar = false;
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.Fomat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuDien)).EndInit();
            this.panelQuanLy.ResumeLayout(false);
            this.panelQuanLy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuDien;
        private System.Windows.Forms.Button buttonReLoad;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.RichTextBox richTextBoxNghiaTiengViet;
        private System.Windows.Forms.ComboBox comboBoxLoaiTu;
        private System.Windows.Forms.TextBox textBoxTuTiengAnh;
        private System.Windows.Forms.TextBox txtPhienAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn spelling;
        private System.Windows.Forms.DataGridViewTextBoxColumn means;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}