using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        WebBrowser wb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnaddweb_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 900;
            wb.Height = 400;
            panel1.Controls.Add(wb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = txtweb.Text;
            wb.Navigate(link);
        }
    }
}
