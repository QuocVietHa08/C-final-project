using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();

            var taikhoan = from p in db.TaiKhoans
                           where (p.TenTaiKhoan == txttaikhoan.Text) && (p.MatKhauTaiKhoan == txtmk.Text)
                           select p;
            int count = taikhoan.Count();
            if(count == 1)
            {
                Form1 ss = new Form1();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Tai khoan dang nhap khong dung");
            }
      }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
