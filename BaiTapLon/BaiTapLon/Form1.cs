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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Load_DocGia()
        {
            dbDataContext db = new dbDataContext();
            var docgia = from p in db.DocGias
                         select p;
            dsdocgia.DataSource = docgia;
        }
        public void Load_ComboDoiTuong()
        {
            dbDataContext db = new dbDataContext();
            var loaiDt = from p in db.DoiTuongs
                         select p;
            cbomadoituong.DataSource = loaiDt;
            cbomadoituong.DisplayMember = "TenDoiTuong";
            cbomadoituong.ValueMember = "MaDoiTuong";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_DocGia();
            Load_ComboDoiTuong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            DocGia them = new DocGia();
            them.MaDocGia = txtmadocgia.Text.Trim();
            them.HoTen = txthoten.Text;
            them.NgaySinh = txtngaysinh.Text;
            them.MaDoiTuong = cbomadoituong.SelectedValue.ToString();
            them.GioiTinh = cbogioitinh.Text;
            them.NgayCap = txtngaycap.Text;
            them.NgayHetHan = txtngayhethan.Text;

            db.DocGias.InsertOnSubmit(them);
            db.SubmitChanges();
            Load_DocGia();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
        }
    }
}
