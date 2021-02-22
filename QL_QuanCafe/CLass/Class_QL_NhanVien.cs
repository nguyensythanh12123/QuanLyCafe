using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_QuanCafe
{
    class Class_QL_NhanVien
    {
        KetNoiCSDL con = new KetNoiCSDL();
        DataColumn[] key = new DataColumn[1];
        public int layMaNV()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaNV,3,3))) from NhanVien";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public int layMaQuanLy()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaQL,3,3))) from QuanLy";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public DataTable loadNhaQL()
        {
            DataSet ds = new DataSet();
            string loadql = "select * from QuanLy ";
            SqlDataAdapter da = new SqlDataAdapter(loadql, con.conn);
            da.Fill(ds, "QuanLy");
            return ds.Tables["QuanLy"];
        }
        public DataTable loadBP()
        {
            DataSet ds = new DataSet();
            string loadbp = "select * from BoPhan ";
            SqlDataAdapter da = new SqlDataAdapter(loadbp, con.conn);
            da.Fill(ds, "BoPhan");
            return ds.Tables["BoPhan"];
        }
        public DataTable loadNV()
        {
            DataSet ds = new DataSet();
           // string loadnv = "select MaNV,TenNV,nv.NgaySinh,nv.GioiTinh,DiaChi,nv.SDT,NgayVaoLam,TenQL,TenBP,MatKhauDN from NhanVien nv,BoPhan bp,QuanLy ql where bp.MaBP=nv.MaBP and ql.MaQL=nv.MaQL";
            string loadnv = "select * from NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(loadnv, con.conn);
            da.Fill(ds, "NhanVien");
            return ds.Tables["NhanVien"];
        }
        public DataTable loadNVtheoql(string maql)
        {
            DataSet ds = new DataSet();
            string loadnv = "select MaNV,TenNV,nv.NgaySinh,nv.GioiTinh,DiaChi,nv.SDT,NgayVaoLam,TenQL,TenBP,MatKhauDN from NhanVien nv,BoPhan bp,QuanLy ql where bp.MaBP=nv.MaBP and ql.MaQL=nv.MaQL and nv.maql='" + maql + "'";
            SqlDataAdapter da = new SqlDataAdapter(loadnv, con.conn);
            da.Fill(ds, "NhanVien");
            return ds.Tables["NhanVien"];
        }
        public DataTable loadNVtheobp(string mabp)
        {
            DataSet ds = new DataSet();
            string loadnv = "select MaNV,TenNV,nv.NgaySinh,nv.GioiTinh,DiaChi,nv.SDT,NgayVaoLam,TenQL,TenBP,MatKhauDN from NhanVien nv,BoPhan bp,QuanLy ql where bp.MaBP=nv.MaBP and ql.MaQL=nv.MaQL and nv.mabp='" + mabp + "'";
            SqlDataAdapter da = new SqlDataAdapter(loadnv, con.conn);
            da.Fill(ds, "NhanVien");
            return ds.Tables["NhanVien"];
        }
        public bool kiemTraKhoaChinh(string manv)
        {
            DataSet ds = new DataSet();
            string load = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "NhanVien");
            key[0] = ds.Tables["NhanVien"].Columns[0];
            ds.Tables["NhanVien"].PrimaryKey = key;
            DataRow drTim = ds.Tables["NhanVien"].Rows.Find(manv);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool themNhanVien(string manv, string tennv, string ngaysinh, string gioitinh, string diachi, string sdt, string ngayvl, string maql, string mabp, string mk)
        {
            try
            {
                DataSet ds = new DataSet();
                string them = "select * from nhanvien";
                SqlDataAdapter da = new SqlDataAdapter(them, con.conn);
                da.Fill(ds, "NhanVien");
                DataRow dr = ds.Tables["NhanVien"].NewRow();
                dr["MaNV"] = manv;
                dr["TenNV"] = tennv;
                string ngayS = DateTime.Parse(ngaysinh.ToString()).ToString("dd/MM/yyyy");
                dr["NgaySinh"] = ngayS;
                dr["GioiTinh"] = gioitinh;
                dr["DiaChi"] = diachi;
                dr["SDT"] = sdt;
                string ngaylm = DateTime.Parse(ngayvl.ToString()).ToString("dd/MM/yyyy");
                dr["NgayVaoLam"] = ngayvl;
                dr["MaQL"] = maql;
                dr["MaBP"] = mabp;
                dr["MatKhauDN"] = mk;
                ds.Tables["NhanVien"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suanv(string manv, string tennv, string ngaysinh, string gioitinh, string diachi, string sdt, string ngayvl, string maql, string mabp, string mk)
        {
            try
            {
                DataSet ds = new DataSet();
                string sua = "select * from NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sua, con.conn);
                da.Fill(ds, "NhanVien");
                key[0] = ds.Tables["NhanVien"].Columns[0];
                ds.Tables["NhanVien"].PrimaryKey = key;
                DataRow dr = ds.Tables["NhanVien"].Rows.Find(manv);
                if (dr != null)
                {
                    dr["TenNV"] = tennv;
                    string ngayS = DateTime.Parse(ngaysinh.ToString()).ToString("dd/MM/yyyy");
                    dr["NgaySinh"] = ngayS;
                    dr["GioiTinh"] = gioitinh;
                    dr["DiaChi"] = diachi;
                    dr["SDT"] = sdt;
                    string ngay = DateTime.Parse(ngayvl.ToString()).ToString("dd/MM/yyyy");
                    dr["NgayVaoLam"] = ngay;
                    dr["MaQL"] = maql;
                    dr["MaBP"] = mabp;
                    dr["MatKhauDN"] = mk;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoanv(string manv)
        {
            try
            {
                DataSet ds = new DataSet();
                string xoa = "select * from NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(xoa, con.conn);
                da.Fill(ds, "NhanVien");
                key[0] = ds.Tables["NhanVien"].Columns[0];
                ds.Tables["NhanVien"].PrimaryKey = key;
                DataRow dr = ds.Tables["NhanVien"].Rows.Find(manv);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool kiemTraKCQL(string maql)
        {
            DataSet ds = new DataSet();
            string load = "select * from QuanLy";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "QuanLy");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["QuanLy"].Columns[0];
            ds.Tables["QuanLy"].PrimaryKey = key;
            DataRow drTim = ds.Tables["QuanLy"].Rows.Find(maql);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool themQL(string maql, string tenql, string ngaysinh, string gt, string sdt, string mk)
        {
            try
            {
                DataSet ds = new DataSet();
                string them = "select * from QuanLy";
                SqlDataAdapter da = new SqlDataAdapter(them, con.conn);
                da.Fill(ds, "QuanLy");
                DataRow dr = ds.Tables["QuanLy"].NewRow();
                dr["MaQL"] = maql;
                dr["TenQL"] = tenql;
                string ngayS = DateTime.Parse(ngaysinh.ToString()).ToString("dd/MM/yyyy");
                dr["NgaySinh"] = ngayS;
                dr["GioiTinh"] = gt;
                dr["SDT"] = sdt;
                dr["MatKhau"] = mk;
                ds.Tables["QuanLy"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "QuanLy");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaQL(string maql, string tenql, string ngaysinh, string gt, string sdt, string mk)
        {
            try
            {
                DataSet ds = new DataSet();
                string sua = "select * from QuanLy";
                SqlDataAdapter da = new SqlDataAdapter(sua, con.conn);
                da.Fill(ds, "QuanLy");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["QuanLy"].Columns[0];
                ds.Tables["QuanLy"].PrimaryKey = key;
                DataRow dr = ds.Tables["QuanLy"].Rows.Find(maql);
                if (dr != null)
                {
                    dr["TenQL"] = tenql;
                    string ngayS = DateTime.Parse(ngaysinh.ToString()).ToString("dd/MM/yyyy");
                    dr["NgaySinh"] = ngayS;
                    dr["GioiTinh"] = gt;
                    dr["SDT"] = sdt;
                    dr["MatKhau"] = mk;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "QuanLy");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaql(string maql)
        {
            try
            {
                DataSet ds = new DataSet();
                string xoa = "select * from QuanLy";
                SqlDataAdapter da = new SqlDataAdapter(xoa, con.conn);
                da.Fill(ds, "QuanLy");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["QuanLy"].Columns[0];
                ds.Tables["QuanLy"].PrimaryKey = key;
                DataRow dr = ds.Tables["QuanLy"].Rows.Find(maql);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "QuanLy");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool kiemTraKCBP(string mabp)
        {
            DataSet ds = new DataSet();
            string ktkc = "select * from BoPhan";
            SqlDataAdapter da = new SqlDataAdapter(ktkc, con.conn);
            da.Fill(ds, "BoPhan");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["BoPhan"].Columns[0];
            ds.Tables["BoPhan"].PrimaryKey = key;
            DataRow drTim = ds.Tables["BoPhan"].Rows.Find(mabp);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool themBP(string mabp, string tenbp)
        {
            try
            {
                DataSet ds = new DataSet();
                string them = "select * from BoPhan";
                SqlDataAdapter da = new SqlDataAdapter(them, con.conn);
                da.Fill(ds, "BoPhan");
                DataRow dr = ds.Tables["BoPhan"].NewRow();
                dr["MaBP"] = mabp;
                dr["TenBP"] = tenbp;
                ds.Tables["BoPhan"].Rows.Add(dr);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "BoPhan");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaBP(string mabp, string tenbp)
        {
            try
            {
                DataSet ds = new DataSet();
                string sua = "select * from BoPhan";
                SqlDataAdapter da = new SqlDataAdapter(sua, con.conn);
                da.Fill(ds, "BoPhan");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["BoPhan"].Columns[0];
                ds.Tables["BoPhan"].PrimaryKey = key;
                DataRow dr = ds.Tables["BoPhan"].Rows.Find(mabp);
                if (dr != null)
                {
                    dr["TenBP"] = tenbp;
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "BoPhan");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoabp(string mabp)
        {
            try
            {
                DataSet ds = new DataSet();
                string xoa = "select * from BoPhan";
                SqlDataAdapter da = new SqlDataAdapter(xoa, con.conn);
                da.Fill(ds, "BoPhan");
                DataColumn[] key = new DataColumn[1];
                key[0] = ds.Tables["BoPhan"].Columns[0];
                ds.Tables["BoPhan"].PrimaryKey = key;
                DataRow dr = ds.Tables["BoPhan"].Rows.Find(mabp);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "BoPhan");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
