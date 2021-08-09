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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxNghiaTiengViet = new System.Windows.Forms.RichTextBox();
            this.comboBoxLoaiTu = new System.Windows.Forms.ComboBox();
            this.textBoxTuTiengAnh = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentu_tienganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaithich_tiengviet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhienAm = new System.Windows.Forms.TextBox();
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
            this.id,
            this.tentu_tienganh,
            this.loai_tu,
            this.giaithich_tiengviet,
            this.Column1});
            this.dgvTuDien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvTuDien.Location = new System.Drawing.Point(33, 308);
            this.dgvTuDien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTuDien.Name = "dgvTuDien";
            this.dgvTuDien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTuDien.Size = new System.Drawing.Size(660, 257);
            this.dgvTuDien.TabIndex = 0;
            this.dgvTuDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuDien_CellContentClick);
            // 
            // buttonReLoad
            // 
            this.buttonReLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonReLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonReLoad.Image")));
            this.buttonReLoad.Location = new System.Drawing.Point(32, 248);
            this.buttonReLoad.Name = "buttonReLoad";
            this.buttonReLoad.Size = new System.Drawing.Size(90, 31);
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
            this.buttonThoat.Location = new System.Drawing.Point(606, 247);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(87, 31);
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
            this.buttonXoa.Location = new System.Drawing.Point(466, 248);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(77, 31);
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
            this.buttonThem.Location = new System.Drawing.Point(184, 248);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(80, 31);
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
            this.buttonSua.Location = new System.Drawing.Point(326, 247);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(78, 31);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ TỪ ĐIỂN";
            // 
            // buttonLuu
            // 
            this.buttonLuu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.Red;
            this.buttonLuu.Image = ((System.Drawing.Image)(resources.GetObject("buttonLuu.Image")));
            this.buttonLuu.Location = new System.Drawing.Point(606, 95);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(87, 32);
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
            this.buttonHuy.Location = new System.Drawing.Point(606, 170);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(87, 31);
            this.buttonHuy.TabIndex = 11;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.Controls.Add(this.txtPhienAm);
            this.panelQuanLy.Controls.Add(this.label5);
            this.panelQuanLy.Controls.Add(this.label4);
            this.panelQuanLy.Controls.Add(this.label3);
            this.panelQuanLy.Controls.Add(this.label2);
            this.panelQuanLy.Controls.Add(this.richTextBoxNghiaTiengViet);
            this.panelQuanLy.Controls.Add(this.comboBoxLoaiTu);
            this.panelQuanLy.Controls.Add(this.textBoxTuTiengAnh);
            this.panelQuanLy.Location = new System.Drawing.Point(34, 45);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(566, 187);
            this.panelQuanLy.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nghĩa tiếng Việt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại từ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ tiếng Anh :";
            // 
            // richTextBoxNghiaTiengViet
            // 
            this.richTextBoxNghiaTiengViet.Location = new System.Drawing.Point(242, 50);
            this.richTextBoxNghiaTiengViet.Name = "richTextBoxNghiaTiengViet";
            this.richTextBoxNghiaTiengViet.Size = new System.Drawing.Size(269, 32);
            this.richTextBoxNghiaTiengViet.TabIndex = 2;
            this.richTextBoxNghiaTiengViet.Text = "";
            // 
            // comboBoxLoaiTu
            // 
            this.comboBoxLoaiTu.FormattingEnabled = true;
            this.comboBoxLoaiTu.Location = new System.Drawing.Point(3, 135);
            this.comboBoxLoaiTu.Name = "comboBoxLoaiTu";
            this.comboBoxLoaiTu.Size = new System.Drawing.Size(198, 21);
            this.comboBoxLoaiTu.TabIndex = 1;
            // 
            // textBoxTuTiengAnh
            // 
            this.textBoxTuTiengAnh.Location = new System.Drawing.Point(3, 50);
            this.textBoxTuTiengAnh.Name = "textBoxTuTiengAnh";
            this.textBoxTuTiengAnh.Size = new System.Drawing.Size(198, 20);
            this.textBoxTuTiengAnh.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "MaTu";
            this.id.FillWeight = 71.402F;
            this.id.HeaderText = "Mã từ";
            this.id.MinimumWidth = 3;
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // tentu_tienganh
            // 
            this.tentu_tienganh.DataPropertyName = "NghiaTA";
            this.tentu_tienganh.FillWeight = 116.4921F;
            this.tentu_tienganh.HeaderText = "Từ Tiếng Anh";
            this.tentu_tienganh.Name = "tentu_tienganh";
            this.tentu_tienganh.Width = 120;
            // 
            // loai_tu
            // 
            this.loai_tu.DataPropertyName = "LoaiTu";
            this.loai_tu.FillWeight = 142.132F;
            this.loai_tu.HeaderText = "Loại Từ";
            this.loai_tu.Name = "loai_tu";
            // 
            // giaithich_tiengviet
            // 
            this.giaithich_tiengviet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giaithich_tiengviet.DataPropertyName = "NghiaTV";
            this.giaithich_tiengviet.FillWeight = 69.97396F;
            this.giaithich_tiengviet.HeaderText = "Nghĩa Tiếng Việt";
            this.giaithich_tiengviet.Name = "giaithich_tiengviet";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ViDu";
            this.Column1.HeaderText = "Ví Dụ";
            this.Column1.Name = "Column1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phiên Âm:";
            // 
            // txtPhienAm
            // 
            this.txtPhienAm.Location = new System.Drawing.Point(242, 135);
            this.txtPhienAm.Name = "txtPhienAm";
            this.txtPhienAm.Size = new System.Drawing.Size(269, 20);
            this.txtPhienAm.TabIndex = 5;
            // 
            // formQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 585);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonReLoad);
            this.Controls.Add(this.dgvTuDien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 624);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(722, 624);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxNghiaTiengViet;
        private System.Windows.Forms.ComboBox comboBoxLoaiTu;
        private System.Windows.Forms.TextBox textBoxTuTiengAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentu_tienganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaithich_tiengviet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtPhienAm;
        private System.Windows.Forms.Label label5;
    }
}