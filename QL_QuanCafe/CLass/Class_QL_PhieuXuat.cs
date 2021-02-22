using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_QuanCafe
{
    class Class_QL_PhieuXuat
    {
        KetNoiCSDL con = new KetNoiCSDL();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        public int layMaMax()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaPX,3,3))) from PHIEUXUAT";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public DataTable LoadNhanVien()
        {
            DataSet ds = new DataSet();
            string loadql = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(loadql, con.conn);
            da.Fill(ds, "NhanVien");
            return ds.Tables["NhanVien"];
        }
        public DataTable LoadPhieuXuat()
        {
            DataSet ds = new DataSet();
            string loadql = "select * from PhieuXuat";
            SqlDataAdapter da = new SqlDataAdapter(loadql, con.conn);
            da.Fill(ds, "PhieuXuat");
            return ds.Tables["PhieuXuat"];
        }
        public bool suaPhieuXuat(string mapx, string Ngayxuat, string manv)
        {
            DataSet ds = new DataSet();
            string load = "select * from PhieuXuat";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "PhieuXuat");
            key[0] = ds.Tables["PhieuXuat"].Columns[0];
            ds.Tables["PhieuXuat"].PrimaryKey = key;
            DataRow update = ds.Tables["PhieuXuat"].Rows.Find(mapx);
            if (update != null)
            {
                update["NgayXuat"] = Ngayxuat;
                update["MaNV"] = manv;
            }
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuXuat");
            return true;
        }
        public bool XoaPX(string mapx)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from PhieuXuat";
                SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
                da.Fill(ds, "PhieuXuat");
                key[0] = ds.Tables["PhieuXuat"].Columns[0];
                ds.Tables["PhieuXuat"].PrimaryKey = key;
                DataRow dele = ds.Tables["PhieuXuat"].Rows.Find(mapx);
                if (dele != null)
                {
                    dele.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "PhieuXuat");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KT_KhoaChinh(string MaPN)
        {
            DataSet ds = new DataSet();
            string load = "select * from PhieuXuat";
            da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "PhieuXuat");
            key[0] = ds.Tables["PhieuXuat"].Columns[0];
            ds.Tables["PhieuXuat"].PrimaryKey = key;
            DataRow drTim = ds.Tables["PhieuXuat"].Rows.Find(MaPN);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool LuuPx(string maPx, string ngayxuat, string manv)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from PhieuXuat";
                SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
                da.Fill(ds, "PhieuXuat");
                DataRow dr = ds.Tables["PhieuXuat"].NewRow();
                dr["MaPX"] = maPx;
                dr["NgayXuat"] = ngayxuat;
                dr["MaNV"] = manv;
                ds.Tables["PhieuXuat"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "PhieuXuat");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadChiTietPX()
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from CTPHIEUXuat";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "CTPHIEUXuat");
            return ds.Tables["CTPHIEUXuat"];
        }
        public DataTable LoaCTPXTheoMa(string mapn)
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from CTPHIEUXuat where MaPX='" + mapn + "'";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "CTPHIEUXuat");
            return ds.Tables["CTPHIEUXuat"];
        }
        //public DataTable LoaCbbNguyenLieuTheoMa(string mapn)
        //{
        //    DataSet ds = new DataSet();
        //    string loadlpn = "select * from CTPHIEUXuat ct,NguyenLieu nl where ct.MaNL=nl.MaNL and MaPX='" + mapn + "'";
        //    SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
        //    da.Fill(ds, "CTPHIEUXuat");
        //    return ds.Tables["CTPHIEUXuat"];
        //}
        public int hienThiSoLuongTon(string maNL)
        {
            int MaGiamGia=0;
            con.moKetNoi();
            try
            {
                string doc = "select * from NGUYENLIEU where MaNL= '" + maNL + "'";
                SqlCommand cmd1 = new SqlCommand(doc, con.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                while (rd.Read())
                {
                    MaGiamGia = int.Parse(rd["SoLuongTon"].ToString());
                }
            }
            catch
            {
            }
            con.DongKetNoi();
            return MaGiamGia;
        }
        public DataTable loaddgvnl()
        {
            DataSet ds = new DataSet();
            string load = "select MaNL,TenNL,DVT,Soluongton,TenLoai,TenNCC from NguyenLieu nl,LoaiMon lm,NhaCungCap ncc where nl.maloai=lm.maloai and nl.mancc=ncc.mancc ";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "NguyenLieu");
            return ds.Tables["NguyenLieu"];
        }
        public bool LuuCTPX(string mapx, string manl, int sl)
        {
            try
            {
                DataSet ds = new DataSet();
                string loadlpn = "select * from CTPHIEUXUAT";
                SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
                da.Fill(ds, "CTPHIEUXUAT");
                DataRow dr = ds.Tables["CTPHIEUXUAT"].NewRow();
                dr["MaPx"] = mapx;
                dr["MaNL"] = manl;
                dr["SoLuong"] = sl;
                ds.Tables["CTPHIEUXUAT"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "CTPHIEUXUAT");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KiemTraKhoaChinhCTPx(string mapx, string manl)
        {
            try
            {
                con.moKetNoi();
                string kt = "select count(*) from CTPHIEUXUAT where MaPX='" + mapx + "' and MaNL='" + manl + "'";
                SqlCommand cmd = new SqlCommand(kt, con.conn);
                int kq = (int)cmd.ExecuteScalar();
                con.DongKetNoi();
                if (kq >= 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoactPX(string mapx, string manl)
        {
            try
            {
                con.moKetNoi();
                string dele = "delete from CTPHIEUXUAT where MaPX='" + mapx + "' and MaNL='" + manl + "' ";
                SqlCommand cmd = new SqlCommand(dele, con.conn);
                int kq = cmd.ExecuteNonQuery();
                con.DongKetNoi();
                if (kq > 0)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool suaChiTietPX(string mapx, string manl, int sl)
        {
            try
            {
                con.moKetNoi();
                string update = "update CTPHIEUXUAT set soluong='" + sl + "' where MaPX='" + mapx + "' and MaNL='" + manl + "' ";
                SqlCommand cmd = new SqlCommand(update, con.conn);
                int kq = cmd.ExecuteNonQuery();
                con.DongKetNoi();
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
