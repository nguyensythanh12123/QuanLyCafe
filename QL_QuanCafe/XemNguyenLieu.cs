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

namespace QL_QuanCafe
{
    public partial class XemNguyenLieu : Form
    {
        public XemNguyenLieu()
        {
            InitializeComponent();
        }
        Class_QL_PhieuXuat xlxuat = new Class_QL_PhieuXuat();
        private void XemNguyenLieu_Load(object sender, EventArgs e)
        {
            dgv_NL.DataSource = xlxuat.loaddgvnl();
        }
    }
}
