using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dictionary.db;

namespace dictionary
{
    public partial class Dictionary : Form
    {
        private dao db;
        public Dictionary()
        {
            InitializeComponent();
        }

        private void hidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dao();
            DataTable tbl = db.getListWord();
            fillListWord(tbl);
        }
        private void fillListWord(DataTable tbl)
        {
            if (tbl != null)
            {
                listBoxWord.Items.Clear();
                if (rbAnhViet.Checked)
                {
                    foreach (DataRow r in tbl.Rows)
                    {
                        if (!listBoxWord.Items.Contains(r["tentu_tienganh"].ToString()))
                        {
                            listBoxWord.Items.Add(r["tentu_tienganh"].ToString());
                        }

                    }
                }
                else
                {
                    foreach (DataRow r in tbl.Rows)
                    {
                        if (!listBoxWord.Items.Contains(r["tentu_tiengviet"].ToString()))
                        {
                            listBoxWord.Items.Add(r["tentu_tiengviet"].ToString());
                        }
                    }
                }
                
            }
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            if (rbAnhViet.Checked)
            {
                DataTable tbl = db.getListWordEnglish(txtKeyWord.Text);
                fillListWord(tbl);
            }
            else
            {
                DataTable tbl = db.getListWordVietNam(txtKeyWord.Text);
                fillListWord(tbl);
            }
            if (listBoxWord.Items.Count > 0)
            {
                listBoxWord.SelectedIndex = 0;
            }

        }

