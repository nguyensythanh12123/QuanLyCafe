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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKi dk = new DangKi();
            dk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home dk = new Home();
            dk.Show();
        }
       
        KetNoiCSDL kn = new KetNoiCSDL();
        private void button2_Click(object sender, EventArgs e)
        {
            Home dk = new Home();
            if (txtMatKhau.Text.Length > 0 && txtTaikhoan.Text.Length > 0)
            {
                try{
                kn.moKetNoi();
                string MaQL = "";
                string MatKhau = "";
                string doc = "select * from QUANLY";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                
                while (rd.Read())
                {
                    MaQL = rd["MaQL"].ToString();
                    MatKhau = rd["MatKhau"].ToString();
                   Home.ten = rd["TenQL"].ToString();
                   Home.Ma = rd["MaQL"].ToString();
                    if (txtMatKhau.Text == MatKhau.TrimEnd() && txtTaikhoan.Text == MaQL.TrimEnd()) 
                    {
                        this.Hide();
                        
                        dk.Show();
                        dk.trangChủToolStripMenuItem.Enabled = true;
                        dk.đăngXuấtToolStripMenuItem.Enabled = true;
                        dk.đăngNhậpToolStripMenuItem.Enabled = false;
                        dk.menuStrip2.Enabled = true;
                        dk.menuStrip3.Enabled = true;
                        return;
                    }
                }
                kn.DongKetNoi();
                }
                catch
                {
                    
                }
                try
                {
                    kn.moKetNoi();
                    //Nhân viên
                    string MaNV = "";
                    string MatKhauNV = "";
                    string doc1 = "select *from NHANVIEN";
                    SqlCommand cmd = new SqlCommand(doc1, kn.conn);
                    SqlDataReader rd1 = cmd.ExecuteReader();
                    while (rd1.Read())
                    {
                        MaNV = rd1["MaNV"].ToString();
                        MatKhauNV = rd1["MatKhauDN"].ToString();
                        Home.ten = rd1["TenNV"].ToString();
                        Home.Ma = rd1["MaNV"].ToString();
                        if (txtTaikhoan.Text == MaNV.TrimEnd() && txtMatKhau.Text == MatKhauNV.TrimEnd())
                        {
                            this.Hide();
                            dk.Show();
                            dk.trangChủToolStripMenuItem.Enabled = true;
                            dk.đăngXuấtToolStripMenuItem.Enabled = true;
                            dk.đăngNhậpToolStripMenuItem.Enabled = false;
                            dk.menuStrip2.Enabled = false;
                            dk.menuStrip3.Enabled = false;
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng kiểm tra lại Mật khẩu và tài khoản (^-^)", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu and Tài khoản (^-^)", "Thông báo");
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
