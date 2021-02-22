using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCafe
{
    public partial class TK_DoanhThu : Form
    {
        public TK_DoanhThu()
        {
            InitializeComponent();
        }
        Class_TK_DoanhThu xl = new Class_TK_DoanhThu();
        private void TK_DoanhThu_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
            crystalReportViewer1.Visible = false;
            button4.Enabled = false;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (maskedTextBox3.TextLength > 0 && maskedTextBox4.TextLength > 0)
            {
                xl.HienThiListViewLuongNV(listView1, maskedTextBox3.Text, maskedTextBox4.Text);
                capNhatDoanhThu(4);
               
            }

            else
            {
                MessageBox.Show("Mời nhập ngày cần thống kê!", "Thông báo");
            }
        }
        public void capNhatDoanhThu(int vt)
        {
            try
            {
                float tongTien = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    tongTien += float.Parse(item.SubItems[vt].Text);
                }
                txtTongTienLuong.Text = tongTien.ToString();
            }
            catch
            {
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (cboxNgayNV.SelectedItem != null && cboxThangNV.SelectedItem != null && cboxNamNV.SelectedItem != null)
            {
                string s = "" + cboxThangNV.SelectedItem.ToString() + "/" + cboxNgayNV.SelectedItem.ToString() + "/" + cboxNamNV.SelectedItem.ToString() + "";
                xl.HienThiListViewNgayLuongNV(listView1, s);
                capNhatDoanhThu(4);
            }
            else if (cboxNgayNV.SelectedItem == null && cboxThangNV.SelectedItem != null && cboxNamNV.SelectedItem != null)
            {
                string s = "" + cboxThangNV.SelectedItem.ToString() + "";
                string s1 = "" + cboxNamNV.SelectedItem.ToString() + "";
                xl.HienThiListViewLuongNV(listView1, s, s1);
                capNhatDoanhThu(4);

            }
            else if (cboxNgayNV.SelectedItem == null && cboxThangNV.SelectedItem == null && cboxNamNV.SelectedItem != null)
            {
                string s = "" + cboxNamNV.SelectedItem.ToString() + "";
                xl.HienThiListViewNgayLuongNV(listView1, s);
                capNhatDoanhThu(4);
            }
        }
        public void Tong()
        {
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells["ThanhToan"].Value.ToString());
            }
            txtTongDT.Text = thanhtien.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboxNgayDT.SelectedItem != null && cboxThangDT.SelectedItem != null && cboxnamDT.SelectedItem != null)
            {
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                string s = "" + cboxThangDT.SelectedItem.ToString() + "/" + cboxNgayDT.SelectedItem.ToString() + "/" + cboxnamDT.SelectedItem.ToString() + "";
                xl.Load_DataGirdViewDoanhThu(dataGridView1, s);
                Tong();

            }
            else if (cboxNgayDT.SelectedItem == null && cboxThangDT.SelectedItem != null && cboxnamDT.SelectedItem != null)
            {
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                string s = "" + cboxThangDT.SelectedItem.ToString() + "";
                string s1 = "" + cboxnamDT.SelectedItem.ToString() + "";
                xl.Load_DataGirdViewThangNamDoanhThu(dataGridView1, s, s1);
                Tong();

            }
            else if (cboxNgayDT.SelectedItem == null && cboxThangDT.SelectedItem == null && cboxnamDT.SelectedItem != null)
            {
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                string s = "" + cboxnamDT.SelectedItem.ToString() + "";
                xl.Load_DataGirdViewDoanhThu(dataGridView1, s);
                Tong();
            }
            else if (maskedTextBox1.TextLength > 0 && maskedTextBox2.TextLength > 0)
            {
                xl.Load_DataGirdViewMaskDoanhThu(dataGridView1, maskedTextBox1.Text, maskedTextBox2.Text);
                Tong();
            }
       }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            xl.Load_DataGirdViewChiTietDoanhThu(dataGridView2, dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;
            Report_BangLuong rpt = new Report_BangLuong();
            ListViewItem item = listView1.FocusedItem;
            rpt.SetParameterValue("MaBangLuong", item.SubItems[1].Text);
            button5.Visible = true;
            crystalReportViewer1.ReportSource = rpt;
            rpt.SetDatabaseLogon("sa", "1810nguyenthanhan", "DESKTOP-0VFU93U\\SQLEXPRESS2012", "QL_QuanCaFe");
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TK_DoanhThu_Load(sender, e);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }
    }
}
