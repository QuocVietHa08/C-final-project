using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BaiTapLon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=EDWARD-HA\SQLEXPRESS;Initial Catalog=QuanLyDocGia_DoiTuong;Integrated Security=True");
        public void Load_DocGia()
        {
            string select = "select * from DocGia";
            SqlDataAdapter data = new SqlDataAdapter(select, conn);
            DataTable table = new DataTable();
            data.Fill(table);
            dsdocgia.DataSource = table;

           this.ActiveControl = txtmadocgia;
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
            var update = db.DocGias.Single(dg => dg.MaDocGia == txtmadocgia.Text);
            update.HoTen = txthoten.Text;
            update.GioiTinh = cbogioitinh.Text;
            update.NgaySinh = txtngaysinh.Text;
            update.MaDoiTuong = cbomadoituong.SelectedValue.ToString();
            update.NgayCap = txtngaycap.Text;
            update.NgayHetHan = txtngayhethan.Text;

            db.SubmitChanges();
            Load_DocGia();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var xoa = db.DocGias.Single(dg => dg.MaDocGia == txtmadocgia.Text);

            db.DocGias.DeleteOnSubmit(xoa);

            db.SubmitChanges();
            Load_DocGia();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
            var find = from dg in db.DocGias
                       where dg.MaDocGia == txtmadocgia.Text
                       select dg;
            dsdocgia.DataSource = find;
            Load_DocGia();  
        }

        private void dsdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmadocgia.Text = dsdocgia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txthoten.Text = dsdocgia.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbogioitinh.Text = dsdocgia.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtngaysinh.Text = dsdocgia.Rows[e.RowIndex].Cells[3].Value.ToString();
            // ma doi tuong hien thi ds ten doi tuong

            cbomadoituong.Text = dsdocgia.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtngaycap.Text = dsdocgia.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtngayhethan.Text = dsdocgia.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaoCao ss = new BaoCao();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txthoten.Text = "";
            txtngaycap.Text = "";
            txtngaysinh.Text = "";
            txtngayhethan.Text = "";
            cbogioitinh.Text = "";
            cbomadoituong.Text = "";
            this.ActiveControl = txtmadocgia;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Load_DocGia();
        }

        private void dsdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
