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
    public partial class QL_Ban_KhuyenMai : Form
    {
        public QL_Ban_KhuyenMai()
        {
            InitializeComponent();
        }
        Class_QL_Ban_KhuyenMai xlban = new Class_QL_Ban_KhuyenMai();
        private void QL_Ban_KhuyenMai_Load(object sender, EventArgs e)
        {
            Width = 780;
            dGVGiamGia.ReadOnly = true;
            dGVGiamGia.AllowUserToAddRows = false;
            dgv_Ban.ReadOnly = true;
            dgv_Ban.AllowUserToAddRows = false;
            dgv_Ban.DataSource = xlban.loaddgv();
            txt_MaBan.Enabled = txt_SoCho.Enabled = txt_TenBan.Enabled = txt_TrangThai.Enabled = btn_ThemBan.Enabled = btn_XoaBan.Enabled = btn_Luuban.Enabled = false;
            dGVGiamGia.DataSource = xlban.loaddgvKM();
            txt_MaGiamGia.Enabled = txt_PhanTram.Enabled = bn_LuuGG.Enabled = bn_XoaGG.Enabled = bn_ThemGG.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_TaoMa_Click(object sender, EventArgs e)
        {
            int kq = xlban.laymaMax();
            kq++;
            txt_MaBan.Text = "MB0" + kq.ToString();
            btn_ThemBan.Enabled = true;
            //btn_TaoMa.Enabled = false;
            bn_LuuGG.Enabled = false;
        }

        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            dgv_Ban.AllowUserToAddRows = true;
            dgv_Ban.ReadOnly = false;
            for (int i = 0; i < dgv_Ban.Rows.Count - 1; i++)
            {
                dgv_Ban.Rows[i].ReadOnly = true;
            }
            btn_Luuban.Enabled = true;
            txt_SoCho.Clear();
            txt_SoCho.Enabled = txt_TenBan.Enabled = true;
            txt_TenBan.Clear();
            txt_TrangThai.Clear();
            btn_ThemBan.Enabled = false;
        }

        private void dgv_Ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaBan.Text = dgv_Ban.CurrentRow.Cells[0].Value.ToString();
            txt_TenBan.Text = dgv_Ban.CurrentRow.Cells[1].Value.ToString();
            txt_SoCho.Text = dgv_Ban.CurrentRow.Cells[2].Value.ToString();
            txt_TrangThai.Text = dgv_Ban.CurrentRow.Cells[3].Value.ToString();
            btn_XoaBan.Enabled = btn_Luuban.Enabled = true;
            txt_SoCho.Enabled = txt_TenBan.Enabled = true;
        }

        private void btn_Luuban_Click(object sender, EventArgs e)
        {
            if (xlban.kiemTraKCBan(txt_MaBan.Text))
            {
                if (txt_MaBan.Text == string.Empty || txt_SoCho.Text == string.Empty || txt_TenBan.Text == string.Empty)
                {
                    MessageBox.Show("Mời Bạn Nhập đầy đủ thuộc tính nha");
                }
                else
                {
                    if (xlban.kiemTraKCBan(txt_MaBan.Text))
                    {
                        if (xlban.them(txt_MaBan.Text, txt_TenBan.Text, int.Parse(txt_SoCho.Text)))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            dgv_Ban.DataSource = xlban.loaddgv();
                            txt_SoCho.Clear();
                            txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                            txt_TenBan.Clear();
                            txt_TrangThai.Clear();
                            txt_MaBan.Clear();
                            btn_Luuban.Enabled = false;
                            btn_ThemBan.Enabled = true;
                            btn_TaoMa.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trùng khóa chính");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaBan.Text == string.Empty || txt_SoCho.Text == string.Empty || txt_TenBan.Text == string.Empty)
                    {
                        MessageBox.Show("Mời Bạn Click vào bảng nha");
                    }
                    else
                    {
                        if (xlban.sua(txt_MaBan.Text, txt_TenBan.Text, int.Parse(txt_SoCho.Text)))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            dgv_Ban.DataSource = xlban.loaddgv();
                            txt_SoCho.Clear();
                            txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                            txt_TenBan.Clear();
                            txt_TrangThai.Clear();
                            txt_MaBan.Clear();
                            btn_Luuban.Enabled = false;
                            btn_XoaBan.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }
        }

        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            if (txt_MaBan.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn Click vào bảng");
            }
            else
            {
                if (xlban.xoa(txt_MaBan.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dgv_Ban.DataSource = xlban.loaddgv();
                    txt_SoCho.Clear();
                    txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                    txt_TenBan.Clear();
                    txt_TrangThai.Clear();
                    txt_MaBan.Clear();
                    btn_Luuban.Enabled = false;
                    btn_XoaBan.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgv_Ban.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv_Ban.CurrentRow.Cells[1].Value.ToString();
            string socho = dgv_Ban.CurrentRow.Cells[2].Value.ToString();
            string trangthai = dgv_Ban.CurrentRow.Cells[3].Value.ToString();
            if (ma == string.Empty || ten == string.Empty || socho == string.Empty || trangthai == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập dữ liệu đầy đủ");
            }
            else
            {
                if (xlban.kiemTraKCBan(ma))
                {
                    if (xlban.them(ma, ten, int.Parse(socho)))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        dgv_Ban.DataSource = xlban.loaddgv();
                        txt_SoCho.Clear();
                        txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                        txt_TenBan.Clear();
                        txt_TrangThai.Clear();
                        txt_MaBan.Clear();
                        btn_Luuban.Enabled = false;
                        btn_ThemBan.Enabled = true;
                        btn_TaoMa.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng khóa chính");
                }
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgv_Ban.CurrentRow.Cells[0].Value.ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Mời Click dữ liệu dô bảng");
            }
            else
            {
                if (xlban.xoa(ma))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dgv_Ban.DataSource = xlban.loaddgv();
                    txt_SoCho.Clear();
                    txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                    txt_TenBan.Clear();
                    txt_TrangThai.Clear();
                    txt_MaBan.Clear();
                    btn_Luuban.Enabled = false;
                    btn_XoaBan.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ma = dgv_Ban.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv_Ban.CurrentRow.Cells[1].Value.ToString();
            string socho = dgv_Ban.CurrentRow.Cells[2].Value.ToString();
            string trangthai = dgv_Ban.CurrentRow.Cells[3].Value.ToString();
            if (ma == string.Empty || ten == string.Empty || socho == string.Empty || trangthai == string.Empty)
            {
                MessageBox.Show("Mời Click dữ liệu dô bảng");
            }
            else
            {
                if (xlban.sua(ma, ten, int.Parse(socho)))
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgv_Ban.DataSource = xlban.loaddgv();
                    txt_SoCho.Clear();
                    txt_SoCho.Enabled = txt_TenBan.Enabled = false;
                    txt_TenBan.Clear();
                    txt_TrangThai.Clear();
                    txt_MaBan.Clear();
                    btn_Luuban.Enabled = false;
                    btn_XoaBan.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_GG.Checked)
            {
                Width = 1370;
            }
            else
            {
                Width = 780;
            }
        }

        private void dGVGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGiamGia.Text = dGVGiamGia.CurrentRow.Cells[0].Value.ToString();
            txt_PhanTram.Text = dGVGiamGia.CurrentRow.Cells[1].Value.ToString();
            txt_Ngay.Text = dGVGiamGia.CurrentRow.Cells[2].Value.ToString();
            bn_XoaGG.Enabled = bn_LuuGG.Enabled = btn_TaoMa.Enabled = true;
            txt_PhanTram.Enabled = txt_Ngay.Enabled = true;
        }

        private void bn_TaoMaGiamGia_Click(object sender, EventArgs e)
        {
            int kq = xlban.laymaMaGG();
            kq++;
            txt_MaGiamGia.Text = "GG" + kq.ToString();
            bn_ThemGG.Enabled = true;
            //bn_TaoMaGiamGia.Enabled = false;
        }

        private void bn_ThemGG_Click(object sender, EventArgs e)
        {
            dGVGiamGia.AllowUserToAddRows = true;
            dGVGiamGia.ReadOnly = false;
            for (int i = 0; i < dGVGiamGia.Rows.Count - 1; i++)
            {
                dGVGiamGia.Rows[i].ReadOnly = true;
            }
            bn_LuuGG.Enabled = true;
            txt_PhanTram.Clear();
            bn_ThemGG.Enabled = false;
            txt_PhanTram.Enabled = txt_Ngay.Enabled = true;
        }

        private void bn_LuuGG_Click(object sender, EventArgs e)
        {
            if (xlban.kiemTraKCGiamGia(txt_MaGiamGia.Text))
            {
                if (txt_MaGiamGia.Text == string.Empty || txt_PhanTram.Text == string.Empty)
                {
                    MessageBox.Show("Mời Bạn Nhập đầy đủ thuộc tính nha");
                }
                else
                {
                    if (xlban.kiemTraKCGiamGia(txt_MaGiamGia.Text))
                    {
                        if (xlban.themGIAMGIA(txt_MaGiamGia.Text, txt_Ngay.Text, txt_PhanTram.Text))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            dGVGiamGia.DataSource = xlban.loaddgvKM();
                            txt_PhanTram.Clear();
                            txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                            txt_MaGiamGia.Clear();
                            bn_LuuGG.Enabled = false;
                            bn_ThemGG.Enabled = true;
                            bn_TaoMaGiamGia.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trùng khóa chính");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaGiamGia.Text == string.Empty || txt_PhanTram.Text == string.Empty)
                    {
                        MessageBox.Show("Mời Bạn Click vào bảng nha");
                    }
                    else
                    {
                        if (xlban.suaGiamGia(txt_MaGiamGia.Text, txt_Ngay.Text, txt_PhanTram.Text))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            dGVGiamGia.DataSource = xlban.loaddgvKM();
                            txt_PhanTram.Clear();
                            txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                            txt_MaGiamGia.Clear();
                            bn_LuuGG.Enabled = false;
                            bn_ThemGG.Enabled = true;
                            bn_TaoMaGiamGia.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }
        }

        private void bn_XoaGG_Click(object sender, EventArgs e)
        {
            if (txt_MaGiamGia.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn Click vào bảng");
            }
            else
            {
                if (xlban.xoaGG(txt_MaGiamGia.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dGVGiamGia.DataSource = xlban.loaddgvKM();
                    txt_PhanTram.Clear();
                    txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                    txt_MaGiamGia.Clear();
                    bn_LuuGG.Enabled = false;
                    bn_ThemGG.Enabled = true;
                    bn_TaoMaGiamGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void thêmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string maGG = dGVGiamGia.CurrentRow.Cells[0].Value.ToString();
            string phanTram = dGVGiamGia.CurrentRow.Cells[1].Value.ToString();
            string ngaySD = dGVGiamGia.CurrentRow.Cells[2].Value.ToString();
            if (maGG == string.Empty || phanTram == string.Empty || ngaySD == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập dữ liệu đầy đủ");
            }
            else
            {
                if (xlban.kiemTraKCBan(maGG))
                {
                    if (xlban.themGIAMGIA(maGG, ngaySD,phanTram))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        dGVGiamGia.DataSource = xlban.loaddgvKM();
                        txt_PhanTram.Clear();
                        txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                        txt_MaGiamGia.Clear();
                        bn_LuuGG.Enabled = false;
                        bn_ThemGG.Enabled = true;
                        bn_TaoMaGiamGia.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng khóa chính");
                }
            }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string ma = dGVGiamGia.CurrentRow.Cells[0].Value.ToString();
            if (ma == string.Empty)
            {
                MessageBox.Show("Mời Click dữ liệu dô bảng");
            }
            else
            {
                if (xlban.xoaGG(ma))
                {
                    MessageBox.Show("Xóa Thành Công");
                    dGVGiamGia.DataSource = xlban.loaddgvKM();
                    txt_PhanTram.Clear();
                    txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                    txt_MaGiamGia.Clear();
                    bn_LuuGG.Enabled = false;
                    bn_ThemGG.Enabled = true;
                    bn_TaoMaGiamGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string maGG = dGVGiamGia.CurrentRow.Cells[0].Value.ToString();
            string phanTram = dGVGiamGia.CurrentRow.Cells[1].Value.ToString();
            string ngaySD = dGVGiamGia.CurrentRow.Cells[2].Value.ToString();
            if (maGG == string.Empty || phanTram == string.Empty || ngaySD == string.Empty)
            {
                MessageBox.Show("Mời Click dữ liệu dô bảng");
            }
            else
            {
                if (xlban.suaGiamGia(maGG, ngaySD, phanTram))
                {
                    MessageBox.Show("Sửa Thành Công");
                    dGVGiamGia.DataSource = xlban.loaddgvKM();
                    txt_PhanTram.Clear();
                    txt_PhanTram.Enabled = txt_Ngay.Enabled = false;
                    txt_MaGiamGia.Clear();
                    bn_LuuGG.Enabled = false;
                    bn_ThemGG.Enabled = true;
                    bn_TaoMaGiamGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void txt_SoCho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_PhanTram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
