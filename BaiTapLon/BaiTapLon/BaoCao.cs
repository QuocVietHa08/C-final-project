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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext();
           // DateTime start = DateTime.Parse(txtngaycap.Text);
           // DateTime end = DateTime.Parse(txtngayhethan.Text);
            var find = from p in db.DocGias
                       select p;
            dsDoiTuong.DataSource = find;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
