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
     
    class Class_BanHang
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public TextBox maBan;
        public TextBox maHoaDonBan;
        public TextBox SL;
        public string maMon;
        public int soLuong = 0;
        
       public DataGridView dv;
        Button btnBan;
        public void selectBan(FlowLayoutPanel f, ImageList l)
        {
            try
            {
                kn.moKetNoi();
                string doc = "select * from BAN";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();

                while (rd.Read())
                {
                    Button btn = new Button { Text = rd["TenBan"].ToString(), ForeColor = Color.Black, BackColor = Color.White, ImageList = l, ImageIndex = 0, TextImageRelation = TextImageRelation.ImageAboveText };
                    btn.Width = 100; btn.Height = 60;
                    if (rd["TrangThai"].ToString() == "Đã Có Người")
                    {
                        btn.BackColor = Color.Red;
                    }
                    btn.Click += btn_clickBan;
                   f.Controls.Add(btn);
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
        }
        public  void btn_clickBan(object sender, EventArgs e)
        {
            try
            {
                kn.moKetNoi();
                string doc = "select * from BAN";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                     btnBan = sender as Button;
                     if (btnBan.BackColor == Color.White && btnBan.Text == rd["TenBan"].ToString())
                     {
                         btnBan.BackColor = Color.Yellow;
                         maBan.Text = rd["MaBan"].ToString();
                     }
                     else if (btnBan.BackColor == Color.Yellow && btnBan.Text == rd["TenBan"].ToString())
                     {
                         btnBan.BackColor = Color.White;
                         maBan.Text = "";
                     }
                     else if (btnBan.Text == rd["TenBan"].ToString() && rd["TrangThai"].ToString() == "Đã Có Người")
                     {
                         //BanHang bh = new BanHang();
                         //hienThiLendatagirdview(bh.dataGridView1, laymahd(rd["MaBan"].ToString()));
                       // hienThiLendatagirdviewtheoban(dv, rd["MaBan"].ToString(), laymahd(rd["MaBan"].ToString()));
                         maHoaDonBan.Text = laymahd(rd["MaBan"].ToString());
                     }
                }
                kn.DongKetNoi();
            }
            catch
            {
            }

        }
        public string laymahd(string maban)
        {
            kn.DongKetNoi();
            kn.moKetNoi();
            string layma = "select * from HoaDon hd , BAN where hd.MaBan = BAN.MaBan and  hd.MaBan='" + maban + "' and TrangThai= N'Đã Có Người'";
            SqlCommand cmd = new SqlCommand(layma, kn.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MaHD"].ToString();
            }
            dr.Close();
            kn.DongKetNoi();
            return ma;
        }
        public void selectMon(FlowLayoutPanel ThucAn, ImageList img, FlowLayoutPanel DoUong)
        {
            int dem = 0;
            try
            {
                kn.moKetNoi();
                string doc = "select * from MENU where MaLoai='LM01'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    string hinh = rd["HinhAnh"].ToString();
                    img.Images.Add(Image.FromFile(hinh));
                    Button btn = new Button { Text = rd["TenMon"].ToString(), ForeColor = Color.Black ,BackColor = Color.White,ImageList = img, ImageIndex = dem++, TextImageRelation = TextImageRelation.ImageAboveText };
                    btn.Width = 150; btn.Height = 100;
                    btn.Click += btn_clickMonAn;
                    DoUong.Controls.Add(btn);
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
            try
            {
                kn.moKetNoi();
                string doc = "select * from MENU where MaLoai='LM02'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    img.Images.Add(Image.FromFile(rd["HinhAnh"].ToString()));
                    Button btn = new Button { Text = rd["TenMon"].ToString(), ForeColor = Color.Black, BackColor = Color.White,ImageList = img, ImageIndex = dem++, TextImageRelation = TextImageRelation.ImageAboveText };
                    btn.Width = 150; btn.Height = 100;
                    btn.Click += btn_clickMonAn;
                    ThucAn.Controls.Add(btn);
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
        }
        Button btnMonAn;
        public void btn_clickMonAn(object sender, EventArgs e)
        {
            soLuong++;
            SL.Text = soLuong.ToString();
            try
            {
                kn.moKetNoi();
                //Tìm mã món
                string doc = "select * from MENU";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    btnMonAn = sender as Button;

                    if (btnMonAn.BackColor == Color.White && btnMonAn.Text == rd["TenMon"].ToString())
                    {
                        btnMonAn.BackColor = Color.Yellow;
                        maMon = rd["MaMon"].ToString();
                    }
                }
                kn.DongKetNoi();
            }
            catch
            {
                MessageBox.Show("Vui lòng Kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public void ThemMon(object sender, EventArgs e, string maHD, string sL)
        {
            try
            {
                kn.moKetNoi();
                //Gọi món
                string them = "insert into CTHOADON (MaHD, MaMon, SoLuong) values  ('" + maHD + "', '" + maMon.TrimEnd() + "', " + sL + ")";
                SqlCommand cmd = new SqlCommand(them, kn.conn);
                cmd.ExecuteNonQuery();
                string doc = "Update HOADON set TrangThaiTT =N'Chưa thanh toán' where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                cmd1.ExecuteNonQuery();
                btnMonAn.BackColor = Color.White;
                kn.DongKetNoi();
            }
            catch
            {
                MessageBox.Show("Vui lòng Kiểm tra lại (^-^)", "Thông báo");
                 btnMonAn.BackColor = Color.White;
            }
        }
        public void bn_Huy()
        {
            btnMonAn.BackColor = Color.White;
            soLuong = 0;
        }
      
        public void bn_Xoa(DataGridView daGiv, string maMon, string maHD)
        {
            //kn.moKetNoi();
            //string doc = "select * from CTHOADON where MaMon= '" +   + "'";
            //SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
            //SqlDataReader rd = cmd1.ExecuteReader();
            //while (rd.Read())
            //{
            //}
            //string xoa = "delete CTHOADON where ";
        }
        public void hienThiCBGiamGia(string ngayTaoHD, ComboBox maGia)
        {
            try
            {
                maGia.Items.Clear();
                kn.moKetNoi();
                string doc = "select * from GIAMGIA where NgayGiamGia= '" + ngayTaoHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    maGia.Items.Add(rd["MaGiamGia"].ToString());
                    maGia.SelectedIndex = 0;
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
        }
        public void hienThiLendatagirdview(DataGridView daGiV, string maHD)
        {
            try
            {
                string s = "select  TenMon, DVT , SoLuong,Gia,  ThanhTien from CTHOADON, MENU where MENU.MaMon = CTHOADON.MaMon and MaHD= '" + maHD + "'";
                kn.moKetNoi();
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                kn.DongKetNoi();
                daGiV.DataSource = dt;
            }
            catch
            {
            }
        }
        public void hienThiLendatagirdviewtheoban(DataGridView daGiV, string MaBan, string maHD)
        {
            try
            {
                kn.DongKetNoi();
                string s = "select  TenMon, DVT , SoLuong,Gia,  ThanhTien from CTHOADON, MENU where MENU.MaMon = CTHOADON.MaMon and MaBan= '" + MaBan + "' and MaHD='"+maHD+"'";
                kn.moKetNoi();
                SqlCommand cmd = new SqlCommand(s, kn.conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                kn.DongKetNoi();
                daGiV.DataSource = dt;
            }
            catch
            {
            }
        }
        public string taoHoaDon()
        {
            string maHD = "";
                kn.moKetNoi();
                try
                {
                    
                    string doc = "select * from HOADON";
                    SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    while (rd.Read())
                    {
                        maHD = rd["MaHD"].ToString();
                    }
                    int s = Convert.ToInt32(maHD.Substring(2).TrimEnd());
                    maHD = "HD" + Convert.ToInt32(s + 1);
                }
                catch
                {
                }
                kn.DongKetNoi();
                return maHD;
        }
        public void luuHoaDon(string maHD, string maNV, string maBan, DateTime ngayTao, ComboBox giamGia)
        {
            try
            {
                kn.moKetNoi();
                //lưu hóa đơn
                string them = "";
                if (giamGia.SelectedItem != null)
                {
                    them = "insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT, MaGiamGia) values  ('" + maHD + "', '" + maNV + "', '" + ngayTao + "', '" + maBan + "',0, N'Chưa thanh toán', '" + giamGia.SelectedItem.ToString().TrimEnd() + "')";

                }
                else
                {
                    them = "insert into HOADON(MaHD, MaNV, NgayTao, MaBan, ThanhToan, TrangThaiTT) values  ('" + maHD + "', '" + maNV + "', '" + ngayTao + "', '" + maBan + "',0, N'Chưa thanh toán')";
                }
                SqlCommand cmd = new SqlCommand(them, kn.conn);
                cmd.ExecuteNonQuery();
                btnBan.BackColor = Color.Red;
                MessageBox.Show("Thêm thành công (^-^)", "Thông báo");
                kn.DongKetNoi();

            }
            catch
            {
                MessageBox.Show("Vui lòng Kiểm tra lại (^-^)", "Thông báo");
            }
        }
        public string hienThiThanhTien(string maHD, string thanhTien)
        {
                kn.moKetNoi();
                try
                {
                    string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                    SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    while (rd.Read())
                    {
                        thanhTien = rd["ThanhToan"].ToString();

                    }
                    kn.DongKetNoi();
                }
                catch
                {
                }
                return thanhTien;
        }
      public string hienThiTienThoi(string maHD, string tienThoi)
        {
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    tienThoi = rd["TienThoi"].ToString();

                }
                kn.DongKetNoi();
            }
            catch
            {
            }
            return tienThoi;
        }
      public string hienThiTienNhan(string maHD, string tienNhan)
      {
          kn.moKetNoi();
          try
          {
              string doc = "select * from HOADON where MaHD= '" + maHD + "'";
              SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
              SqlDataReader rd = cmd1.ExecuteReader();
              while (rd.Read())
              {
                  tienNhan = rd["TienNhan"].ToString();
              }
              kn.DongKetNoi();
          }
          catch
          {
          }
          return tienNhan;
      }
        public string hienThiTrangThaiTT(string maHD, string trangThaiTT)
        {
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    trangThaiTT = rd["TrangThaiTT"].ToString();
                }
            }
            catch
            {
            }
            kn.DongKetNoi();
            return trangThaiTT;
        }
        public string hienThiMaGiamGia(string maHD)
        {
            string MaGiamGia = "";
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    MaGiamGia = rd["MaGiamGia"].ToString();
                }
            }
            catch
            {
            }
            kn.DongKetNoi();
            return MaGiamGia;
        }
        public string hienThiMaBan(string maBan, string maHD)
        {
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    maBan = rd["MaBan"].ToString();
                }
            }
            catch
            {
            }
            kn.DongKetNoi();
            return maBan;

        }
        public string hienThiNhanVien(string  maNV, string maHD)
        {
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    maNV = rd["MaNV"].ToString();
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
            return maNV;
        }
        public string hienThiNgayTao(string ngayTao, string maHD)
        {
            kn.moKetNoi();
            try
            {
                string doc = "select * from HOADON where MaHD= '" + maHD + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    ngayTao = rd["NgayTao"].ToString();
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
            return ngayTao;
        }
        public void TinhTien( string maHD, string maBan, ComboBox maGiamGia, float TienNhan)
        {
            try
            {
                //cập nhập trạng tháiTT
                kn.moKetNoi();
                string doc = "Update HOADON set TrangThaiTT =N'Đã thanh toán' where MaHD= '" + maHD + "' and MaBan = '" + maBan + "'";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                cmd1.ExecuteNonQuery();
                //Cập nhập TrangThaiBan
                string doc2 = "Update BAN set TrangThai =N'Bàn Trống' where MaBan = '" + maBan + "'";
                SqlCommand cmd = new SqlCommand(doc2, kn.conn);
                cmd.ExecuteNonQuery();

                string tienNhan = "Update HOADON set TienNhan = " + TienNhan + " where MaHD= '" + maHD + "'";
                SqlCommand cmd2 = new SqlCommand(tienNhan, kn.conn);
                cmd2.ExecuteNonQuery();

                string tienThoi = "Update HOADON set TienThoi = TienNhan - ThanhToan where MaHD= '" + maHD + "'";
                SqlCommand cmd5 = new SqlCommand(tienThoi, kn.conn);
                cmd5.ExecuteNonQuery();
                if (maGiamGia.Items != null)
                {
                    string doc3 = "select * from HOADON, GIAMGIA where HOADON.MaGiamGia = GIAMGIA.MaGiamGia and  MaHD= '" + maHD + "' and HOADON.MaGiamGia = '" + maGiamGia.SelectedItem.ToString().TrimEnd() + "'";
                    SqlCommand cmd3 = new SqlCommand(doc3, kn.conn);
                    SqlDataReader rd3 = cmd3.ExecuteReader();
                    string tien = "";
                    while (rd3.Read())
                    {
                        tien = (float.Parse(rd3["ThanhToan"].ToString()) - float.Parse(rd3["PhanTram"].ToString()) * float.Parse(rd3["ThanhToan"].ToString())).ToString();
                    }
                    //Update lại số tiền
                    kn.DongKetNoi();
                    kn.moKetNoi();
                    string doc4 = "Update HOADON set ThanhToan = " + tien + " where MaHD= '" + maHD + "'";
                    SqlCommand cmd4 = new SqlCommand(doc4, kn.conn);
                    cmd4.ExecuteNonQuery();
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
        }
        public string layMaMon(string tenmon)
        {
            string ma = "";
            kn.moKetNoi();
            try
            {
                string layma = "select * from CThoadon ct,Menu mn where ct.mamon=mn.mamon and tenmon=N'" + tenmon + "'";
                SqlCommand cmd = new SqlCommand(layma, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
              
                while (dr.Read())
                {
                    ma = dr["MaMon"].ToString();
                }
                dr.Close();
            }
            catch
            {
            }
            kn.DongKetNoi();
            return ma;
        }
        public bool sua(string mahdn, string mamonn, int soluongn)
        {
            try
            {
                kn.moKetNoi();
                string update = "update cthoadon set soluong='"+soluongn+"' where mahd='"+mahdn+"' and mamon='"+mamonn+"'";
                SqlCommand cmd = new SqlCommand(update, kn.conn);
                int kq = cmd.ExecuteNonQuery();
                kn.DongKetNoi();
                if (kq > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(string mahd, string mamon)
        {
            try
            {
                kn.moKetNoi();
                string xoa = "delete from cthoadon where mahd='"+mahd+"' and mamon='"+mamon+"'";
                SqlCommand cmd = new SqlCommand(xoa, kn.conn);
                int kq = cmd.ExecuteNonQuery();
                kn.DongKetNoi();
                if (kq > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
