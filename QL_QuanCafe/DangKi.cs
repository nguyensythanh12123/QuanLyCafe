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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void rdadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdadmin.Checked)
            {
                panel2.Visible = false;
            }
        }
        KetNoiCSDL ket = new KetNoiCSDL();
        private void rdnhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnhanvien.Checked)
            {
                panel2.Visible = true;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }
        public bool kiemTraTrungQL(string s)
        {
            ket.moKetNoi();
            string them;
            them = "select count(*) from QUANLY where MaQL= '" + s + "'";
            SqlCommand cmd = new SqlCommand(them, ket.conn);
            int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                return true;
            }
            ket.DongKetNoi();
            return false;
        }
        public bool kiemTraTrungNV(string s)
        {
            ket.moKetNoi();
            string them;
            them = "select count(*) from NHANVIEN where MaNV= '" + s + "'";
            SqlCommand cmd = new SqlCommand(them, ket.conn);
            int val = (int)cmd.ExecuteScalar();
            if (val > 0)
            {
                return true;
            }
            ket.DongKetNoi();
            return false;
        }
        public void LoadBoPhan_combobox()
        {
            ket.moKetNoi();
            string selectbp = "select *from BOPHAN";
            SqlCommand cmd = new SqlCommand(selectbp, ket.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cb_BoPhan.Items.Add(rd["TenBP"].ToString());
            }
            cb_BoPhan.SelectedIndex = 0;
            ket.DongKetNoi();

        }
        public void LoadQL_combobox()
        {
            ket.moKetNoi();
            string selectql = "select *from QUANLY";
            SqlCommand cmd = new SqlCommand(selectql, ket.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cb_MaQL.Items.Add(rd["TenQL"].ToString());
            }
            cb_MaQL.SelectedIndex = 0;
            ket.DongKetNoi();

        }
        private void btdangky_Click(object sender, EventArgs e)
        {
            if (txt_TenTK.Text.Length > 0 && txt_HoTen.Text.Length > 0 && txt_SDT.Text.Length > 0 && txt_MatKhau.Text.Length > 0)
            {
                if (rdadmin.Checked)
                {
                    try
                    {
                        if (!kiemTraTrungQL(txt_TenTK.Text))
                        {
                            ket.moKetNoi();
                            string them;
                            them = "insert into QUANLY values ('" + txt_TenTK.Text + "',N'" + txt_HoTen.Text + "','" + datengaysinh.Text + "',N'" + cbgioitinh.SelectedItem.ToString() + "','" + txt_SDT.Text + "','" + txt_MatKhau.Text + "')";
                            SqlCommand cmd = new SqlCommand(them, ket.conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xin chào " + txt_HoTen.Text + " (^-^) !!", "Thông báo");

                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại tài khoản này (^-^) !!", "Thông báo");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng bạn thử lại (^-^) !!", "Thông báo");
                    }
                }
                if (rdnhanvien.Checked)
                    {
                        if (txt_DiaChi.Text.Length > 0)
                        {
                            try
                            {
                                if (!kiemTraTrungNV(txt_TenTK.Text))
                                {
                                    if ((DateTime.Now.Year - DateTime.Parse(datengaysinh.Text).Year) > 18 || DateTime.Parse(datengaysinh.Text).Year < DateTime.Parse(ngayvaolam.Text).Year)
                                    {
                                        //Xem MaQL tren cb_MaQL
                                        ket.moKetNoi();
                                        string xemMaQL = "select * from QUANLY where TenQL=N'" + cb_MaQL.SelectedItem.ToString() + "'";
                                        SqlCommand cmd = new SqlCommand(xemMaQL, ket.conn);
                                        SqlDataReader rd = cmd.ExecuteReader();
                                        string maQL = "";
                                        while (rd.Read())
                                        {
                                            maQL = rd["MaQL"].ToString();
                                        }
                                        ket.DongKetNoi();
                                        //Xem MaBP tren cb_MaBP
                                        ket.moKetNoi();
                                        string xemMaBP = "select * from BOPHAN where TenBP=N'" + cb_BoPhan.SelectedItem.ToString() + "'";
                                        SqlCommand cmd1 = new SqlCommand(xemMaBP, ket.conn);
                                        SqlDataReader rd1 = cmd1.ExecuteReader();
                                        string maBP = "";
                                        while (rd1.Read())
                                        {
                                            maBP = rd1["MaBP"].ToString();
                                        }
                                        ket.DongKetNoi();
                                        //Thêm nhân viên vào CSDL
                                        ket.moKetNoi();
                                        string them;
                                        them = "insert into NHANVIEN values ('" + txt_TenTK.Text + "',N'" + txt_HoTen.Text + "','" + datengaysinh.Text + "',N'" + cbgioitinh.SelectedItem.ToString() + "',N'" + txt_DiaChi.Text + "','" + txt_SDT.Text + "','" + ngayvaolam.Text + "','" + maQL + "','" + maBP + "','" + txt_MatKhau.Text + "')";
                                        SqlCommand cmd2 = new SqlCommand(them, ket.conn);
                                        cmd2.ExecuteNonQuery();

                                        MessageBox.Show("Xin chào " + txt_HoTen.Text + " (^-^) !!", "Thông báo");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn chưa đủ tuổi để làm việc rồi (^-^) !!", "Thông báo");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Đã tồn tại tài khoản này (^-^) !!", "Thông báo");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Vui lòng bạn thử lại (^-^) !!", "Thông báo");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin (^-^) !!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin (^-^) !!", "Thông báo");
                }
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            LoadQL_combobox();
            LoadBoPhan_combobox();
        }

        private void cbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
