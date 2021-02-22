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
    class Class_TK_DoanhThu
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public void HienThiListViewLuongNV(ListView lv, string ngay1, string ngay2)
        {
            try
            {
                lv.Items.Clear();
                kn.moKetNoi();
                string[] s1 = ngay1.Split('/');
                string kq1 = "" + s1[1].ToString() + "/" + s1[0].ToString() + "/" + s1[2].ToString() + "";
                string[] s2 = ngay2.Split('/');
                string kq2 = "" + s2[1].ToString() + "/" + s2[0].ToString() + "/" + s2[2].ToString() + "";
                string s = "select * from LUONGNV where NgayPhatLuong between '" + kq1 + "' and '" + kq2 + "'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = lv.Items.Count.ToString();
                    item.SubItems.Add(rd["MaBL"].ToString());
                    item.SubItems.Add(rd["MaNV"].ToString());
                    item.SubItems.Add(rd["NgayPhatLuong"].ToString());
                    item.SubItems.Add(rd["Luong"].ToString());
                    lv.Items.Add(item);
                }
                rd.Close();
                kn.DongKetNoi();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public void HienThiListViewNgayLuongNV(ListView lv, string ngay1)
        {
            try
            {
                lv.Items.Clear();
                kn.moKetNoi();
                string s = "select * from LUONGNV where NgayPhatLuong = '" + ngay1 + "'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = lv.Items.Count.ToString();
                    item.SubItems.Add(rd["MaBL"].ToString());
                    item.SubItems.Add(rd["MaNV"].ToString());
                    item.SubItems.Add(rd["NgayPhatLuong"].ToString());
                    item.SubItems.Add(rd["Luong"].ToString());
                    lv.Items.Add(item);

                }
                rd.Close();
                kn.DongKetNoi();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }
        //Thống kế doanh thu
        public void Load_DataGirdViewMaskDoanhThu(DataGridView dtg, string ngay1, string ngay2)
        {
            try
            {
                string[] s1 = ngay1.Split('/');
                string kq1 = "" + s1[1].ToString() + "/" + s1[0].ToString() + "/" + s1[2].ToString() + "";
                string[] s2 = ngay2.Split('/');
                string kq2 = "" + s2[1].ToString() + "/" + s2[0].ToString() + "/" + s2[2].ToString() + "";
                string s = "select*from HOADON where NgayTao between '" + kq1 + "' and '" + kq2 + "' and TrangThaiTT= N'Đã Thanh Toán'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }

        public void Load_DataGirdViewDoanhThu(DataGridView dtg, string ngay1)
        {
            try
            {
                string s = "select*from HOADON where NgayTao = '" + ngay1 + "' and TrangThaiTT= N'Đã Thanh Toán'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public void Load_DataGirdViewThangNamDoanhThu(DataGridView dtg, string thang, string nam)
        {
            try
            {
                string s = "SELECT * FROM HOADON WHERE Month(NgayTao)= '" + thang + "' AND Year(NgayTao)='" + nam + "' and TrangThaiTT= N'Đã Thanh Toán'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public void Load_DataGirdViewNamDoanhThu(DataGridView dtg, string nam)
        {
            try
            {
                string s = "SELECT * FROM HOADON WHERE  Year(NgayTao)= '" + nam + "' and TrangThaiTT= N'Đã Thanh Toán'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public void Load_DataGirdViewChiTietDoanhThu(DataGridView dtg, string maHD)
        {
            try
            {
                string s = "select HOADON.MaHD, TenMon, SoLuong, ThanhTien from CTHOADON,MENU,HOADON where CTHOADON.MaMon = MENU.MaMon and HOADON.MaHD = CTHOADON.MaHD and HOADON.MaHD = '" + maHD + "'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
        }

    }
}
