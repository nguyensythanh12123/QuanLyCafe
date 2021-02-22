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
    public partial class QL_LuongNhanVien : Form
    {
        public QL_LuongNhanVien()
        {
            InitializeComponent();
        }
        Class_QL_LuongNhanVien xlluong = new Class_QL_LuongNhanVien();
        private void QL_LuongNhanVien_Load(object sender, EventArgs e)
        {
            cbb_CaLam.DataSource = xlluong.loadCaLam();
            cbb_CaLam.DisplayMember = "MaCa";
            cbb_CaLam.ValueMember = "MaCa";
            cbb_MaBL.DataSource = xlluong.loadBangLuong();
            cbb_MaBL.DisplayMember = "MaBL";
            cbb_MaBL.ValueMember = "MaBL";
            cbb_MaBLct.DataSource = xlluong.loadBangLuong();
            cbb_MaBLct.DisplayMember = "MaBL";
            cbb_MaBLct.ValueMember = "MaBL";
            cbb_TenNV.DataSource = xlluong.loadNhanVien();
            cbb_TenNV.DisplayMember = "TenNV";
            cbb_TenNV.ValueMember = "MaNV";
            cbb_TenNVct.DataSource = xlluong.loadNhanVien();
            cbb_TenNVct.DisplayMember = "TenNV";
            cbb_TenNVct.ValueMember = "MaNV";
            txt_NgayLam.Text = DateTime.Now.Date.ToShortDateString();
            cbb_MaBL.Enabled = false;
            cbb_TenNV.Enabled = false;
            cbb_TenNVct.Enabled = false;
            cbb_MaBLct.Enabled = false;
            txt_NgayLam.Enabled = false;
            cbb_CaLam.Enabled = false;
            dgv_Luongnv.DataSource = xlluong.loadLuongnv();
            dgv_ctLuongnv.DataSource = xlluong.loadctLuongnv();
            btn_Luuctbl.Enabled = false;
            btn_Xoactbl.Enabled = false;
            panel1.Visible = false;
            dgv_Luongnv.Location = new System.Drawing.Point(140, 36);
            rd_Xoa.Enabled = false;
            rd_Luu.Enabled = false;
            txt_Luognnv.Text = "0";
        }

        private void dgv_Luongnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbb_MaBL.Text = dgv_Luongnv.CurrentRow.Cells[0].Value.ToString();
                cbb_TenNV.Text = dgv_Luongnv.CurrentRow.Cells[1].Value.ToString();
                txt_NgayPL.Text = DateTime.Parse(dgv_Luongnv.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txt_Luognnv.Text = dgv_Luongnv.CurrentRow.Cells[3].Value.ToString();
                rd_Luu.Enabled = true;
                rd_Xoa.Enabled = true;
                cbb_MaBLct.Text = dgv_Luongnv.CurrentRow.Cells[0].Value.ToString();
                cbb_TenNVct.Text = dgv_Luongnv.CurrentRow.Cells[1].Value.ToString();
                dgv_ctLuongnv.DataSource = xlluong.loadctLuongTheoMa(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString());
                cbb_MaBL.Enabled = false;
                cbb_TenNV.Enabled = false;
                rd_Them.Enabled = true;
                string mabl = dgv_Luongnv.CurrentRow.Cells[0].Value.ToString();
                string manv = cbb_TenNV.SelectedValue.ToString();
                int kq = xlluong.demngaylv(mabl, manv);
                label12.Text = "Số tiếng làm việc trong tháng: " + kq.ToString();
                label11.Text = "Tên Nhân Viên: " + dgv_Luongnv.CurrentRow.Cells[1].Value.ToString();
                label13.Text = "Tổng Lương: " + dgv_Luongnv.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void chkB_Khac_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_Khac.Checked)
            {
                panel1.Visible = true;
                dgv_Luongnv.Location = new System.Drawing.Point(6, 36);
                btn_TaoPN.Location = new System.Drawing.Point(530, 5);
                grb_ctLuongnv.Visible = false;
              
                Height = 350;
            }
            else
            {
                panel1.Visible = false;
                dgv_Luongnv.Location = new System.Drawing.Point(140, 36);
                btn_TaoPN.Location = new System.Drawing.Point(8, 23);
                grb_ctLuongnv.Visible = true;
                Height = 788;
            }
        }

        private void rd_Them_CheckedChanged(object sender, EventArgs e)
        {
            cbb_MaBL.Enabled = true;
            cbb_TenNV.Enabled = true;
            rd_Luu.Enabled = true;
            rd_Them.Enabled = false;
            txt_Luognnv.Text = "0";
        }

        private void rd_Luu_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Luu.Checked)
            {
                if (cbb_MaBL.Enabled && cbb_TenNV.Enabled)
                {
                    if (cbb_MaBL.SelectedIndex < 0 && cbb_TenNV.SelectedIndex < 0)
                    {
                        MessageBox.Show("Mời bạn chọn dữ liệu");
                    }
                    else
                    {
                        if (xlluong.kiemTraKhoaChinhluongnv(cbb_MaBL.SelectedValue.ToString(), cbb_TenNV.SelectedValue.ToString()))
                        {
                            if (xlluong.luuluongnv(cbb_MaBL.SelectedValue.ToString(), cbb_TenNV.SelectedValue.ToString(), txt_NgayPL.Text, float.Parse(txt_Luognnv.Text)))
                            {
                                MessageBox.Show("Thêm Thành Công");
                                dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                                rd_Luu.Checked = false;
                                cbb_MaBL.Enabled = false;
                                cbb_TenNV.Enabled = false;
                                txt_Luognnv.Clear();
                                txt_NgayPL.Clear();
                                rd_Luu.Enabled = false;
                                rd_Them.Enabled = true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Trùng Khóa Chính");
                        }
                    }
                }
                else
                {
                    if (cbb_MaBL.SelectedIndex < 0 && cbb_TenNV.SelectedIndex < 0)
                    {
                        MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
                    }
                    else
                    {
                        if (xlluong.sualuongnv(cbb_MaBL.SelectedValue.ToString(), cbb_TenNV.SelectedValue.ToString(), txt_NgayPL.Text, float.Parse(txt_Luognnv.Text)))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                            rd_Luu.Checked = false;
                            rd_Them.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }         
        }

        private void rd_Xoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Xoa.Checked)
            {
                if (!cbb_MaBL.Enabled && !cbb_TenNV.Enabled)
                {
                    if (cbb_MaBL.SelectedIndex < 0 && cbb_TenNV.SelectedIndex < 0)
                    {
                        MessageBox.Show("Mời Click vào bảng");
                    }
                    else
                    {
                        if (xlluong.xoaluongnv(cbb_MaBL.SelectedValue.ToString(), cbb_TenNV.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                            rd_Xoa.Checked = false;
                            txt_Luognnv.Clear();
                            txt_NgayPL.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa được");
                            rd_Xoa.Checked = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mời bạn click dô bảng nha");
                }
            }
        }

        private void cms_Themluongnv_Click(object sender, EventArgs e)
        {
            string mabl = dgv_Luongnv.CurrentRow.Cells[0].Value.ToString();
            string manv = dgv_Luongnv.CurrentRow.Cells[1].Value.ToString();
            string ngaypl = dgv_Luongnv.CurrentRow.Cells[2].Value.ToString();
            string tienluong = dgv_Luongnv.CurrentRow.Cells[3].Value.ToString();
            if (mabl == string.Empty || manv == string.Empty || ngaypl == string.Empty || tienluong == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập dữ liệu đầy đủ");
            }
            else
            {
                if (xlluong.kiemTraKhoaChinhluongnv(mabl, manv))
                {
                    if (xlluong.luuluongnv(mabl, manv, ngaypl, float.Parse(tienluong)))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        dgv_Luongnv.DataSource = xlluong.loadLuongnv();
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

        private void cmt_XoaLuongnv_Click(object sender, EventArgs e)
        {
            string mabl = dgv_Luongnv.CurrentRow.Cells[0].Value.ToString();
            string manv = cbb_TenNV.SelectedValue.ToString();
            if (mabl == string.Empty || manv == string.Empty)
            {
                MessageBox.Show("Mời bạn click vào bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlluong.xoaluongnv(mabl, manv))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                        txt_Luognnv.Clear();
                        txt_NgayPL.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa được");
                    }
                }

            }
        }

        private void btn_Themctbl_Click(object sender, EventArgs e)
        {
            cbb_CaLam.Enabled = true;
            btn_Luuctbl.Enabled = true;
            btn_Themctbl.Enabled = false;
        }

        private void btn_Luuctbl_Click(object sender, EventArgs e)
        {
            if (cbb_CaLam.Enabled)
            {
                if (txt_NgayLam.Text == string.Empty || cbb_MaBLct.SelectedIndex < 0 || cbb_TenNVct.SelectedIndex < 0 || cbb_CaLam.SelectedIndex < 0 || txt_Tien.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn chọn dữ liệu");
                }
                else
                {
                    if (xlluong.ktKhoaCtBangLuong(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString(), cbb_CaLam.SelectedValue.ToString(), txt_NgayLam.Text))
                    {
                        if (xlluong.themctLuongnv(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString(), cbb_CaLam.SelectedValue.ToString(), txt_NgayLam.Text, float.Parse(txt_Tien.Text)))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            dgv_ctLuongnv.DataSource = xlluong.loadctLuongTheoMa(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString());
                            dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Trùng Khóa Chính");
                    }
                }
            }
        }

        private void dgv_ctLuongnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbb_MaBLct.Text = dgv_ctLuongnv.CurrentRow.Cells[0].Value.ToString();
                cbb_TenNVct.Text = dgv_ctLuongnv.CurrentRow.Cells[1].Value.ToString();
                cbb_CaLam.Text = xlluong.layMaCa(dgv_ctLuongnv.CurrentRow.Cells[2].Value.ToString());
                txt_NgayLam.Text = DateTime.Parse(dgv_ctLuongnv.CurrentRow.Cells[3].Value.ToString()).ToShortDateString();
                txt_Tien.Text = dgv_ctLuongnv.CurrentRow.Cells[4].Value.ToString();
                txt_Thanhtien.Text = dgv_ctLuongnv.CurrentRow.Cells[5].Value.ToString();
                btn_Luuctbl.Enabled = true;
                btn_Xoactbl.Enabled = true;

            }
            catch
            {
            }
        }

        private void btn_Xoactbl_Click(object sender, EventArgs e)
        {
            if (txt_NgayLam.Text == string.Empty && cbb_MaBLct.SelectedIndex < 0 && cbb_TenNVct.SelectedIndex < 0 && cbb_CaLam.SelectedIndex < 0)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlluong.xoactLuongnv(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString(), cbb_CaLam.SelectedValue.ToString(), txt_NgayLam.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgv_ctLuongnv.DataSource = xlluong.loadctLuongTheoMa(cbb_MaBLct.SelectedValue.ToString(), cbb_TenNVct.SelectedValue.ToString());
                        dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
        }

        private void cmt_xoactblnv_Click(object sender, EventArgs e)
        {
            string mabl = dgv_ctLuongnv.CurrentRow.Cells[0].Value.ToString();
            string manv = cbb_TenNVct.SelectedValue.ToString();
            string maca = xlluong.layMaCa(dgv_ctLuongnv.CurrentRow.Cells[2].Value.ToString());
            string ngay = DateTime.Parse(dgv_ctLuongnv.CurrentRow.Cells[3].Value.ToString()).ToShortDateString();
            if (mabl == string.Empty || manv == string.Empty || maca == string.Empty || ngay == string.Empty)
            {
                MessageBox.Show("Mời Chọn Dữ Liệu Bạn Cần Xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlluong.xoactLuongnv(mabl, manv, maca, ngay))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dgv_ctLuongnv.DataSource = xlluong.loadctLuongTheoMa(mabl, manv);
                        dgv_Luongnv.DataSource = xlluong.loadLuongnv();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa được");
                    }
                }
            }
        }

        private void QL_LuongNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Chắc Chắn Muốn Đóng Form Không?", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_TaoPN_Click(object sender, EventArgs e)
        {
            if (xlluong.LuuBangNV())
            {
                MessageBox.Show("Thêm thành công (^-^)", "Thông báo");
                cbb_MaBL.DataSource = xlluong.loadBangLuong();
                cbb_MaBL.DisplayMember = "MaBL";
                cbb_MaBL.ValueMember = "MaBL";
            }
        }

        private void grb_PhatLuong_Enter(object sender, EventArgs e)
        {

        }
    }
}
