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
    public partial class QL_NhapXuat : Form
    {
        public QL_NhapXuat()
        {
            InitializeComponent();
        }
        Class_QL_PhieuNhap xlnhap = new Class_QL_PhieuNhap();
        Class_QL_PhieuXuat xlxuat = new Class_QL_PhieuXuat();
        private void QL_NhapXuat_Load(object sender, EventArgs e)
        {
            Width = 787;
            Height = 787;
            //xử lý nhập
            //txt_MaPN.Enabled = false;
            txt_TienNhap.Enabled = false;
            txt_NgayNhap.Enabled = false;
            txt_NgayNhap.Text = DateTime.Now.ToShortDateString();
            Maql.DataSource = xlnhap.LoadQuanLy();
            Maql.DisplayMember = "TenQL";
            Maql.ValueMember = "MaQL";
            MaNV.DataSource = xlxuat.LoadNhanVien();
            MaNV.DisplayMember = "TenNV";
            MaNV.ValueMember = "MaNV";
            Cbb_MaQL.DataSource = xlnhap.LoadQuanLy();
            Cbb_MaQL.DisplayMember = "TenQL";
            Cbb_MaQL.ValueMember = "MaQL";
            txt_TienNhap.Text = "0";
            dgv_PhieuNhap.DataSource = xlnhap.LoadPhieuNhap();
            cbb_MaPN.DataSource = xlnhap.LoadPhieuNhap();
            cbb_MaPN.DisplayMember = "MaPN";
            cbb_MaPN.ValueMember = "MaPN";
            cbb_TenNL.DataSource = xlnhap.LoadNguyenLieu();
            cbb_TenNL.DisplayMember = "TenNL";
            cbb_TenNL.ValueMember = "MaNL";
            dgv_ChiTietPN.DataSource = xlnhap.LoadChiTietPN();
            btn_Luuctpn.Enabled = false;
            btn_Suactpn.Enabled = false;
            btn_Xoactpn.Enabled = false;
            //xử Lý Xuất
            btn_luuctpx.Enabled = false;
            btn_Suactpx.Enabled = false;
            btn_xoactpx.Enabled = false;
            txt_NgayXuat.Text = DateTime.Now.ToShortDateString();
            txt_NgayXuat.Enabled = false;
            cbb_Mapx.DataSource = xlxuat.LoadPhieuXuat();
            cbb_Mapx.DisplayMember = "MaPX";
            cbb_Mapx.ValueMember = "MaPX";
            dgv_PhieuXuat.DataSource = xlxuat.LoadPhieuXuat();
            cbb_nv.DataSource = xlxuat.LoadNhanVien();
            cbb_nv.DisplayMember = "TenNV";
            cbb_nv.ValueMember = "MaNV";
            cbb_NguyenLieu.DataSource = xlnhap.LoadNguyenLieu();
            cbb_NguyenLieu.DisplayMember = "TenNL";
            cbb_NguyenLieu.ValueMember = "MaNL";
            dgv_ctpx.DataSource = xlxuat.LoadChiTietPX();
            StartPosition = FormStartPosition.CenterScreen;
            crystalReportViewer1.Visible = false;
            button2.Visible = false;
        }

        private void btn_TaoPN_Click(object sender, EventArgs e)
        {
            int kq = xlnhap.laymaMax();
            kq++;
            txt_MaPN.Text = "PN" + kq.ToString();
            txt_NgayNhap.Text = DateTime.Now.ToShortDateString();
            txt_TienNhap.Text = "0";
        }

        private void btn_LuuPN_Click(object sender, EventArgs e)
        {
            if (!xlnhap.KT_KhoaChinh(txt_TienNhap.Text))
            {
                MessageBox.Show("Mã đã tồn tại!");
            }
            else
            {
                if (xlnhap.LuuPN(txt_MaPN.Text, txt_NgayNhap.Text, Cbb_MaQL.SelectedValue.ToString(), float.Parse(txt_TienNhap.Text)))
                {
                    MessageBox.Show("Thêm Thành Công");
                    QL_NhapXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
        }

        private void dgv_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaPN.Text = dgv_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
                txt_NgayNhap.Text = DateTime.Parse(dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString()).ToShortDateString();
                Cbb_MaQL.SelectedValue = dgv_PhieuNhap.CurrentRow.Cells[2].Value.ToString();
                txt_TienNhap.Text = dgv_PhieuNhap.CurrentRow.Cells[3].Value.ToString();
                cbb_MaPN.Text = dgv_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void cbb_MaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ChiTietPN.DataSource = xlnhap.LoaCTPNTheoMa(cbb_MaPN.SelectedValue.ToString());
        }

        private void dgv_ChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_MaPN.Text = dgv_ChiTietPN.CurrentRow.Cells[0].Value.ToString();
            cbb_TenNL.SelectedValue = dgv_ChiTietPN.CurrentRow.Cells[1].Value.ToString();
            txt_Slctn.Text = dgv_ChiTietPN.CurrentRow.Cells[2].Value.ToString();
            txt_DonGia.Text = dgv_ChiTietPN.CurrentRow.Cells[3].Value.ToString();
            btn_Suactpn.Enabled = true;
            btn_Xoactpn.Enabled = true;
            btn_Themctpn.Enabled = true;
            btn_Luuctpn.Enabled = false;
        }

        private void btn_Themctpn_Click(object sender, EventArgs e)
        {
            btn_Luuctpn.Enabled = true;
            btn_Themctpn.Enabled = false;
            txt_Slctn.Clear();
            txt_DonGia.Clear();
        }

        private void btn_Luuctpn_Click(object sender, EventArgs e)
        {
            if (cbb_MaPN.SelectedIndex >= 0 && cbb_TenNL.SelectedIndex >= 0 && txt_DonGia.Text.Trim().Length != 0 && txt_Slctn.Text.Trim().Length != 0)
            {
                if (xlnhap.KiemTraKhoaChinhCTPN(cbb_MaPN.SelectedValue.ToString(), cbb_TenNL.SelectedValue.ToString()))
                {
                    if (xlnhap.LuuCTPN(cbb_MaPN.SelectedValue.ToString(), cbb_TenNL.SelectedValue.ToString(), int.Parse(txt_Slctn.Text), float.Parse(txt_DonGia.Text)))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        QL_NhapXuat_Load(sender, e);
                        btn_Luuctpn.Enabled = false;
                        btn_Themctpn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng Khóa Chính");
                }
            }
            else
            {
                MessageBox.Show("Mời Nhập Dữ Liệu Vào");
            }
        }

        private void btn_Xoactpn_Click(object sender, EventArgs e)
        {
            if (cbb_MaPN.SelectedIndex >= 0 && cbb_TenNL.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlnhap.xoacthd(cbb_MaPN.SelectedValue.ToString(), cbb_TenNL.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        QL_NhapXuat_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Dữ Liệu đang sử dụng không thể xóa");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời Bạn Chọn Dữ Liệu ");
            }
        }

        private void btn_Suactpn_Click(object sender, EventArgs e)
        {
            if (cbb_MaPN.SelectedIndex >= 0 && cbb_TenNL.SelectedIndex >= 0 && txt_DonGia.Text.Trim().Length != 0 && txt_Slctn.Text.Trim().Length != 0)
            {
                if (xlnhap.suaChiTietPN(cbb_MaPN.SelectedValue.ToString(), cbb_TenNL.SelectedValue.ToString(), int.Parse(txt_Slctn.Text), float.Parse(txt_DonGia.Text)))
                {
                    MessageBox.Show("Sửa Thành Công");
                    QL_NhapXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Mời chọn dữ liệu");
            }
        }

        private void btn_taopx_Click(object sender, EventArgs e)
        {
            int kq = xlxuat.layMaMax();
            kq++;
            txt_Mapx.Text = "PX0" + kq.ToString();
            txt_NgayXuat.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_LuuPx_Click(object sender, EventArgs e)
        {
            if (txt_Mapx.Text.Trim().Length != 0 && cbb_nv.SelectedIndex >= 0 && txt_NgayXuat.Text.Trim().Length != 0)
            {
                if (xlxuat.KT_KhoaChinh(txt_Mapx.Text))
                {
                    if (xlxuat.LuuPx(txt_Mapx.Text, txt_NgayXuat.Text, cbb_nv.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        QL_NhapXuat_Load(sender, e);
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
            else
            {
                MessageBox.Show("Mời Bạn Nhập Dữ Liệu");
            } 
        }

        private void dgv_PhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Mapx.Text = dgv_PhieuXuat.CurrentRow.Cells[0].Value.ToString();
                txt_NgayXuat.Text = DateTime.Parse(dgv_PhieuXuat.CurrentRow.Cells[2].Value.ToString()).ToShortDateString();
                cbb_nv.SelectedValue = dgv_PhieuXuat.CurrentRow.Cells[1].Value.ToString();
                cbb_Mapx.SelectedValue = dgv_PhieuXuat.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void btn_Themctpx_Click(object sender, EventArgs e)
        {
            btn_luuctpx.Enabled = true;
            btn_Themctpx.Enabled = false;
            txt_slXuat.Clear();
        }

        private void dgv_ctpx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_Mapx.SelectedValue = dgv_ctpx.CurrentRow.Cells[0].Value.ToString();
            cbb_NguyenLieu.SelectedValue = dgv_ctpx.CurrentRow.Cells[1].Value.ToString();
            txt_slXuat.Text = dgv_ctpx.CurrentRow.Cells[2].Value.ToString();
            btn_Themctpx.Enabled = true;
            btn_xoactpx.Enabled = true;
            btn_Suactpx.Enabled = true;
            btn_luuctpx.Enabled = false;
        }

        private void cbb_Mapx_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ctpx.DataSource = xlxuat.LoaCTPXTheoMa(cbb_Mapx.SelectedValue.ToString());
        }

        private void btn_luuctpx_Click(object sender, EventArgs e)
        {
            if (cbb_NguyenLieu.SelectedIndex >= 0 && cbb_Mapx.SelectedIndex >= 0 && txt_slXuat.Text.Trim().Length != 0)
            {
                if (xlxuat.KiemTraKhoaChinhCTPx(cbb_Mapx.SelectedValue.ToString(), cbb_NguyenLieu.SelectedValue.ToString()))
                {
                    if (int.Parse(txt_slXuat.Text) <= xlxuat.hienThiSoLuongTon(cbb_TenNL.SelectedValue.ToString()))
                    { 
                    if (xlxuat.LuuCTPX(cbb_Mapx.SelectedValue.ToString(), cbb_NguyenLieu.SelectedValue.ToString(), int.Parse(txt_slXuat.Text)))
                    {
                       
                            MessageBox.Show("Thêm Thành Công (^-^)", "Thông báo");
                            QL_NhapXuat_Load(sender, e);
                            btn_luuctpx.Enabled = false;
                            btn_Themctpx.Enabled = true;
                    }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng trong kho không đủ để xuất (^-^)", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng Khóa Chính (^-^)", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mời nhập Dữ liệu (^-^)", "Thông báo");
            }
        }

        private void btn_xoactpx_Click(object sender, EventArgs e)
        {
            if (cbb_Mapx.SelectedIndex >= 0 && cbb_NguyenLieu.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlxuat.xoactPX(cbb_Mapx.SelectedValue.ToString(), cbb_NguyenLieu.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Xóa Thành Công (^-^)", "Thông báo");
                        QL_NhapXuat_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã Không Tồn Tại Trong Chi Tiết (^-^)", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời Bạn Chọn Dữ Liệu (^-^)", "Thông báo");
            }
        }

        private void btn_Suactpx_Click(object sender, EventArgs e)
        {
            if (cbb_Mapx.SelectedIndex >= 0 && cbb_NguyenLieu.SelectedIndex >= 0 && txt_slXuat.Text.Trim().Length != 0)
            {
                if (xlxuat.suaChiTietPX(cbb_Mapx.SelectedValue.ToString(), cbb_NguyenLieu.SelectedValue.ToString(), int.Parse(txt_slXuat.Text)))
                {
                    MessageBox.Show("Sửa Thành Công (^-^)", "Thông báo");
                    QL_NhapXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã Không tồn tại (^-^)", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Mời chọn dữ liệu (^-^)", "Thông báo");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapn = dgv_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                if (xlnhap.XoaPN(mapn))
                {
                    MessageBox.Show("Xóa Thành Công (^-^)", "Thông báo");
                    QL_NhapXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại (^-^)", "Thông báo");
                }
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mapn = dgv_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
            string ngaynhap = DateTime.Parse(dgv_PhieuNhap.CurrentRow.Cells[1].Value.ToString()).ToShortDateString();
            string maql = dgv_PhieuNhap.CurrentRow.Cells[2].Value.ToString();
            if (xlnhap.suaPhieuNhap(mapn, ngaynhap, maql))
            {
                MessageBox.Show("Sửa Thành Công (^-^)", "Thông báo");
                QL_NhapXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại (^-^)", "Thông báo");
            }
        }

        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mapx = dgv_PhieuXuat.CurrentRow.Cells[0].Value.ToString();
            string manv = dgv_PhieuXuat.CurrentRow.Cells[1].Value.ToString();
            string ngayxuat = dgv_PhieuXuat.CurrentRow.Cells[2].Value.ToString();
            if (xlxuat.suaPhieuXuat(mapx, ngayxuat, manv))
            {
                MessageBox.Show("Sửa thành Công (^-^)", "Thông báo");
                QL_NhapXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại (^-^)", "Thông báo");
            }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mapx = dgv_PhieuXuat.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                if (xlxuat.XoaPX(mapx))
                {
                    MessageBox.Show("Xóa Thành Công (^-^)", "Thông báo");
                    QL_NhapXuat_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại (^-^)", "Thông báo");
                }
            }
        }
        int n = 0;

        private void btn_ThucHienXuat_Click(object sender, EventArgs e)
        {
            n++;
            if (n % 2 != 0)
            {
                btn_ThucHienXuat.Text = "Thực Hiện Nhập";
                //Width = 1386;
                groupBox3.Location = new System.Drawing.Point(90, 23);
                groupBox4.Location = new System.Drawing.Point(90, 389);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
            }
            else
            {
                btn_ThucHienXuat.Text = "Thực Hiện Xuất";
                //Width = 787;
                groupBox1.Location = new System.Drawing.Point(11, 23);
                groupBox2.Location = new System.Drawing.Point(11, 389);
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
            }
            
        }

        private void QL_NhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Chắc Chắn Muốn Đóng Form Không?", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_TienNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                XemNguyenLieu xl = new XemNguyenLieu();
                xl.ShowDialog();
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report_InPhieuNhap rp = new Report_InPhieuNhap();
            rp.SetDatabaseLogon("sa", "1810nguyenthanhan", "DESKTOP-0VFU93U\\SQLEXPRESS2012", "QL_QuanCaFe");
            rp.SetParameterValue("inphieuxuat", cbb_MaPN.SelectedValue.ToString());
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.Visible = true;
            button2.Visible = true;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_NhapXuat_Load(sender, e);
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report_InPhieuXuat rp = new Report_InPhieuXuat();
            rp.SetDatabaseLogon("sa", "1810nguyenthanhan", "DESKTOP-0VFU93U\\SQLEXPRESS2012", "QL_QuanCaFe");
            rp.SetParameterValue("MaPhieu", cbb_Mapx.SelectedValue.ToString());
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.Visible = true;
            button2.Visible = true;
        }

    }
}
