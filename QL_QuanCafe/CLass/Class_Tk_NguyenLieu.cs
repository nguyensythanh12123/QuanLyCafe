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
    class Class_Tk_NguyenLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public void load_ListViewNL(ListView lv, string ngay1, string ngay2)
        {
            try
            {
                kn.moKetNoi();
                string[] s1 = ngay1.Split('/');
                string kq1 = "" + s1[1].ToString() + "/" + s1[0].ToString() + "/" + s1[2].ToString() + "";
                string[] s2 = ngay2.Split('/');
                string kq2 = "" + s2[1].ToString() + "/" + s2[0].ToString() + "/" + s2[2].ToString() + "";
                string s = "select MaQL,NgayNhap,NGUYENLIEU.MaNL,TenNL,CTPHIEUNHAP.SoLuong,DonGia,ThanhTien from PHIEUNHAP,CTPHIEUNHAP,NGUYENLIEU where PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN and CTPHIEUNHAP.MaNL = NGUYENLIEU.MaNL  and NgayNhap between '" + kq1 + "' and '" + kq2 + "'";
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = lv.Items.Count.ToString();
                    item.SubItems.Add(rd["MaQL"].ToString());
                    item.SubItems.Add(rd["NgayNhap"].ToString());
                    item.SubItems.Add(rd["MaNL"].ToString());
                    item.SubItems.Add(rd["TenNL"].ToString());
                    item.SubItems.Add(rd["SoLuong"].ToString());
                    item.SubItems.Add(rd["DonGia"].ToString());
                    item.SubItems.Add(rd["ThanhTien"].ToString());
                    lv.Items.Add(item);
                }
                rd.Close();
                kn.DongKetNoi();
            }
            catch
            {
            }
        }
        public void load_ListViewNLCbox(ListView lv, string ngay1)
        {
            kn.moKetNoi();
            string s = "select MaQL,NgayNhap,NGUYENLIEU.MaNL,TenNL,CTPHIEUNHAP.SoLuong,DonGia,ThanhTien from PHIEUNHAP,CTPHIEUNHAP,NGUYENLIEU where PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN and CTPHIEUNHAP.MaNL = NGUYENLIEU.MaNL  and NgayNhap = '" + ngay1 + "'";
            SqlCommand cmd = new SqlCommand(s, kn.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = lv.Items.Count.ToString();
                item.SubItems.Add(rd["MaQL"].ToString());
                item.SubItems.Add(rd["NgayNhap"].ToString());
                item.SubItems.Add(rd["MaNL"].ToString());
                item.SubItems.Add(rd["TenNL"].ToString());
                item.SubItems.Add(rd["SoLuong"].ToString());
                item.SubItems.Add(rd["DonGia"].ToString());
                item.SubItems.Add(rd["ThanhTien"].ToString());
                lv.Items.Add(item);
            }
            rd.Close();
            kn.DongKetNoi();
        }
        public void load_ListViewNLThangNam(ListView lv, string thang, string nam)
        {
            kn.moKetNoi();
            string s = "select MaQL,NgayNhap,NGUYENLIEU.MaNL,TenNL,CTPHIEUNHAP.SoLuong,DonGia,ThanhTien from PHIEUNHAP,CTPHIEUNHAP,NGUYENLIEU where PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN and CTPHIEUNHAP.MaNL = NGUYENLIEU.MaNL  and Month(NgayNhap)= '" + thang + "' AND Year(NgayNhap)='" + nam + "'";
            SqlCommand cmd = new SqlCommand(s, kn.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = lv.Items.Count.ToString();
                item.SubItems.Add(rd["MaQL"].ToString());
                item.SubItems.Add(rd["NgayNhap"].ToString());
                item.SubItems.Add(rd["MaNL"].ToString());
                item.SubItems.Add(rd["TenNL"].ToString());
                item.SubItems.Add(rd["SoLuong"].ToString());
                item.SubItems.Add(rd["DonGia"].ToString());
                item.SubItems.Add(rd["ThanhTien"].ToString());
                lv.Items.Add(item);
            }
            rd.Close();
            kn.DongKetNoi();
        }
        public void load_ListViewNLNam(ListView lv, string nam)
        {
            kn.moKetNoi();
            string s = "select MaQL,NgayNhap,NGUYENLIEU.MaNL,TenNL,CTPHIEUNHAP.SoLuong,DonGia,ThanhTien from PHIEUNHAP,CTPHIEUNHAP,NGUYENLIEU where PHIEUNHAP.MaPN = CTPHIEUNHAP.MaPN and CTPHIEUNHAP.MaNL = NGUYENLIEU.MaNL  and Year(NgayNhap) = '" + nam + "'";
            SqlCommand cmd = new SqlCommand(s, kn.conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = lv.Items.Count.ToString();
                item.SubItems.Add(rd["MaQL"].ToString());
                item.SubItems.Add(rd["NgayNhap"].ToString());
                item.SubItems.Add(rd["MaNL"].ToString());
                item.SubItems.Add(rd["TenNL"].ToString());
                item.SubItems.Add(rd["SoLuong"].ToString());
                item.SubItems.Add(rd["DonGia"].ToString());
                item.SubItems.Add(rd["ThanhTien"].ToString());
                lv.Items.Add(item);
            }
            rd.Close();
            kn.DongKetNoi();
        }
    }
}
