using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QL_QuanCafe
{
    public partial class QL_MonAn : Form
    {
        public QL_MonAn()
        {
            InitializeComponent();
        }
        Class_QL_MonAn xlmon = new Class_QL_MonAn();
        private void QL_MonAn_Load(object sender, EventArgs e)
        {
            MaLoai.DataSource = xlmon.loadcbbLM();
            MaLoai.DisplayMember = "TenLoai";
            MaLoai.ValueMember = "MaLoai";
            cbb_LoaiMon.DataSource = xlmon.loadcbbLM();
            cbb_LoaiMon.DisplayMember = "TenLoai";
            cbb_LoaiMon.ValueMember = "MaLoai";
            dgv_Menu.DataSource = xlmon.loaddgvMenu();
            cbb_LoaiMon.SelectedIndex = 1;
            txt_MaMon.Enabled = false;
            btn_Luumon.Enabled = false;
            btn_XoaMon.Enabled = false;
            btn_Themmon.Enabled = true;
        }

        private void cbb_LoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiMon.SelectedIndex >= 0)
            {
                dgv_Menu.DataSource = xlmon.loadMenuTheoMa(cbb_LoaiMon.SelectedValue.ToString());
            }
        }

        private void dgv_Menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaMon.Text = dgv_Menu.CurrentRow.Cells[0].Value.ToString();
                txt_TenMon.Text = dgv_Menu.CurrentRow.Cells[1].Value.ToString();
                cbb_LoaiMon.SelectedValue = dgv_Menu.CurrentRow.Cells[2].Value.ToString();
                txt_Dvt.Text = dgv_Menu.CurrentRow.Cells[3].Value.ToString();
                txt_HinhAnh.Text = dgv_Menu.CurrentRow.Cells[4].Value.ToString();
                txt_Gia.Text = dgv_Menu.CurrentRow.Cells[5].Value.ToString();
                btn_Luumon.Enabled = true;
                btn_Themmon.Enabled = false;
                btn_XoaMon.Enabled = true;
                txt_MaMon.Enabled = false;
                pictureBox1.Image = Image.FromFile(dgv_Menu.CurrentRow.Cells[4].Value.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
            }
        }

        private void btn_Themmon_Click(object sender, EventArgs e)
        {
            txt_MaMon.Enabled = false;
            btn_Luumon.Enabled = true;
            btn_Themmon.Enabled = false;
            txt_Dvt.Clear(); txt_Gia.Clear(); txt_HinhAnh.Clear(); txt_TenMon.Clear();
        }

        private void btn_Luumon_Click(object sender, EventArgs e)
        {
            if (xlmon.kiemTraKCMenu(txt_MaMon.Text))
            {
                if (txt_TenMon.Text == string.Empty || cbb_LoaiMon.SelectedIndex < 0 || txt_MaMon.Text == string.Empty || txt_Gia.Text == string.Empty || txt_Dvt.Text == string.Empty)
                {
                    MessageBox.Show("Mời Bạn Nhập và chọn Dữ Liệu");
                }
                else
                {
                    if (xlmon.kiemTraKCMenu(txt_MaMon.Text))
                    {
                        if (xlmon.luuMon(txt_MaMon.Text, txt_TenMon.Text, cbb_LoaiMon.SelectedValue.ToString(), txt_Dvt.Text, txt_HinhAnh.Text, float.Parse(txt_Gia.Text)))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            QL_MonAn_Load(sender, e);
                            btn_Luumon.Enabled = false;
                            btn_Themmon.Enabled = true;
                            txt_MaMon.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Đã Tồn Tại");
                    }
                }

            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaMon.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        if (xlmon.suaMon(txt_MaMon.Text, txt_TenMon.Text, cbb_LoaiMon.SelectedValue.ToString(), txt_Dvt.Text, txt_HinhAnh.Text, float.Parse(txt_Gia.Text)))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            QL_MonAn_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }
        }

        private void btn_XoaMon_Click(object sender, EventArgs e)
        {
            if (txt_MaMon.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlmon.XoaMon(txt_MaMon.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                    QL_MonAn_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa món đó được");
                    }
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                if (xlmon.XoaMon(dgv_Menu.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dgv_Menu.DataSource = xlmon.loaddgvMenu();
                }
                else
                {
                    MessageBox.Show("Không thể xóa món đó được");
                }
            }
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mamon = dgv_Menu.CurrentRow.Cells[0].Value.ToString();
            string tenmon = dgv_Menu.CurrentRow.Cells[1].Value.ToString();
            string maloai = dgv_Menu.CurrentRow.Cells[2].Value.ToString();
            string dvt = dgv_Menu.CurrentRow.Cells[3].Value.ToString();
            string hinh = dgv_Menu.CurrentRow.Cells[4].Value.ToString();
            float gia = float.Parse(dgv_Menu.CurrentRow.Cells[5].Value.ToString());
            if (mamon == string.Empty || tenmon == string.Empty || maloai == string.Empty || dvt == string.Empty)
            {
                MessageBox.Show("Mời Bạn Nhập vào");
            }
            else
            {
                if (xlmon.suaMon(mamon, tenmon, maloai, dvt, hinh, gia))
                {
                    MessageBox.Show("Sửa Thành Công");
                    QL_MonAn_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void QL_MonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Chắc Chắn Muốn Đóng Form Không?", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_Gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        RichTextBox richtex = new RichTextBox();
        private void Bn_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_HinhAnh.Text = openFileDialog1.FileName;
                StreamReader f = new StreamReader(openFileDialog1.FileName);
                richtex.Text = f.ReadToEnd();
                f.Close();
            }
            pictureBox1.Image = Image.FromFile(txt_HinhAnh.Text);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_TaoMa_Click(object sender, EventArgs e)
        {
            int kq = xlmon.LayMaMon();
            kq++;
            txt_MaMon.Text = "MON" + kq.ToString();
            btn_Themmon.Enabled = true;
            //btn_TaoMa.Enabled = false;
            btn_Luumon.Enabled = false;
            txt_MaMon.Enabled = false;
        }
    }
}
