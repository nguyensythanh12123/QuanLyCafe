using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_QuanCafe
{
    class Class_QL_Ban_KhuyenMai
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public DataTable loaddgv()
        {
            DataSet ds = new DataSet();
            string load = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "Ban");
            return ds.Tables["Ban"];
        }
        public bool kiemTraKCBan(string maBan)
        {
            DataSet ds = new DataSet();
            string load = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "Ban");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Ban"].Columns[0];
            ds.Tables["Ban"].PrimaryKey = key;
            DataRow drTim = ds.Tables["Ban"].Rows.Find(maBan);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool them(string maban, string tenban, int slc)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from Ban";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "Ban");
                DataRow dr = ds.Tables["Ban"].NewRow();
                dr["MaBan"] = maban;
                dr["TenBan"] = tenban;
                dr["SoCho"] = slc;
                dr["TrangThai"] = "Bàn Trống";
                ds.Tables["Ban"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "Ban");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(string maban, string tenban, int slc)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from Ban";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "Ban");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["Ban"].Columns[0];
                ds.Tables["Ban"].PrimaryKey = key;
                DataRow dr = ds.Tables["Ban"].Rows.Find(maban);
                if (dr != null)
                {
                    dr["MaBan"] = maban;
                    dr["TenBan"] = tenban;
                    dr["SoCho"] = slc;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "Ban");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(string ma)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from Ban";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "Ban");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["Ban"].Columns[0];
                ds.Tables["Ban"].PrimaryKey = key;
                DataRow dr = ds.Tables["Ban"].Rows.Find(ma);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "Ban");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int laymaMax()
        {
            kn.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaBan,4,4))) from Ban";
            SqlCommand cmd = new SqlCommand(dem, kn.conn);
            int kq = (int)cmd.ExecuteScalar();
            kn.DongKetNoi();
            return kq;
        }
        //Khuyễn mãi
        public DataTable loaddgvKM()
        {
            DataSet ds = new DataSet();
            string load = "select * from GIAMGIA";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "GIAMGIA");
            return ds.Tables["GIAMGIA"];
        }
        public bool kiemTraKCGiamGia(string maGG)
        {
            DataSet ds = new DataSet();
            string load = "select * from GIAMGIA";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "GIAMGIA");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["GIAMGIA"].Columns[0];
            ds.Tables["GIAMGIA"].PrimaryKey = key;
            DataRow drTim = ds.Tables["GIAMGIA"].Rows.Find(maGG);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public int laymaMaGG()
        {
            kn.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaGiamGia,3,3))) from GIAMGIA";
            SqlCommand cmd = new SqlCommand(dem, kn.conn);
            int kq = (int)cmd.ExecuteScalar();
            kn.DongKetNoi();
            return kq;
        }
        public bool themGIAMGIA(string maGiamGia, string ngayTao, string phanTram)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from GIAMGIA";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "GIAMGIA");
                DataRow dr = ds.Tables["GIAMGIA"].NewRow();
                dr["MaGiamGia"] = maGiamGia;
                dr["NgayGiamGia"] = ngayTao;
                dr["phanTram"] = phanTram;
                ds.Tables["GIAMGIA"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "GIAMGIA");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaGiamGia(string maGG, string ngay, string phanTram)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from GIAMGIA";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "GIAMGIA");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["GIAMGIA"].Columns[0];
                ds.Tables["GIAMGIA"].PrimaryKey = key;
                DataRow dr = ds.Tables["GIAMGIA"].Rows.Find(maGG);
                if (dr != null)
                {
                    dr["MaGiamGia"] = maGG;
                    dr["NgayGiamGia"] = ngay;
                    dr["PhanTram"] = phanTram;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "GIAMGIA");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaGG(string maGG)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from GIAMGIA";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "GIAMGIA");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["GIAMGIA"].Columns[0];
                ds.Tables["GIAMGIA"].PrimaryKey = key;
                DataRow dr = ds.Tables["GIAMGIA"].Rows.Find(maGG);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "GIAMGIA");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
