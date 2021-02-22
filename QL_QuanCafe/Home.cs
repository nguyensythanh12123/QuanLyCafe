using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCafe
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        BanHang bh = new BanHang();
        public static string ten = string.Empty;
        public static string Ma = string.Empty;
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                return;
            }
            else
            {
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
                trangChủToolStripMenuItem.Enabled = false;
                menuStrip2.Enabled = false;
                menuStrip3.Enabled = false;
            }
        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
                if (!string.IsNullOrEmpty(ten))
                {
                    bh.label4.Text = ten.ToString();
                    bh.txtMaNV.Text = Ma.ToString();
                }
                bh.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            menuStrip2.Enabled = false;
            menuStrip3.Enabled = false;
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_MonAn ql = new QL_MonAn();
            ql.ShowDialog();
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LuongNhanVien ql = new QL_LuongNhanVien();
            ql.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_NhanVien ql = new QL_NhanVien();
            ql.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_NhapXuat ql = new QL_NhapXuat();
            ql.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QL_NguyenLieu ql = new QL_NguyenLieu();
            ql.ShowDialog();
        }

        private void vậtLiệuVàKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Ban_KhuyenMai ql = new QL_Ban_KhuyenMai();
            ql.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TK_DoanhThu tk = new TK_DoanhThu();
            tk.ShowDialog();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TK_NguyenLieu tk = new TK_NguyenLieu();
            tk.ShowDialog();
        }
    }
}
