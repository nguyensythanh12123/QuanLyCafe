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
        
        Class_BanHang bh = new Class_BanHang();
        
        private void BanHang_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flow_ThucAn.Controls.Clear();
            flow_DoUong.Controls.Clear();
            bh.selectBan(flowLayoutPanel1, imageList1);
            bh.selectMon(flow_ThucAn, imageList2, flow_DoUong);
            bh.maBan = txtMaBan;
            bh.SL = txt_SoLuong;
            flow_DoUong.Enabled = false;
            flow_ThucAn.Enabled = false;
            btHuy.Enabled = false;
            bh.dv = dataGridView1;
            bh.maHoaDonBan = txttim;
            //hiện thị các nút
            btnDong.Enabled = false;
            btThem.Enabled = false;
            btXoa.Enabled = false;
            btTinhTien.Enabled = false;
            bn_LuuHD.Enabled = false;
            bttim.Enabled = true;
            btnTaoHD.Enabled = true;
            btthoat.Enabled = true;
            bn_inHoaDon.Enabled = false;
            crystalReportViewer1.Visible = false;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            bh.bn_Huy();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            bh.ThemMon(sender, e,txtMaHD.Text, txt_SoLuong.Text);
            bh.hienThiLendatagirdview(dataGridView1, txtMaHD.Text);
            bh.soLuong = 0;
            txtThanhToan.Text = bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text);
            txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txtMaHD.Text, txtTrangThaiTT.Text);
            btTinhTien.Enabled = true;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            flow_DoUong.Enabled = false;
            flow_ThucAn.Enabled = false;
            btTinhTien.Enabled = true;
            btThem.Enabled = true;
            if (txttim.Text.Length > 0)
            {
                bh.hienThiLendatagirdview(dataGridView1, txttim.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txttim.Text, txtThanhToan.Text);
                txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txttim.Text, txtTrangThaiTT.Text);
                txtMaBan.Text = bh.hienThiMaBan(txtMaBan.Text, txttim.Text);
                //txtMaNV.Text = bh.hienThiNhanVien(txtMaNV.Text, txttim.Text);
                ngayTao.Text = bh.hienThiNgayTao(ngayTao.Text, txttim.Text);
                txtTienNhan.Clear();
                lblThanhTien.Text =  lblTienThoi.Text ="0 VND";
                txtMaHD.Text = txttim.Text;
                flow_ThucAn.Enabled = true;
                flow_DoUong.Enabled = true;
                btHuy.Enabled = true;
                if (giaGia.Items != null)
                {
                    giaGia.Items.Clear();
                    giaGia.Items.Add(bh.hienThiMaGiamGia(txtMaHD.Text));
                    giaGia.Enabled = false;
                    giaGia.SelectedIndex = 0;
                }
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = bh.taoHoaDon();
            bh.hienThiCBGiamGia(ngayTao.Text, giaGia);
            txtThanhToan.Clear();
            txtTrangThaiTT.Clear();
            txtTienNhan.Clear();
            giaGia.Enabled = true;
            txtMaBan.Clear();
            bh.hienThiLendatagirdview(dataGridView1, txtMaHD.Text);
            bn_LuuHD.Enabled = true;
            btnTaoHD.Enabled = false;
            flow_DoUong.Enabled = false;
            flow_ThucAn.Enabled = false;
            lblThanhTien.Text = "0 VND";
            lblTienThoi.Text = "0 VND";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length > 0 && txtMaHD.Text.Length > 0 && txtMaBan.Text.Length > 0)
            {
                bh.luuHoaDon(txtMaHD.Text, txtMaNV.Text, txtMaBan.Text, DateTime.Parse(ngayTao.Text), giaGia);
                txtThanhToan.Text = bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text);
                txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txtMaHD.Text, txtTrangThaiTT.Text);
                flow_ThucAn.Enabled = true;
                flow_DoUong.Enabled = true;
                giaGia.Enabled = false;
                btHuy.Enabled = true;
               
            }
            btnDong.Enabled = true;
            btThem.Enabled = true;
            bn_LuuHD.Enabled = false;
            btnTaoHD.Enabled = true;
        }

        private void btTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTienNhan.Text.Length > 0 && Convert.ToInt32(txtTienNhan.Text) > Convert.ToInt32(txtThanhToan.Text))
            {
                bh.TinhTien(txtMaHD.Text, txtMaBan.Text, giaGia, float.Parse(txtTienNhan.Text));
                txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txtMaHD.Text, txtTrangThaiTT.Text);
                lblThanhTien.Text = "" + bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text) + " " + "VND" + "";
                lblTienThoi.Text = "" + bh.hienThiTienThoi(txtMaHD.Text, lblTienThoi.Text) +" " + "VND" + "";
                flowLayoutPanel1.Controls.Clear();
                bh.selectBan(flowLayoutPanel1, imageList1);
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại (^-^)", "Thông báo");
            }
            bn_inHoaDon.Enabled = true;
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            btXoa.Enabled = false;
            string tenmon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (bh.xoa(txtMaHD.Text, bh.layMaMon(tenmon)))
            {
                MessageBox.Show("Xóa Thành Công");
                bh.hienThiLendatagirdview(dataGridView1, txtMaHD.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text);
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            BanHang_Load(sender, e);
        }

        private void cms_SuaCTHD_Click(object sender, EventArgs e)
        {
            string tenmon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string soluong = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (tenmon.Trim().Length == 0 || soluong.TrimEnd().Length==0)
            {
                MessageBox.Show("Vui lòng click vào bảng và điển đầy đủ thông tin");
                return;
            }
            if (bh.sua(txtMaHD.Text, bh.layMaMon(tenmon),int.Parse(soluong)))
            {
                MessageBox.Show("Sửa Thành Công");
                bh.hienThiLendatagirdview(dataGridView1, txtMaHD.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text);
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }
        }

        private void cms_XoaCTHD_Click(object sender, EventArgs e)
        {
            string tenmon = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (tenmon.Trim().Length == 0 )
            {
                MessageBox.Show("Vui lòng click vào bảng và điển đầy đủ thông tin");
                return;
            }
            if (bh.xoa(txtMaHD.Text, bh.layMaMon(tenmon)))
            {
                MessageBox.Show("Xóa Thành Công");
                bh.hienThiLendatagirdview(dataGridView1, txtMaHD.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txtMaHD.Text, txtThanhToan.Text);
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btXoa.Enabled = true;
            btTinhTien.Enabled = true;
        }

        private void txttim_KeyUp(object sender, KeyEventArgs e)
        {
            flow_DoUong.Enabled = false;
            flow_ThucAn.Enabled = false;
            btTinhTien.Enabled = true;
            btThem.Enabled = true;
            if (txttim.Text.Length > 0)
            {
                bh.hienThiLendatagirdview(dataGridView1, txttim.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txttim.Text, txtThanhToan.Text);
                txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txttim.Text, txtTrangThaiTT.Text);
                txtMaBan.Text = bh.hienThiMaBan(txtMaBan.Text, txttim.Text);
                //txtMaNV.Text = bh.hienThiNhanVien(txtMaNV.Text, txttim.Text);
                ngayTao.Text = bh.hienThiNgayTao(ngayTao.Text, txttim.Text);
                txtTienNhan.Text = bh.hienThiTienNhan(txttim.Text, txtTienNhan.Text);
                lblThanhTien.Text = lblTienThoi.Text = "0 VND";
                txtMaHD.Text = txttim.Text;
                flow_ThucAn.Enabled = true;
                flow_DoUong.Enabled = true;
                btHuy.Enabled = true;
                if (giaGia.Items != null)
                {
                    giaGia.Items.Clear();
                    giaGia.Items.Add(bh.hienThiMaGiamGia(txtMaHD.Text));
                    giaGia.Enabled = false;
                    giaGia.SelectedIndex = 0;
                }
            }
        }

        private void bttim_KeyPress(object sender, KeyPressEventArgs e)
        {
            flow_DoUong.Enabled = false;
            flow_ThucAn.Enabled = false;
            btTinhTien.Enabled = true;
            btThem.Enabled = true;
            if (txttim.Text.Length > 0)
            {
                bh.hienThiLendatagirdview(dataGridView1, txttim.Text);
                txtThanhToan.Text = bh.hienThiThanhTien(txttim.Text, txtThanhToan.Text);
                txtTrangThaiTT.Text = bh.hienThiTrangThaiTT(txttim.Text, txtTrangThaiTT.Text);
                txtMaBan.Text = bh.hienThiMaBan(txtMaBan.Text, txttim.Text);
                //txtMaNV.Text = bh.hienThiNhanVien(txtMaNV.Text, txttim.Text);
                ngayTao.Text = bh.hienThiNgayTao(ngayTao.Text, txttim.Text);
                txtTienNhan.Text = bh.hienThiTienNhan(txttim.Text, txtTienNhan.Text) ;
                lblThanhTien.Text = lblTienThoi.Text = "0 VND";
                txtMaHD.Text = txttim.Text;
                flow_ThucAn.Enabled = true;
                flow_DoUong.Enabled = true;
                btHuy.Enabled = true;
                if (giaGia.Items != null)
                {
                    giaGia.Items.Clear();
                    giaGia.Items.Add(bh.hienThiMaGiamGia(txtMaHD.Text));
                    giaGia.Enabled = false;
                    giaGia.SelectedIndex = 0;
                }
            }
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Chắc Chắn Muốn Đóng Form Không?", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void flow_ThucAn_Click(object sender, EventArgs e)
        {
            //txt_SoLuong.Text = bh.soLuong.ToString();
        }
        int bam = 0;
        private void bn_inHoaDon_Click(object sender, EventArgs e)
        {
            bam = 1;
            if (bam == 1)
            {
               
                crystalReportViewer1.Visible = true;
            
                Report_HoaDon rpt = new Report_HoaDon();
                rpt.SetParameterValue("HD", txtMaHD.Text);
                button1.Visible = true;
                crystalReportViewer1.ReportSource = rpt;
                rpt.SetDatabaseLogon("sa", "1810nguyenthanhan", "DESKTOP-0VFU93U\\SQLEXPRESS2012", "QL_QuanCaFe");
                crystalReportViewer1.DisplayToolbar = true;
                crystalReportViewer1.DisplayStatusBar = false;
                crystalReportViewer1.Refresh();
            }
            else
            {
                BanHang_Load(sender, e);
                crystalReportViewer1.Visible = false;
            }
            bam = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BanHang_Load(sender, e);
        }

        private void txtMaHD_KeyUp(object sender, KeyEventArgs e)
        {
            bh.hienThiCBGiamGia(ngayTao.Text, giaGia);
        }

    }
}
