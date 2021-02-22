using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_QuanCafe
{
    class Class_QL_LuongNhanVien
    {
        KetNoiCSDL con = new KetNoiCSDL();
        public DataTable loadBangLuong()
        {
            DataSet ds = new DataSet();
            string load = "select * from BangLuong";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "BangLuong");
            return ds.Tables["BangLuong"];
        }
        public DataTable loadCaLam()
        {
            DataSet ds = new DataSet();
            string load = "select * from CaLam";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "CaLam");
            return ds.Tables["CaLam"];
        }
        public DataTable loadNhanVien()
        {
            DataSet ds = new DataSet();
            string load = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "NhanVien");
            return ds.Tables["NhanVien"];
        }
        public DataTable loadLuongnv()
        {
            DataSet ds = new DataSet();
            string load = "select MaBL,TenNV,NgayPhatLuong,Luong  from LuongNV bl,nhanvien nv where bl.manv=nv.manv ";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "Luongnv");
            return ds.Tables["Luongnv"];
        }
        public DataTable loadctLuongnv()
        {
            DataSet ds = new DataSet();
            string load = "select mabl,tennv,chitietca,ngaylam,sotien,thanhtien  from calam cl,nhanvien nv,ctBangLuong ct where cl.Maca=ct.maca and nv.manv=ct.manv";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "Luongnv");
            return ds.Tables["Luongnv"];
        }
        public bool kiemTraKhoaChinhluongnv(string mabl, string manv)
        {
            try
            {
                con.moKetNoi();
                string kt = "select count(*) from luongnv where mabl='" + mabl + "' and manv='" + manv + "' ";
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
        public bool luuluongnv(string mabl, string manv, string ngaypl, float luong)
        {
            try
            {
                DataSet ds = new DataSet();
                string luu = "select * from luongnv ";
                SqlDataAdapter da = new SqlDataAdapter(luu, con.conn);
                da.Fill(ds, "Luongnv");
                DataRow dr = ds.Tables["Luongnv"].NewRow();
                dr["MaBL"] = mabl;
                dr["MaNV"] = manv;
                dr["NgayPhatLuong"] = ngaypl;
                dr["Luong"] = luong;
                ds.Tables["Luongnv"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "Luongnv");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sualuongnv(string mabl, string manv, string ngaypl, float luong)
        {
            try
            {
                con.moKetNoi();
                string sua = "update luongnv set ngayphatluong='" + ngaypl + "',luong='" + luong + "' where mabl='" + mabl + "' and manv='" + manv + "' ";
                SqlCommand cmd = new SqlCommand(sua, con.conn);
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
        public bool xoaluongnv(string mabl, string manv)
        {
            try
            {
                con.moKetNoi();
                string xoa = "delete from luongnv where mabl='" + mabl + "' and manv='" + manv + "' ";
                SqlCommand cmd = new SqlCommand(xoa, con.conn);
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
        public DataTable loadctLuongTheoMa(string mabl, string manv)
        {
            DataSet ds = new DataSet();
            string load = "select mabl,tennv,chitietca,ngaylam,sotien,thanhtien  from calam cl,nhanvien nv,ctBangLuong ct where cl.Maca=ct.maca and nv.manv=ct.manv and ct.mabl='" + mabl + "' and ct.manv='" + manv + "'";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "Luongnv");
            return ds.Tables["Luongnv"];
        }

        public bool ktKhoaCtBangLuong(string mabl, string manv, string maca, string ngaylam)
        {
            try
            {
                con.moKetNoi();
                string kt = "select count(*) from ctbangluong where mabl='" + mabl + "' and manv='" + manv + "' and maca='" + maca + "' and ngaylam='" + ngaylam + "' ";
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
        public bool themctLuongnv(string mabl, string manv, string maca, string ngaylam, float sotien)
        {
            DataSet ds = new DataSet();
            string themct = "select * from ctbangluong ";
            SqlDataAdapter da = new SqlDataAdapter(themct, con.conn);
            da.Fill(ds, "ctbangluong");
            DataRow dr = ds.Tables["ctbangluong"].NewRow();
            dr["MaBL"] = mabl;
            dr["MaNV"] = manv;
            dr["MaCa"] = maca;
            string ngayS = DateTime.Parse(ngaylam.ToString()).ToString("dd/MM/yyyy");
            dr["NgayLam"] = ngayS;
            dr["sotien"] = sotien;
            ds.Tables["ctbangluong"].Rows.Add(dr);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "ctbangluong");
            return true;
        }
        public string layMaCa(string ctca)
        {
            con.moKetNoi();
            string maca = "";
            string select = "select * from calam where chitietca=N'" + ctca + "'";
            SqlCommand cmd = new SqlCommand(select, con.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                maca = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.DongKetNoi();
            return maca;
        }
        public bool xoactLuongnv(string mabl, string manv, string maca, string ngaylam)
        {
            try
            {
                con.moKetNoi();
                string delete = "delete from ctbangluong where MaBL='" + mabl + "' and MaNV='" + manv + "' and MaCa='" + maca + "' and NgayLam='" + ngaylam + "' ";
                SqlCommand cmd = new SqlCommand(delete, con.conn);
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
        public int demngaylv(string mabl, string manv)
        {
            try
            {

                con.moKetNoi();
                string dem = "select sum(sotieng) from CALAM cl,CTBANGLUONG ct where cl.MaCa=ct.MaCa and MaBL='" + mabl + "' and MaNV='" + manv + "' ";
                SqlCommand cmd = new SqlCommand(dem, con.conn);
                int kq = (int)cmd.ExecuteScalar();
                con.DongKetNoi();
                return kq;
            }
            catch
            {
                return 0;
            }
        }
        public int LayMaNL()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaBL,3,3))) from BANGLUONG";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public bool LuuBangNV()
        {
            string maBL, TenBL;
            DataSet ds = new DataSet();
            int kq = LayMaNL();
            kq++;
            maBL = "BL0" + kq.ToString();
            TenBL = kq.ToString();
            string load = "select * from BANGLUONG";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "BANGLUONG");
            DataRow dr = ds.Tables["BANGLUONG"].NewRow();
            dr["MaBL"] = maBL;
            dr["TenBL"] = "Bảng Lương " + TenBL + "";
            ds.Tables["BANGLUONG"].Rows.Add(dr);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "BANGLUONG");
            return true;
           
        }
    }
}
