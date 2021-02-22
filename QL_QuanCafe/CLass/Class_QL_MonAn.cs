using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_QuanCafe
{
    class Class_QL_MonAn
    {
        KetNoiCSDL con = new KetNoiCSDL();
        DataColumn[] key = new DataColumn[1];
        public int LayMaMon()
        {
            con.moKetNoi();
            string dem = "select Max(convert(int,SUBSTRING(MaMon,4,4))) from MENU";
            SqlCommand cmd = new SqlCommand(dem, con.conn);
            int kq = (int)cmd.ExecuteScalar();
            con.DongKetNoi();
            return kq;
        }
        public DataTable loadcbbLM()
        {
            DataSet ds = new DataSet();
            string loadcbb = "select * from loaimon";
            SqlDataAdapter da = new SqlDataAdapter(loadcbb, con.conn);
            da.Fill(ds, "LoaiMon");
            return ds.Tables["LoaiMon"];
        }
        public DataTable loaddgvMenu()
        {
            DataSet ds = new DataSet();
            string loadmenu = "select * from menu";
            SqlDataAdapter da = new SqlDataAdapter(loadmenu, con.conn);
            da.Fill(ds, "menu");
            return ds.Tables["menu"];
        }
        public DataTable loadMenuTheoMa(string malm)
        {
            DataSet ds = new DataSet();
            string loadmenu = "select * from menu where maloai='" + malm + "'";
            SqlDataAdapter da = new SqlDataAdapter(loadmenu, con.conn);
            da.Fill(ds, "menu");
            return ds.Tables["menu"];
        }
        public bool kiemTraKCMenu(string mamon)
        {
            DataSet ds = new DataSet();
            string load = "select * from menu";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "menu");
            key[0] = ds.Tables["menu"].Columns[0];
            ds.Tables["menu"].PrimaryKey = key;
            DataRow drTim = ds.Tables["menu"].Rows.Find(mamon);
            if (drTim != null)
            {
                return false;
            }
            return true;
        }
        public bool luuMon(string maMon, string TenMon, string maLoai, string dvt, string hinh, float gia)
        {
            DataSet ds = new DataSet();
            string load = "select * from menu";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "menu");
            DataRow dr = ds.Tables["menu"].NewRow();
            dr["MaMon"] = maMon;
            dr["TenMon"] = TenMon;
            dr["MaLoai"] = maLoai;
            dr["DVT"] = dvt;
            dr["HinhAnh"] = hinh;
            dr["Gia"] = gia;
            ds.Tables["menu"].Rows.Add(dr);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "menu");
            return true;
        }
        public bool suaMon(string MaMon, string TenMon, string maLoai, string dvt, string hinh, float gia)
        {
            DataSet ds = new DataSet();
            string load = "select * from menu";
            SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
            da.Fill(ds, "menu");
            key[0] = ds.Tables["menu"].Columns[0];
            ds.Tables["menu"].PrimaryKey = key;
            DataRow update = ds.Tables["menu"].Rows.Find(MaMon);
            if (update != null)
            {
                update["TenMon"] = TenMon;
                update["MaLoai"] = maLoai;
                update["DVT"] = dvt;
                update["HinhAnh"] = hinh;
                update["Gia"] = gia;
            }
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "menu");
            return true;
        }
        public bool XoaMon(string maMon)
        {
            try
            {
                DataSet ds = new DataSet();
                string load = "select * from menu";
                SqlDataAdapter da = new SqlDataAdapter(load, con.conn);
                da.Fill(ds, "menu");
                key[0] = ds.Tables["menu"].Columns[0];
                ds.Tables["menu"].PrimaryKey = key;
                DataRow dele = ds.Tables["menu"].Rows.Find(maMon);
                if (dele != null)
                {
                    dele.Delete();
                }
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "menu");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
