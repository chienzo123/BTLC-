using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dictionary
{
    public partial class LichSu : Form
    {
        ///string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=TuDien;Integrated Security=True";
        string strConn = @"Data Source=ADMIN\PHUONGTAN;Initial Catalog=TuDien;Integrated Security=True";
        SqlConnection conn;

        public LichSu()
        {
            InitializeComponent();
        }

        private void LichSu_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(strConn))
            {
                try
                {
                    String sql = "Select Distinct * from History order by Anh ASC";
                    SqlDataAdapter daTuDien = new SqlDataAdapter(sql, conn);
                    DataTable dtTuDien = new DataTable();
                    daTuDien.Fill(dtTuDien);
                    dgvHistory.DataSource = dtTuDien;
                }
                catch
                {
                    return;
                }
            }
        }

    }
}
