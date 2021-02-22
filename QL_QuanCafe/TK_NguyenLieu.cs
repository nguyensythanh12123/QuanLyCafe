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
    public partial class TK_NguyenLieu : Form
    {
        public TK_NguyenLieu()
        {
            InitializeComponent();
        }
        Class_Tk_NguyenLieu xl = new Class_Tk_NguyenLieu();
        public void capNhatDoanhThu(int vt)
        {
            float tongTien = 0;
            foreach (ListViewItem item in listView2.Items)
            {
                tongTien += float.Parse(item.SubItems[vt].Text);
            }


            txtTongTienNL.Text = tongTien.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (maskedTextBox3.TextLength > 0 && maskedTextBox4.TextLength > 0)
            {
                xl.load_ListViewNL(listView2, maskedTextBox3.Text, maskedTextBox4.Text);
                capNhatDoanhThu(7);
            }

            else
            {
                MessageBox.Show("Mời nhập ngày cần thống kê!", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (cboxNgay.SelectedIndex > 0 && cboxThang.SelectedIndex > 0 && cboxNam.SelectedIndex > 0)
            {
                string s = "" + cboxThang.SelectedItem.ToString() + "/" + cboxNgay.SelectedItem.ToString() + "/" + cboxNam.SelectedItem.ToString() + "";
                xl.load_ListViewNLCbox(listView2, s);
                capNhatDoanhThu(7);
            }
            else if (cboxNgay.SelectedIndex < 0 && cboxThang.SelectedIndex > 0 && cboxNam.SelectedIndex > 0)
            {
                string s = "" + cboxThang.SelectedItem.ToString() + "";
                string s1 = "" + cboxNam.SelectedItem.ToString() + "";

                xl.load_ListViewNLThangNam(listView2, s, s1);
                capNhatDoanhThu(7);

            }
            else if (cboxNgay.SelectedIndex < 0 && cboxThang.SelectedIndex < 0 && cboxNam.SelectedIndex > 0)
            {
                string s = "" + cboxNam.SelectedItem.ToString() + "";
                xl.load_ListViewNLNam(listView2, s);
                capNhatDoanhThu(7);
            }
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
