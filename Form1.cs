using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai19_DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = "NPT";
            string p = "2908";
            if (txtUser.Text == u && txtPass.Text == p)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                if (txtUser.TextLength == 0)
                {
                    errorProviderUser.SetError(txtUser, "Không được để trống");
                }
                else
                {
                    errorProviderUser.Clear();
                }

                if (txtPass.TextLength == 0)
                {
                    errorProviderPass.SetError(txtPass, "Không được để trống");
                }
                else
                {
                    errorProviderPass.Clear();
                }

                lblInfo.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }
    }
}
