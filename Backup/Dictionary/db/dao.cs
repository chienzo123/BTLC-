using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace dictionary.db
{
    class dao
    {
        static string path=Application.StartupPath;
        private SqlDataAdapter apdapter;
        private SqlConnection conn;
        private SqlCommand cmd;
        private static string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+path+"\\db\\tudien.mdf;Integrated Security=True;User Instance=True";
        public dao()
        {
            //MessageBox.Show(strConn);
            openConn();
        }
        private void openConn()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            apdapter = new SqlDataAdapter(cmd);
        }
        public void closeConn()
        {
            conn.Close();
            apdapter = null;
            cmd = null;
            conn = null;
        }
        public DataTable getListWord()
        {
            DataTable tbl = null;
            try
            {
                 string strSelect = "SELECT id, tentu_tienganh,tentu_tiengviet,loai_tu,giaithich_tienganh,  giaithich_tiengviet  FROM table_tu order by tentu_tienganh ASC";
                //cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSelect;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                apdapter.SelectCommand = cmd;
                apdapter.Fill(ds);
                tbl= ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return tbl;
        }
        public DataTable getListWordVietNam(string keyword)
        {
            DataTable tbl = null;
            try
            {
                string strSelect = "select tentu_tiengviet,tentu_tienganh from table_tu where tentu_tiengviet like N'" + keyword + "%'";
                cmd.CommandText = strSelect;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                apdapter.SelectCommand = cmd;
                apdapter.Fill(ds);
                tbl = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return tbl;
        }
        public void deleteWord(string id)
        {
            try
            {
                string strDelete = "delete from table_tu where id=" + id;
                cmd.CommandText = strDelete;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("khong the xoa du lieu");
            }
        }
        public void insertWord(string tenTiengAnh,string tenTiengViet,string gtTiengAnh,string gtTiengViet,string loaiTu)
        {
            try
            {
                cmd.Parameters.Clear();
                SqlParameter paramTenTiengAnh = new SqlParameter("@tentu_tienganh", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramTenTiengAnh);
                SqlParameter paramTenTiengViet = new SqlParameter("@tentu_tiengviet", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramTenTiengViet);
                SqlParameter paramGtTiengAnh = new SqlParameter("@giaithich_tienganh", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramGtTiengAnh);
                SqlParameter paramGtTiengViet = new SqlParameter("@giaithich_tiengviet", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramGtTiengViet);
                SqlParameter paramLoaiTu = new SqlParameter("@loai_tu", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramLoaiTu);

                cmd.Parameters["@tentu_tienganh"].Value = tenTiengAnh;
                cmd.Parameters["@tentu_tiengviet"].Value = tenTiengViet;
                cmd.Parameters["@giaithich_tienganh"].Value = gtTiengAnh;
                cmd.Parameters["@giaithich_tiengviet"].Value = gtTiengViet;
                cmd.Parameters["@loai_tu"].Value = loaiTu;
                string strInsert = "insert into table_tu(tentu_tienganh,tentu_tiengviet,giaithich_tienganh,giaithich_tiengviet,loai_tu) values(@tentu_tienganh,@tentu_tiengviet,@giaithich_tienganh,@giaithich_tiengviet,@loai_tu)";
                
                cmd.CommandText = strInsert;
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            { MessageBox.Show(e.ToString()); }
        }
        public void updateWord( string id, string tenTiengAnh, string tenTiengViet, string gtTiengAnh, string gtTiengViet, string loaiTu)
        {
            try
            {

                cmd.Parameters.Clear();

                SqlParameter paramTenTiengAnh = new SqlParameter("@tentu_tienganh", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramTenTiengAnh);
                SqlParameter paramTenTiengViet = new SqlParameter("@tentu_tiengviet", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramTenTiengViet);
                SqlParameter paramGtTiengAnh = new SqlParameter("@giaithich_tienganh", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramGtTiengAnh);
                SqlParameter paramGtTiengViet = new SqlParameter("@giaithich_tiengviet", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramGtTiengViet);
                SqlParameter paramLoaiTu = new SqlParameter("@loai_tu", SqlDbType.NVarChar);
                cmd.Parameters.Add(paramLoaiTu);
                cmd.Parameters["@tentu_tienganh"].Value = tenTiengAnh;
                cmd.Parameters["@tentu_tiengviet"].Value = tenTiengViet;
                cmd.Parameters["@giaithich_tienganh"].Value = gtTiengAnh;
                cmd.Parameters["@giaithich_tiengviet"].Value = gtTiengViet;
                cmd.Parameters["@loai_tu"].Value = loaiTu;
                string strUpdate = "update table_tu set tentu_tienganh=@tentu_tienganh,tentu_tiengviet=@tentu_tiengviet,giaithich_tienganh=@giaithich_tienganh,giaithich_tiengviet=@giaithich_tiengviet,loai_tu=@loai_tu where id="+id;

                cmd.CommandText = strUpdate;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            { MessageBox.Show(e.ToString()); }
        }
        public DataTable getListWordEnglish(string keyword)
        {
            DataTable tbl = null;
            keyword = keyword.Trim();
            try
            {
                string strSelect = "select tentu_tienganh,tentu_tiengviet from table_tu where tentu_tienganh like N'" + keyword + "%'";
                cmd.CommandText = strSelect;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                apdapter.SelectCommand = cmd;
                apdapter.Fill(ds);
                tbl = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return tbl;
        }
        public DataTable getContentEnglishByWord(string word)
        {
            DataTable tbl = null;
            try
            {
                string strSelect = "select * from table_tu where tentu_tienganh='" + word + "'";
                cmd.CommandText = strSelect;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                apdapter.SelectCommand = cmd;
                apdapter.Fill(ds);
                tbl = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return tbl;
        }
        public DataTable getContentVietNamByWord(string word)
        {
            DataTable tbl = null;
            try
            {
                string strSelect = "select * from table_tu where tentu_tiengviet= N'" + word + "'";
                cmd.CommandText = strSelect;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                apdapter.SelectCommand = cmd;
                apdapter.Fill(ds);
                tbl = ds.Tables[0];
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return tbl;
        }
    }
}
