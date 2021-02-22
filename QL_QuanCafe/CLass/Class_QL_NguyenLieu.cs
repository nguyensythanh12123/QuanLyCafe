using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_QuanCafe
{
    class Class_QL_NguyenLieu
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public DataTable loadcbbncc()
        {
            DataSet ds = new DataSet();
            string load = "select * from nhacungcap";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "nhacungcap");
            return ds.Tables["nhacungcap"];
        }
        public DataTable loadcbbloaimon()
        {
            DataSet ds = new DataSet();
            string load = "select * from LOAIMON";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "loaimon");
            return ds.Tables["loaimon"];
        }
        public DataTable loaddgvnl()
        {
            DataSet ds = new DataSet();
           // string load = "select MaNL,TenNL,DVT,Soluongton,TenLoai,TenNCC from NguyenLieu nl,LoaiMon lm,NhaCungCap ncc where nl.maloai=lm.maloai and nl.mancc=ncc.mancc ";
            string load = "select * from NguyenLieu";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "NguyenLieu");
            return ds.Tables["NguyenLieu"];
        }
        public int LayMaNL()
        {
            kn.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaNL,3,3))) from NguyenLieu";
            SqlCommand cmd = new SqlCommand(dem, kn.conn);
            int kq = (int)cmd.ExecuteScalar();
            kn.DongKetNoi();
            return kq;
        }
        public DataTable loaddgvnltheoncc(string mancc)
        {
            DataSet ds = new DataSet();
            string load = "select MaNL,TenNL,DVT,Soluongton,TenLoai,TenNCC from NguyenLieu nl,LoaiMon lm,NhaCungCap ncc where nl.maloai=lm.maloai and nl.mancc=ncc.mancc and nl.mancc='" + mancc + "' ";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "NguyenLieu");
            return ds.Tables["NguyenLieu"];
        }
        public DataTable loaddgvnltheolm(string manlm)
        {
            DataSet ds = new DataSet();
            string load = "select MaNL,TenNL,DVT,Soluongton,TenLoai,TenNCC from NguyenLieu nl,LoaiMon lm,NhaCungCap ncc where nl.maloai=lm.maloai and nl.mancc=ncc.mancc and nl.maloai='" + manlm + "' ";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "NguyenLieu");
            return ds.Tables["NguyenLieu"];
        }
        public bool kiemTraKCNL(string maNL)
        {
            DataSet ds = new DataSet();
            string load = "select * from NguyenLieu";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "NguyenLieu");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NguyenLieu"].Columns[0];
            ds.Tables["NguyenLieu"].PrimaryKey = key;
            DataRow drTim = ds.Tables["NguyenLieu"].Rows.Find(maNL);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool them(string manl, string tennl, string dvt, int solton, string maloai, string mancc)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NguyenLieu";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NguyenLieu");
                DataRow dr = ds.Tables["NguyenLieu"].NewRow();
                dr["MaNL"] = manl;
                dr["TenNL"] = tennl;
                dr["DVT"] = dvt;
                dr["SoLuongton"] = solton;
                dr["MaLoai"] = maloai;
                dr["MaNCC"] = mancc;
                ds.Tables["NguyenLieu"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NguyenLieu");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(string manl, string tennl, string dvt, int solton, string maloai, string mancc)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NguyenLieu";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NguyenLieu");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["NguyenLieu"].Columns[0];
                ds.Tables["NguyenLieu"].PrimaryKey = key;
                DataRow dr = ds.Tables["NguyenLieu"].Rows.Find(manl);
                if (dr != null)
                {
                    dr["TenNL"] = tennl;
                    dr["DVT"] = dvt;
                    dr["SoLuongton"] = solton;
                    dr["MaLoai"] = maloai;
                    dr["MaNCC"] = mancc;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NguyenLieu");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(string manl)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NguyenLieu";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NguyenLieu");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["NguyenLieu"].Columns[0];
                ds.Tables["NguyenLieu"].PrimaryKey = key;
                DataRow dr = ds.Tables["NguyenLieu"].Rows.Find(manl);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NguyenLieu");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemTraKCNCC(string mancc)
        {
            DataSet ds = new DataSet();
            string load = "select * from NhaCungCap";
            SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
            da.Fill(ds, "NhaCungCap");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhaCungCap"].Columns[0];
            ds.Tables["NhaCungCap"].PrimaryKey = key;
            DataRow drTim = ds.Tables["NhaCungCap"].Rows.Find(mancc);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool themncc(string mancc, string tencc, string diachi, string SDT)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NhaCungCap");
                DataRow dr = ds.Tables["NhaCungCap"].NewRow();
                dr["MaNCC"] = mancc;
                dr["TenNCC"] = tencc;
                dr["DChi"] = diachi;
                dr["DienThoai"] = SDT;
                ds.Tables["NhaCungCap"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suancc(string mancc, string tencc, string diachi, string SDT)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NhaCungCap");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["NhaCungCap"].Columns[0];
                ds.Tables["NhaCungCap"].PrimaryKey = key;
                DataRow dr = ds.Tables["NhaCungCap"].Rows.Find(mancc);
                if (dr != null)
                {
                    dr["TenNCC"] = tencc;
                    dr["DChi"] = diachi;
                    dr["DienThoai"] = SDT;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoancc(string mancc)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(load, kn.conn);
                da.Fill(ds, "NhaCungCap");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["NhaCungCap"].Columns[0];
                ds.Tables["NhaCungCap"].PrimaryKey = key;
                DataRow dr = ds.Tables["NhaCungCap"].Rows.Find(mancc);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
