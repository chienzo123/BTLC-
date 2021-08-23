using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dictionary
{
    public partial class formQuanLy : Form
    {
        //chuỗi kết nối

        //string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=TuDien;Integrated Security=True";
        //string strConn = @"Data Source=ADMIN\PHUONGTAN;Initial Catalog=TuDien;Integrated Security=True";
        string strConn = @"Data Source = DESKTOP-SBVPHLD;Initial Catalog=edit;Integrated Security=True";
        // Tạo đối tượng kết nối
        SqlConnection conn = null;
        //doi tuong de dua dữ kiệu vào DataTable dtTuDien
        SqlDataAdapter daTuDien = null;
        SqlDataAdapter daLoaiTu = null;
        //Tạo đói tượng hiển thị lên form
        DataTable dtTuDien = null;
        DataTable dtLoaiTu = null;

        int n = 0;
        bool Them;

        public formQuanLy()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn thoát không?", "Trả lời ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                this.Hide();
            }
        }
        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            loadDaTa();
        }

        #region Load form Quản Lý
        private void Fomat_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi đong ket noi
                conn = new SqlConnection(strConn);
                //chuyển dữ liệu lên DataTable dtTuDien
                daTuDien = new SqlDataAdapter("select * from tbl_edict_1 ", conn);
                dtTuDien = new DataTable();
                dtTuDien.Clear();
                daTuDien.Fill(dtTuDien);
                //Đưa dữ liieu lên DataGridView
                dgvTuDien.DataSource = dtTuDien;
                n = dgvTuDien.Rows.Count + 96;
                for (int i = 0; i < dtTuDien.Rows.Count; i++)
                {
                    dgvTuDien.Rows[i].Cells[0].Value = (i + 1);
                }
                this.panelQuanLy.Enabled = false;
                this.buttonHuy.Enabled = false;
                this.buttonLuu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Load lại form
        public void loadDaTa()
        {
            // Khởi đong ket noi
            conn = new SqlConnection(strConn);
            //chuyển dữ liệu lên DataTable dtTuDien
            daTuDien = new SqlDataAdapter("select idx,word,wordtype, spelling, means from tbl_edict_1", conn);
            dtTuDien = new DataTable();
            dtTuDien.Clear();
            daTuDien.Fill(dtTuDien);
            //Đưa dữ liieu lên DataGridView
            dgvTuDien.DataSource = dtTuDien;
            for (int i = 0; i < dtTuDien.Rows.Count; i++)
            {
                dgvTuDien.Rows[i].Cells[0].Value = (i + 1);
            }
            // Xóa trống các đối tượng trong Panel
            this.textBoxTuTiengAnh.ResetText();
            this.comboBoxLoaiTu.ResetText();
            this.richTextBoxNghiaTiengViet.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            this.buttonLuu.Enabled = false;
            this.buttonHuy.Enabled = false;
            this.panelQuanLy.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.buttonThem.Enabled = true;
            this.buttonSua.Enabled = true;
            this.buttonXoa.Enabled = true;
            this.buttonThoat.Enabled = true;
        }
        #endregion

        #region Button Xóa
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            //mo ket noi
            conn.Open();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                if (dgvTuDien.Rows.Count <= 1)
                {
                    MessageBox.Show("Không có dữ liệu để xóa !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    //lấy thứ tự từ hien hanh
                    int r = dgvTuDien.CurrentCell.RowIndex;
                    //lấy id của từ
                    string id = dgvTuDien.Rows[r].Cells[1].Value.ToString();
                    //cau lenh sql xoa
                    cmd.CommandText = "delete from tbl_edict_1 where idx ='" + id + "' ";
                    cmd.CommandType = CommandType.Text;

                    DialogResult traloi;
                    traloi = MessageBox.Show("Bạn có chắc muốn xóa từ này không?", "Trả lời ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (traloi == DialogResult.OK)
                    {
                        //thuc hien cau lenh sql
                        cmd.ExecuteNonQuery();
                        loadDaTa();
                        MessageBox.Show("Xóa thành công!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lai bang
                        
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi :Xóa không thành công!");
            }
            conn.Close();
        }
        #endregion

        #region Button Thêm
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.textBoxTuTiengAnh.ResetText();
            this.comboBoxLoaiTu.ResetText();
            this.richTextBoxNghiaTiengViet.ResetText();
            //cho phép các nút hoạt động
            this.buttonLuu.Enabled = true;
            this.buttonHuy.Enabled = true;
            this.panelQuanLy.Enabled = true;
            //không cho các nút hoạt động
            // this.buttonReLoad.Enabled = false;
            this.buttonThem.Enabled = false;
            this.buttonSua.Enabled = false;
            this.buttonXoa.Enabled = false;
            this.buttonThoat.Enabled = false;
            conn = new SqlConnection(strConn);
            daLoaiTu = new SqlDataAdapter("select * from LoaiTu", conn);
            dtLoaiTu = new DataTable();
            dtLoaiTu.Clear();
            daLoaiTu.Fill(dtLoaiTu);
            this.comboBoxLoaiTu.DataSource = dtLoaiTu;
            this.comboBoxLoaiTu.DisplayMember = "wordtype";
            this.comboBoxLoaiTu.ValueMember = "wordtype";
            this.textBoxTuTiengAnh.Focus();
        }
        #endregion

        #region Button Sửa
        private void buttonSua_Click(object sender, EventArgs e)
        {
            Them = false;
            //dua du lieu len cbb
            conn = new SqlConnection(strConn);
            daLoaiTu = new SqlDataAdapter("select * from LoaiTu", conn);
            dtLoaiTu = new DataTable();
            dtLoaiTu.Clear();
            daLoaiTu.Fill(dtLoaiTu);

            this.comboBoxLoaiTu.DataSource = dtLoaiTu;
            this.comboBoxLoaiTu.DisplayMember = "wordtype";
            this.comboBoxLoaiTu.ValueMember = "wordtype";

            this.panelQuanLy.Enabled = true;
            if (dgvTuDien.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để sửa !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
            else
            {
                //dòng hiện tại
                int r = dgvTuDien.CurrentCell.RowIndex;
                //load thông tin len panel
                this.textBoxTuTiengAnh.Text = dgvTuDien.Rows[r].Cells[2].Value.ToString();
                this.comboBoxLoaiTu.SelectedValue = dgvTuDien.Rows[r].Cells[3].Value.ToString();
                this.txtPhienAm.Text = dgvTuDien.Rows[r].Cells[4].Value.ToString();
                this.richTextBoxNghiaTiengViet.Text = dgvTuDien.Rows[r].Cells[5].Value.ToString();
                //cho phép các nút hoạt động
                this.buttonLuu.Enabled = true;
                this.buttonHuy.Enabled = true;
                this.panelQuanLy.Enabled = true;
                //không cho các nút hoạt động
                //this.buttonReLoad.Enabled = false;
                this.buttonThem.Enabled = false;
                this.buttonSua.Enabled = false;
                this.buttonXoa.Enabled = false;
                this.buttonThoat.Enabled = false;
                this.textBoxTuTiengAnh.Focus();
            }
        }

        #endregion

        #region Button Lưu
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Them)
            {
                try
                {
                    n = n++;
                    if (textBoxTuTiengAnh.Text.ToString() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập từ tiếng anh hoặc tồn tại, nhập lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxTuTiengAnh.Focus();
                    }
                    else
                        if (richTextBoxNghiaTiengViet.Text.ToString() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập nghĩa tiếng việt, nhập lại!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        richTextBoxNghiaTiengViet.Focus();
                    }
                    else
                    {
                        // Thực hiện lệnh
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = System.String.Concat("INSERT [tbl_edict_1] ([idx], [word], [wordtype], [spelling], [means]) VALUES ( " + n++ + " , N'" + textBoxTuTiengAnh.Text.ToString() + "', N'" + comboBoxLoaiTu.Text.ToString() + "', N'" + txtPhienAm.Text.ToString() + "', N' " + richTextBoxNghiaTiengViet.Text.ToString() + "')");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        loadDaTa();
                        MessageBox.Show("Đã thêm thành công", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi: Thêm không thành công", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBoxTuTiengAnh.Focus();
                }
            }
            if (!Them)
            {
                try
                {
                    if (textBoxTuTiengAnh.Text.ToString() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập từ tiếng anh, nhập lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxTuTiengAnh.Focus();
                    }
                    else if (richTextBoxNghiaTiengViet.Text.ToString() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập nghĩa tiếng việt, nhập lại!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        richTextBoxNghiaTiengViet.Focus();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;

                        int r = dgvTuDien.CurrentCell.RowIndex;
                        string id = dgvTuDien.Rows[r].Cells[1].Value.ToString();
                        //cau lenh sql

                        cmd.CommandText = System.String.Concat("update tbl_edict_1 set word ='" + this.textBoxTuTiengAnh.Text.ToString() + "',wordtype=N'" + this.comboBoxLoaiTu.SelectedValue.ToString() + "',means=N'" + this.richTextBoxNghiaTiengViet.Text.ToString() + "',spelling=N'" + this.txtPhienAm.Text.ToString() + "' where idx='" + id + "'");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        loadDaTa();
                        MessageBox.Show("Đã sửa thành công", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi: Sửa không thành công", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBoxTuTiengAnh.Focus();
                }
            }
            conn.Close();
        }
        #endregion

        #region Button Hủy
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.textBoxTuTiengAnh.ResetText();
            this.comboBoxLoaiTu.ResetText();
            this.richTextBoxNghiaTiengViet.ResetText();

            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.buttonReLoad.Enabled = true;
            this.buttonThem.Enabled = true;
            this.buttonSua.Enabled = true;
            this.buttonXoa.Enabled = true;
            this.buttonThoat.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.buttonLuu.Enabled = false;
            this.buttonHuy.Enabled = false;
            this.panelQuanLy.Enabled = false;
        }
        #endregion

        private void dgvTuDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private Boolean Check(string tunhap)
        //{
        //    Boolean t=true;
        //    for (int i = 0; i < dgvTuDien.Rows.Count; i++)
        //    {
        //        if (dgvTuDien.Rows[2].Cells[i].Value.ToString().Trim() == tunhap)
        //            t = false;
        //    }
        //    return t;
        //}
    }
}