        private void themTuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTu frm = new frmThemTu();
            frm.ShowDialog();
            db = new dao();
            DataTable tbl = db.getListWord();
            fillListWord(tbl);
        }

        private void rbAnhViet_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tbl = db.getListWordEnglish(txtKeyWord.Text);
            fillListWord(tbl);
        }

        private void rbVietAnh_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tbl = db.getListWordVietNam(txtKeyWord.Text);
            fillListWord(tbl);
        }

        private void listBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbAnhViet.Checked)
            {
                DataTable tbl = db.getContentEnglishByWord(listBoxWord.Text);
                if (tbl != null)
                {
                    if (tbl.Rows.Count > 0)
                    {
                      setRichTexBox(tbl);
                    }
                }
            }
            else
            {
                DataTable tbl = db.getContentVietNamByWord(listBoxWord.Text);
                if (tbl != null)
                {
                    if (tbl.Rows.Count > 0)
                    {
                        setRichTexBox(tbl);
                    }
                }
            }
        }
        private void setRichTexBox(DataTable tbl)
        {
           // string goc = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1041{\\fonttbl{\\f0\\fswiss\\fprq2\\fcharset0 Arial;}}{\\colortbl ;\\red255\\green0\\blue0;\\red255\\green0\\blue255;\\red0\\green176\\blue80;}{\\*\\generator Msftedit 5.41.21.2508;}\\viewkind4\\uc1\\pard\\nowidctlpar\\cf1\\b\\f0\\fs20 Nghia cua tu:\\cf0\\b0\\par  [nghia]\\par\\cf2\\b Loai tu:[loaitu]\\cf0\\par\\cf3 Giai thich:\\par\\cf0\\b0   [giaithich]\\par}";
            
            string st1="{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1041{\\fonttbl{\\f0\\fswiss\\fprq2\\fcharset0 Arial;}}" 
                       + "{\\colortbl ;\\red255\\green0\\blue0;\\red255\\green0\\blue255;\\red0\\green176\\blue80;}"
                       + "{\\*\\generator Msftedit 5.41.21.2508;}\\viewkind4\\uc1\\pard\\nowidctlpar\\cf1\\b\\f0\\fs20 ";



            string st2= "\\cf1\\b\\f0\\fs20 Ngh\\u297?a c\\u7911?a t\\u7915?:\\cf0\\b0\\par      [nghia]\\par"
                        + "\\cf2\\b Lo\\u7841?i t\\u7915?:\\cf0     [loaitu]\\par"
                        +"\\cf3 Gi\\u7843?i th\\'edch:\\par"
                        +"\\cf0\\b0      [giaithich]\\par"
                        +"\\par" ;



            string st3 = "}";
            string tt = "";
            string str = ""; 
            foreach (DataRow r in tbl.Rows )
            {
                if (rbAnhViet.Checked)
                {
                    
                    //str += r["tentu_tiengviet"].ToString() + "\n";
                    //str += "Giải thích: " + r["giaithich_tiengviet"].ToString() + "\n";
                    //str += "Loại từ: " + r["loai_tu"].ToString() + "\n";
                    tt = st2;
                    tt=tt.Replace("[nghia]", DecodeString(r["tentu_tiengviet"].ToString()));
                    tt = tt.Replace("[loaitu]", DecodeString(r["loai_tu"].ToString()));
                    tt = tt.Replace("[giaithich]", DecodeString(r["giaithich_tiengviet"].ToString()));
                    str+=tt;
                    
                    
                 }
                else
                {                    
                    //str += r["tentu_tienganh"].ToString() + "\n";
                    //str += "Giải thích: " + r["giaithich_tienganh"].ToString() + "\n";
                    //str += "Loại từ: " + r["loai_tu"].ToString() + "\n";       
                    tt = st2;
                    tt = tt.Replace("[nghia]", DecodeString(r["tentu_tienganh"].ToString()));
                    tt = tt.Replace("[loaitu]", DecodeString(r["loai_tu"].ToString()));
                    tt = tt.Replace("[giaithich]", DecodeString(r["giaithich_tienganh"].ToString()));
                    str+=tt;
                }
            }
            str = st1 + str + st3;
            rtbContent.Rtf  = str;
        }
        private string DecodeString(string unicodeString)
        {
            Encoding uni = Encoding.Unicode ;
            Byte[] encodedBytes = uni.GetBytes(unicodeString);
            int i = 0;
            int code = 0;
            string ret = "";
            for (i = 0; i < encodedBytes.Length - 1; )
            {
                code =BitConverter.ToUInt16(encodedBytes, i);                    
                if (code>254)
                {
                    ret +="\\u" + code.ToString ()+"?";
                }
                else if (code == 10) //Ma cua ky tu enter la 10
                {
                    ret += "\\par      ";
                }
                else
                {
                  ret += BitConverter.ToChar (encodedBytes, i);
                }

                i += 2;
            }
            return ret;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.closeConn();
        }

        private void txtKeyWord_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode  == Keys.Enter)
            {
                listBoxWord.SelectedItem = txtKeyWord.Text;
            }
            if (e.KeyCode == Keys.Up )
            {
                listBoxWord.Focus();
            }
            if (e.KeyCode == Keys.Down )
            {
                listBoxWord.Focus();
            }
        }
        
        private void Dictionary_Resize(object sender, EventArgs e)
        {
            listBoxWord.Size = new Size(listBoxWord.Size.Width, this.Height - 50 - listBoxWord.Location.Y);
            rtbContent.Size = new Size(this.Width  - 40 - rtbContent.Location.X, this.Height - 50 - rtbContent.Location.Y);
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbContent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rtbContent.SelectedText != "")
            {
                string SelectedWord = rtbContent.SelectedText;
                DataTable tbl = db.getListWordVietNam(SelectedWord);
                if (tbl.Rows.Count > 0)
                {
                    rbVietAnh.Checked = true;
                    txtKeyWord.Text = rtbContent.SelectedText;
                    if (listBoxWord.Items.Count > 0)
                    {
                        listBoxWord.SelectedIndex = 0;
                    }
                }
                tbl = db.getListWordEnglish(SelectedWord);
                if (tbl.Rows.Count > 0)
                {
                    rbAnhViet.Checked = true;
                    txtKeyWord.Text = rtbContent.SelectedText;
                    if (listBoxWord.Items.Count > 0)
                    {
                        listBoxWord.SelectedIndex = 0;
                    }
                }       
            }

        }
    }
}