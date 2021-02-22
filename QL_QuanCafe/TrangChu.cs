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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        KetNoiCSDL kn = new KetNoiCSDL();
        private void TrangChu_Load(object sender, EventArgs e)
        {
            try
            {
                kn.moKetNoi();
                string doc = "select TenBan from BAN";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();

                while (rd.Read())
                {
                    Button btn = new Button() { Text = rd["TenBan"].ToString(), BackColor = Color.White,ImageList = imageList1, ImageIndex = 0 , TextImageRelation= TextImageRelation.ImageAboveText};
                    btn.Width = 60; btn.Height = 60;
                    btn.Click += btn_click;
                    flowLayoutPanel1.Controls.Add(btn);
                }
                kn.DongKetNoi();
            }
            catch
            {
            }
            try
            {
                kn.moKetNoi();
                string doc = "select * from MENU";
                SqlCommand cmd1 = new SqlCommand(doc, kn.conn);
                SqlDataReader rd = cmd1.ExecuteReader();
                int dem = 0;
                string hinhanh = "";
               
                while (rd.Read())
                {
                    hinhanh = rd["HinhAnh"].ToString();
                    
                    imageList1.Images.Add(Image.FromFile(hinhanh));
                    Button btn = new Button() { Text = rd["TenMon"].ToString(), BackColor = Color.White, ImageList = imageList1, ImageIndex= dem++, TextImageRelation = TextImageRelation.ImageAboveText };
                    btn.Width = 60; btn.Height = 60;
                    btn.Click += btn_click;
                    flowLayoutPanel2.Controls.Add(btn);
                    
                }
                kn.DongKetNoi();
            }
            catch
            {
            }

        }
        void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Yellow;
                kn.moKetNoi();
                string select = "select * from ban where tenban=N'" + btn.Text + "'";
                SqlCommand cmd= new SqlCommand(select, kn.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    label1.Text = rd["MaBan"].ToString();
                }
                rd.Close();
                kn.DongKetNoi();
            }
            
        }
    }
}
