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
    public partial class FormLogin : Form
    {
        
        /*tring strConn = @"Data Source=ADMIN\PHUONGTAN;Initial Catalog=TuDien;Integrated Security=True";*/
        string strConn = @"Data Source = DESKTOP-SBVPHLD;Initial Catalog=edit;Integrated Security=True";
        SqlConnection conn = null;
        public static string userLevel;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = getID(txtName.Text, txtPass.Text);

            if (userName != "")
            {
                Main fmain = new Main();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng hoặc mật khẩu không đúng !");
            }
        }

        private string getID(string name, string pass)
        {
            using(conn = new SqlConnection(strConn))
            {
                string id = "";
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Account WHERE UserName ='" + name + "' and Password='" + pass + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = dr["UserName"].ToString();
                            userLevel = dr["UserLevel"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return id;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
