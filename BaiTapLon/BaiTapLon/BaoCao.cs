﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace BaiTapLon
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=EDWARD-HA\SQLEXPRESS;Initial Catalog=QuanLyDocGia_DoiTuong;Integrated Security=True");
        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime begin = DateTime.Parse(txtngaycap.Text);
            DateTime end = DateTime.Parse(txtngayhethan.Text);

            string select = "select * from Docgia where NgayCap between '" + begin + "' and '" + end + "'";

            SqlDataAdapter data = new SqlDataAdapter(select, conn);
            DataTable table = new DataTable();
            data.Fill(table);

            dsDoiTuong.DataSource = table;
            
        
        
        }


        private void BaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
