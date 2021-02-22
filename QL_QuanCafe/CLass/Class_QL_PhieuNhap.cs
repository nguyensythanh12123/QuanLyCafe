using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_QuanCafe
{
    class Class_QL_PhieuNhap
    {
        KetNoiCSDL con = new KetNoiCSDL();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        //public int demSL()
        //{           
        //        con.moKetNoi();
        //        string dem = "select count(*) from PhieuNhap";
        //        SqlCommand cmd = new SqlCommand(dem,con.connsql);
        //        int kq = (int)cmd.ExecuteScalar();
        //        con.dongKn();
        //        return kq;            
        //}
        public int laymaMax()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaPN,3,3))) from PHIEUNHAP";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public DataTable LoadQuanLy()
        {
            DataSet ds = new DataSet();
            string loadql = "select * from QUANLY";
            SqlDataAdapter da = new SqlDataAdapter(loadql, con.conn);
            da.Fill(ds, "QuanLy");
            return ds.Tables["QuanLy"];

        }
        public DataTable LoadPhieuNhap()
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from PhieuNhap";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "PhieuNhap");
            return ds.Tables["PhieuNhap"];
        }
        public DataTable LoaCTPNTheoMa(string mapn)
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from CTPHIEUNHAP where MaPN='" + mapn + "'";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "CTPHIEUNHAP");
            return ds.Tables["CTPHIEUNHAP"];
        }
        public bool suaPhieuNhap(string mapn, string NgayNhap, string maQL)
        {
            DataSet ds = new DataSet();
            string load = "select * from PhieuNhap";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "PhieuNhap");
            key[0] = ds.Tables["PhieuNhap"].Columns[0];
            ds.Tables["PhieuNhap"].PrimaryKey = key;
            DataRow update = ds.Tables["PhieuNhap"].Rows.Find(mapn);
            if (update != null)
            {
                update["NgayNhap"] = NgayNhap;
                update["MaQL"] = maQL;
            }
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuNhap");
            return true;
        }
        public bool XoaPN(string mapn)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from PhieuNhap";
                SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
                da.Fill(ds, "PhieuNhap");
                key[0] = ds.Tables["PhieuNhap"].Columns[0];
                ds.Tables["PhieuNhap"].PrimaryKey = key;
                DataRow dele = ds.Tables["PhieuNhap"].Rows.Find(mapn);
                if (dele != null)
                {
                    dele.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "PhieuNhap");
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public DataTable LoaCbbNguyenLieuTheoMa(string mapn)
        //{
        //    DataSet ds = new DataSet();
        //    string loadlpn = "select * from CTPHIEUNHAP ct,NguyenLieu nl where ct.MaNL=nl.MaNL and MaPN='" + mapn + "'";
        //    SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
        //    da.Fill(ds, "CTPHIEUNHAP");
        //    return ds.Tables["CTPHIEUNHAP"];
        //}
        public DataTable LoadNguyenLieu()
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from NguyenLieu";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "NguyenLieu");
            return ds.Tables["NguyenLieu"];
        }
        public DataTable LoadChiTietPN()
        {
            DataSet ds = new DataSet();
            string loadlpn = "select * from CTPHIEUNHAP";
            SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
            da.Fill(ds, "ChiTietPN");
            return ds.Tables["ChiTietPN"];
        }
        public bool KT_KhoaChinh(string MaPN)
        {
            DataSet ds = new DataSet();
            string load = "select * from PhieuNhap";
            da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "PhieuNhap");
            key[0] = ds.Tables["PhieuNhap"].Columns[0];
            ds.Tables["PhieuNhap"].PrimaryKey = key;
            DataRow drTim = ds.Tables["PhieuNhap"].Rows.Find(MaPN);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool LuuPN(string maPN, string ngayNhap, string maQl, float TienNhap)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from PhieuNhap";
                SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
                da.Fill(ds, "PhieuNhap");
                DataRow dr = ds.Tables["PhieuNhap"].NewRow();
                dr["MaPN"] = maPN;
                dr["NgayNhap"] = ngayNhap;
                dr["MaQL"] = maQl;
                dr["TienNhap"] = TienNhap;
                ds.Tables["PhieuNhap"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "PhieuNhap");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool LuuCTPN(string mapn, string manl, int sl, float donGia)
        {
            try
            {
                DataSet ds = new DataSet();
                string loadlpn = "select * from CTPHIEUNHAP";
                SqlDataAdapter da = new SqlDataAdapter(loadlpn, con.conn);
                da.Fill(ds, "ChiTietPN");
                DataRow dr = ds.Tables["ChiTietPN"].NewRow();
                dr["MaPN"] = mapn;
                dr["MaNL"] = manl;
                dr["SoLuong"] = sl;
                dr["DonGia"] = donGia;
                ds.Tables["ChiTietPN"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "ChiTietPN");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KiemTraKhoaChinhCTPN(string mapn, string manl)
        {
            try
            {
                con.moKetNoi();
                string kt = "select count(*) from CTPHIEUNHAP where MaPN='" + mapn + "' and MaNL='" + manl + "'";
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
        public bool xoacthd(string mapn, string manl)
        {
            try
            {
                con.moKetNoi();
                string dele = "delete from ctphieunhap where MaPN='" + mapn + "' and MaNL='" + manl + "' ";
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
        public bool suaChiTietPN(string mapn, string manl, int sl, float dongia)
        {
            try
            {
                con.moKetNoi();
                string update = "update ctPhieuNhap set soluong='" + sl + "',dongia='" + dongia + "' where MaPN='" + mapn + "' and MaNL='" + manl + "' ";
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
