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
    public partial class QL_NhanVien : Form
    {
        public QL_NhanVien()
        {
            InitializeComponent();
        }
        Class_QL_NhanVien xlnv = new Class_QL_NhanVien();
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            Width = 1375;
            TP.DataSource  = xlnv.loadBP();
            TP.DisplayMember = "TenBP";
            TP.ValueMember = "MaBP";

             cbb_MaBP.DataSource = xlnv.loadBP();
            cbb_MaBP.DisplayMember = "TenBP";
            cbb_MaBP.ValueMember = "MaBP";

            TenQL.DataSource = xlnv.loadNhaQL();
            TenQL.DisplayMember = "TenQL";
            TenQL.ValueMember = "MaQL";

            cbb_MaQL.DataSource = xlnv.loadNhaQL();
            cbb_MaQL.DisplayMember = "TenQL";
            cbb_MaQL.ValueMember = "MaQL";
            dgv_NhanVien.DataSource = xlnv.loadNV();
            grb_BoPhan.Visible = false;
            grb_NhaQL.Visible = false;
            grb_NhanVien.Location = new System.Drawing.Point(300, 13);           
            txt_MaNV.Enabled = false;
            btn_Luunv.Enabled =rb_Nam.Enabled=rb_Nu.Enabled=cbb_MaBP.Enabled=cbb_MaQL.Enabled=txt_DiaChi.Enabled=txt_MatKhau.Enabled=txt_NgaySinh.Enabled=txt_NgayVL.Enabled=txt_SDT.Enabled=txt_TenNV.Enabled =false;
            txt_MaQL.Enabled = txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = false;
            btn_Xoanv.Enabled = false;
            txt_MaQL.Enabled = false;
            btn_Luql.Enabled = false;
            btn_Xoaql.Enabled = false;
        }

        private void cb_xlQL_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xlQL.Checked && !cb_xlBP.Checked)
            {
                dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                grb_NhaQL.Visible = true;
                grb_NhaQL.Location = new System.Drawing.Point(819, 13);
                grb_NhanVien.Location = new System.Drawing.Point(12, 13);
            }
            else if (cb_xlBP.Checked && cb_xlQL.Checked)
            {
                dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                grb_NhaQL.Visible = true;
                grb_NhaQL.Location = new System.Drawing.Point(819, 13);
                grb_BoPhan.Visible = true;
                grb_BoPhan.Location = new System.Drawing.Point(819, 377);
            }
            else if (cb_xlBP.Checked)
            {
                grb_BoPhan.Visible = true;
                grb_BoPhan.Location = new System.Drawing.Point(819, 13);
                grb_NhaQL.Visible = false;
            }
            else if (!cb_xlQL.Checked && !cb_xlBP.Checked)
            {
                grb_NhanVien.Location = new System.Drawing.Point(300, 13);
                grb_NhaQL.Visible = false;
                grb_BoPhan.Visible = false;
                dgv_NhanVien.DataSource = xlnv.loadNV();
            }
            else
            {
                grb_NhaQL.Visible = false;
                dgv_NhanVien.DataSource = xlnv.loadNV();
            }
        }

        private void cb_xlBP_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xlBP.Checked && !cb_xlQL.Checked)
            {
                dgv_BP.DataSource = xlnv.loadBP();
                grb_BoPhan.Visible = true;
                grb_BoPhan.Location = new System.Drawing.Point(819, 13);
                grb_NhanVien.Location = new System.Drawing.Point(12, 13);
            }
            else if (cb_xlQL.Checked && cb_xlBP.Checked)
            {
                dgv_BP.DataSource = xlnv.loadBP();
                grb_BoPhan.Visible = true;
                grb_BoPhan.Location = new System.Drawing.Point(819, 377);
            }
            else if (!cb_xlQL.Checked && !cb_xlBP.Checked)
            {
                grb_NhanVien.Location = new System.Drawing.Point(300, 13);
                grb_NhaQL.Visible = false;
                grb_BoPhan.Visible = false;
                dgv_NhanVien.DataSource = xlnv.loadNV();
            }
            else
            {
                grb_BoPhan.Visible = false;
                dgv_NhanVien.DataSource = xlnv.loadNV();
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_NhanVien.Columns[0].ReadOnly = true;
            dgv_NhanVien.ReadOnly = false;
            try
            {
                cbb_MaBP.Enabled = cbb_MaQL.Enabled = txt_DiaChi.Enabled = txt_MatKhau.Enabled = txt_NgaySinh.Enabled = txt_NgayVL.Enabled = txt_SDT.Enabled = txt_TenNV.Enabled = true;
                txt_MaNV.Text = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_TenNV.Text = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
                txt_NgaySinh.Text = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
                string str = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
                if (str.TrimEnd() == "Nam")
                {
                    rb_Nam.Checked = true;
                }
                else
                {
                    rb_Nu.Checked = true;
                }
                txt_DiaChi.Text = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
                txt_SDT.Text = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
                txt_NgayVL.Text = DateTime.Parse(dgv_NhanVien.CurrentRow.Cells[6].Value.ToString()).ToShortDateString();
                cbb_MaQL.SelectedValue = dgv_NhanVien.CurrentRow.Cells[7].Value.ToString();
                cbb_MaBP.SelectedValue = dgv_NhanVien.CurrentRow.Cells[8].Value.ToString();
                txt_MatKhau.Text = dgv_NhanVien.CurrentRow.Cells[9].Value.ToString();
                btn_Luunv.Enabled = true;
                btn_Xoanv.Enabled = true;
                txt_MaNV.Enabled = false;
                btn_Themnv.Enabled = true;
                rb_Nam.Enabled = true;
                rb_Nu.Enabled = true;
            }
            catch
            {

            }
            
        }

        private void btn_Themnv_Click(object sender, EventArgs e)
        {
            btn_Luunv.Enabled = true;
            btn_Themnv.Enabled = false;
            btn_Xoanv.Enabled = false;
            rb_Nam.Enabled = rb_Nu.Enabled = btn_Luunv.Enabled = cbb_MaBP.Enabled = cbb_MaQL.Enabled = txt_DiaChi.Enabled = txt_MatKhau.Enabled = txt_NgaySinh.Enabled = txt_NgayVL.Enabled = txt_SDT.Enabled = txt_TenNV.Enabled = true;
            txt_MatKhau.Clear();
            txt_DiaChi.Clear();
            txt_NgaySinh.Clear();
            txt_NgayVL.Clear();
            txt_SDT.Clear();
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
            txt_TenNV.Clear();
            txt_MaNV.Enabled = false;
        }

        private void btn_Luunv_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rb_Nam.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            if (xlnv.kiemTraKhoaChinh(txt_MaNV.Text))
            {
                if (txt_MaNV.Text.Length > 0 && txt_DiaChi.Text.Length > 0 && txt_SDT.Text.Length > 0 && txt_TenNV.Text.Length > 0 && txt_MatKhau.Text.Length > 0)
                {
                    
                        if (xlnv.kiemTraKhoaChinh(txt_MaNV.Text))
                        {
                            if (DateTime.Parse(txt_NgayVL.Text).Year - DateTime.Parse(txt_NgaySinh.Text).Year > 18)
                            {
                                if (xlnv.themNhanVien(txt_MaNV.Text, txt_TenNV.Text, txt_NgaySinh.Text, gt, txt_DiaChi.Text, txt_SDT.Text, txt_NgayVL.Text, cbb_MaQL.SelectedValue.ToString(), cbb_MaBP.SelectedValue.ToString(), txt_MatKhau.Text))
                                {
                                    MessageBox.Show("Thêm Thành Công");
                                    QL_NhanVien_Load(sender, e);
                                    btn_Luunv.Enabled = false;
                                    btn_Themnv.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Thất Bại");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa đủ tuổi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
                        }
                  

                }
                else
                {
                    MessageBox.Show("Mời Bạn Nhập và Chọn Dữ Liệu");
                }
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_MaNV.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click vào bảng");
                    }
                    else
                    {
                        if (xlnv.suanv(txt_MaNV.Text.TrimEnd(), txt_TenNV.Text, txt_NgaySinh.Text, gt, txt_DiaChi.Text, txt_SDT.Text, txt_NgayVL.Text, cbb_MaQL.SelectedValue.ToString(), cbb_MaBP.SelectedValue.ToString(), txt_MatKhau.Text))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            QL_NhanVien_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btn_Xoanv_Click(object sender, EventArgs e)
        {
            if (!txt_MaNV.Enabled)
            {
                if (txt_MaNV.Text == string.Empty)
                {
                    MessageBox.Show("Mời bạn click vào bảng");
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (xlnv.xoanv(txt_MaNV.Text))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            QL_NhanVien_Load(sender, e);
                            txt_MaNV.Clear();
                            txt_MatKhau.Clear();
                            txt_DiaChi.Clear();
                            txt_NgaySinh.Clear();
                            txt_NgayVL.Clear();
                            txt_SDT.Clear();
                            rb_Nam.Checked = false;
                            rb_Nu.Checked = false;
                            txt_TenNV.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Xóa Nhân Viên Này");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời bạn click vào bảng");
            }
        }

        private void cms_Suanv_Click(object sender, EventArgs e)
        {
            string manv = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            string tennv = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            string ngaysinh = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            string gt = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            string diachi = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            string sdt = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
            string ngayvl = DateTime.Parse(dgv_NhanVien.CurrentRow.Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
            string maql = cbb_MaQL.SelectedValue.ToString();
            string mabp = cbb_MaBP.SelectedValue.ToString();
            string mk = dgv_NhanVien.CurrentRow.Cells[9].Value.ToString();
            if (tennv.Trim().Length == 0 || diachi.Trim().Length == 0 || ngaysinh.Trim().Length == 0 || gt.Trim().Length == 0 || diachi.Trim().Length == 0 || sdt.Trim().Length == 0 || ngayvl.Trim().Length == 0 || maql.Trim().Length == 0 || mabp.Trim().Length == 0 || mk.Trim().Length == 0)
            {
                MessageBox.Show("Nhập dữ liệu dô");
            }
            else
            {

                if (xlnv.suanv(manv, tennv, ngaysinh, gt, diachi, sdt, ngayvl, maql, mabp, mk))
                {
                    MessageBox.Show("Sửa Thành Công");
                    QL_NhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void cms_Xoanv_Click(object sender, EventArgs e)
        {
            string manv = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            if (manv.Trim().Length == 0)
            {
                MessageBox.Show("Mời nhập dữ liệu");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlnv.xoanv(manv))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        QL_NhanVien_Load(sender, e);
                        txt_MaNV.Clear();
                        txt_MatKhau.Clear();
                        txt_NgaySinh.Clear();
                        txt_NgayVL.Clear();
                        txt_SDT.Clear();
                        txt_MaNV.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
        }

        private void cms_Themnv_Click(object sender, EventArgs e)
        {
            string manv = dgv_NhanVien.CurrentRow.Cells[0].Value.ToString();
            string tennv = dgv_NhanVien.CurrentRow.Cells[1].Value.ToString();
            string ngaysinh = dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
            string gt = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
            string diachi = dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
            string sdt = dgv_NhanVien.CurrentRow.Cells[5].Value.ToString();
            string ngayvl = DateTime.Parse(dgv_NhanVien.CurrentRow.Cells[6].Value.ToString()).ToString("dd/MM/yyyy");
            string maql = dgv_NhanVien.CurrentRow.Cells[7].Value.ToString();
            string mabp = dgv_NhanVien.CurrentRow.Cells[8].Value.ToString();
            string mk = dgv_NhanVien.CurrentRow.Cells[9].Value.ToString();
            if (tennv.Trim().Length == 0 || diachi.Trim().Length == 0 || ngaysinh.Trim().Length == 0 || gt.Trim().Length == 0 || diachi.Trim().Length == 0 || sdt.Trim().Length == 0 || ngayvl.Trim().Length == 0 || maql.Trim().Length == 0 || mabp.Trim().Length == 0 || mk.Trim().Length == 0)
            {
                MessageBox.Show("Nhập dữ liệu dô");
            }
            else
            {
                if (xlnv.kiemTraKhoaChinh(manv))
                {
                    if (xlnv.themNhanVien(manv, tennv, ngaysinh, gt, diachi, sdt, ngayvl, maql, mabp, mk))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        QL_NhanVien_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Mã Đã Tồn Tại");
                }
            }
        }

        private void dgv_NguoiQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaQL.Text = dgv_NguoiQL.CurrentRow.Cells[0].Value.ToString();
            txt_TenQL.Text = dgv_NguoiQL.CurrentRow.Cells[1].Value.ToString();
            txt_NgaySinhql.Text = DateTime.Parse(dgv_NguoiQL.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
            string gt = dgv_NguoiQL.CurrentRow.Cells[3].Value.ToString();
            if (gt.TrimEnd() == "Nam")
                rd_Namql.Checked = true;
            else
                rd_Nuql.Checked = true;
            txt_sđtql.Text = dgv_NguoiQL.CurrentRow.Cells[4].Value.ToString();
            txt_MatKhauql.Text = dgv_NguoiQL.CurrentRow.Cells[5].Value.ToString();
            btn_Luql.Enabled = true;
            txt_MaQL.Enabled = false;
            btn_Xoaql.Enabled = true;
            //btn_Themql.Enabled = false;
            dgv_NhanVien.DataSource = xlnv.loadNVtheoql(txt_MaQL.Text);
            cbb_MaQL.Text = dgv_NguoiQL.CurrentRow.Cells[1].Value.ToString();
            txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = true;
        }

        private void btn_Themql_Click(object sender, EventArgs e)
        {
            txt_MaQL.Enabled = false;
            btn_Luql.Enabled = true;
            btn_Themql.Enabled = false;
            btn_Xoaql.Enabled = false;
            //txt_MaQL.Clear();
            txt_MatKhauql.Clear();
            txt_TenQL.Clear();
            txt_NgaySinhql.Clear();
            txt_sđtql.Clear();
            rd_Namql.Checked = false;
            rd_Nuql.Checked = false;
            txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = true;
        }

        private void btn_Luql_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rd_Namql.Checked)
                gt = "Nam";
            if (rd_Nuql.Checked)
                gt = "Nữ";
            if (xlnv.kiemTraKCQL(txt_MaQL.Text))
            {
                if (txt_MaQL.Text == string.Empty || txt_TenQL.Text == string.Empty || txt_sđtql.Text == string.Empty || txt_NgaySinhql.Text == string.Empty || txt_MatKhauql.Text == string.Empty || gt == string.Empty)
                {
                    MessageBox.Show("Mời Nhập dữ liệu");
                }
                else
                {
                    if (xlnv.kiemTraKCQL(txt_MaQL.Text))
                    {
                        if (xlnv.themQL(txt_MaQL.Text, txt_TenQL.Text, txt_NgaySinhql.Text, gt, txt_sđtql.Text, txt_MatKhauql.Text))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            cbb_MaQL.DataSource = xlnv.loadNhaQL();
                            cbb_MaQL.DisplayMember = "TenQL";
                            cbb_MaQL.ValueMember = "MaQL";
                            dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                            txt_MaQL.Enabled = txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = false;
                            btn_Themql.Enabled = true;
                            btn_Luql.Enabled = false;
                            //txt_MaQL.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại");
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
                    if (txt_MaQL.Text == string.Empty)
                    {
                        MessageBox.Show("Mời Chọn dữ liệu dữ liệu");
                    }
                    else
                    {
                        if (xlnv.suaQL(txt_MaQL.Text, txt_TenQL.Text, txt_NgaySinhql.Text, gt, txt_sđtql.Text, txt_MatKhauql.Text))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                            txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = false;
                            btn_Themql.Enabled = true;
                            btn_Luql.Enabled = false;
                            btn_Xoaql.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }
        }

        private void btn_Xoaql_Click(object sender, EventArgs e)
        {
            if (txt_MaQL.Text == string.Empty)
            {
                MessageBox.Show("Mời Chọn dữ liệu dữ liệu");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlnv.xoaql(txt_MaQL.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        cbb_MaQL.DataSource = xlnv.loadNhaQL();
                        cbb_MaQL.DisplayMember = "TenQL";
                        cbb_MaQL.ValueMember = "MaQL";
                        dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                        txt_MatKhauql.Enabled = txt_NgaySinhql.Enabled = txt_sđtql.Enabled = txt_TenQL.Enabled = rd_Namql.Enabled = rd_Nuql.Enabled = false;
                        txt_MaQL.Clear();
                        txt_MatKhauql.Clear();
                        txt_TenQL.Clear();
                        txt_NgaySinhql.Clear();
                        txt_sđtql.Clear();
                        rd_Namql.Checked = false;
                        rd_Nuql.Checked = false;
                        btn_Luql.Enabled = false;
                        btn_Xoaql.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
        }

        private void cms_ThemBP_Click(object sender, EventArgs e)
        {
            string mabp = dgv_BP.CurrentRow.Cells[0].Value.ToString();
            string tenbp = dgv_BP.CurrentRow.Cells[1].Value.ToString();
            if (mabp.TrimEnd() == string.Empty || tenbp.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Mời Bạn Nhập Dữ Liệu");
            }
            else
            {
                if (xlnv.kiemTraKCBP(mabp))
                {
                    if (xlnv.themBP(mabp, tenbp))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        cbb_MaBP.DataSource = xlnv.loadBP();
                        cbb_MaBP.DisplayMember = "TenBP";
                        cbb_MaBP.ValueMember = "MaBP";
                        dgv_BP.DataSource = xlnv.loadBP();
                        //btn_Themql.Enabled = true;
                        //btn_Luunv.Enabled = false;
                        //txt_MaQL.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }

                }
                else
                {
                    MessageBox.Show("Mã Đã Tồn Tại");
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cms_themql_Click(object sender, EventArgs e)
        {
            string maql = dgv_NguoiQL.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv_NguoiQL.CurrentRow.Cells[1].Value.ToString();
            string ngaysinh = dgv_NguoiQL.CurrentRow.Cells[2].Value.ToString();
            string gt = dgv_NguoiQL.CurrentRow.Cells[3].Value.ToString();
            string sdt = dgv_NguoiQL.CurrentRow.Cells[4].Value.ToString();
            string mk = dgv_NguoiQL.CurrentRow.Cells[5].Value.ToString();
            if (maql.TrimEnd() == string.Empty || ten.TrimEnd() == string.Empty || ngaysinh.TrimEnd() == string.Empty || sdt.TrimEnd() == string.Empty || gt.TrimEnd() == string.Empty || mk.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Mời Nhập Dữ Liệu");
            }
            else
            {
                if (xlnv.kiemTraKCQL(maql))
                {
                    if (xlnv.themQL(maql, ten, ngaysinh, gt, sdt, mk))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        cbb_MaQL.DataSource = xlnv.loadNhaQL();
                        cbb_MaQL.DisplayMember = "TenQL";
                        cbb_MaQL.ValueMember = "MaQL";
                        dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                        //btn_Themql.Enabled = true;
                        //btn_Luunv.Enabled = false;
                        //txt_MaQL.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }

                }
                else
                {
                    MessageBox.Show("Mã Đã Tồn Tại");
                }
            }
        }

        private void cms_xoaql_Click(object sender, EventArgs e)
        {
            string maql = dgv_NguoiQL.CurrentRow.Cells[0].Value.ToString();
            if (maql.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Mời Chọn Dữ Liệu Trong Bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlnv.xoaql(maql))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        cbb_MaQL.DataSource = xlnv.loadNhaQL();
                        cbb_MaQL.DisplayMember = "TenQL";
                        cbb_MaQL.ValueMember = "MaQL";
                        dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                        txt_MaQL.Clear();
                        txt_MatKhauql.Clear();
                        txt_TenQL.Clear();
                        txt_NgaySinhql.Clear();
                        txt_sđtql.Clear();
                        rd_Namql.Checked = false;
                        rd_Nuql.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
        }

        private void cms_suaql_Click(object sender, EventArgs e)
        {
            string maql = dgv_NguoiQL.CurrentRow.Cells[0].Value.ToString();
            string ten = dgv_NguoiQL.CurrentRow.Cells[1].Value.ToString();
            string ngaysinh = dgv_NguoiQL.CurrentRow.Cells[2].Value.ToString();
            string gt = dgv_NguoiQL.CurrentRow.Cells[3].Value.ToString();
            string sdt = dgv_NguoiQL.CurrentRow.Cells[4].Value.ToString();
            string mk = dgv_NguoiQL.CurrentRow.Cells[5].Value.ToString();
            if (maql.TrimEnd() == string.Empty || ten.TrimEnd() == string.Empty || ngaysinh.TrimEnd() == string.Empty || sdt.TrimEnd() == string.Empty || gt.TrimEnd() == string.Empty || mk.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Dữ Liệu Không được trống");
            }
            else
            {
                if (xlnv.suaQL(maql, ten, ngaysinh, gt, sdt, mk))
                {
                    MessageBox.Show("Sửa Thành Công");
                    cbb_MaQL.DataSource = xlnv.loadNhaQL();
                    cbb_MaQL.DisplayMember = "TenQL";
                    cbb_MaQL.ValueMember = "MaQL";
                    dgv_NguoiQL.DataSource = xlnv.loadNhaQL();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }           
        }

        private void cms_XoaBP_Click(object sender, EventArgs e)
        {
            string mabp = dgv_BP.CurrentRow.Cells[0].Value.ToString();
            if (mabp.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn dữ liệu trong bảng");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (xlnv.xoabp(mabp))
                    {
                        cbb_MaBP.DataSource = xlnv.loadBP();
                        cbb_MaBP.DisplayMember = "TenBP";
                        cbb_MaBP.ValueMember = "MaBP";
                        dgv_BP.DataSource = xlnv.loadBP();
                        MessageBox.Show("Xóa Thành Công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                }
            }
        }

        private void cms_SuaBP_Click(object sender, EventArgs e)
        {
            string mabp = dgv_BP.CurrentRow.Cells[0].Value.ToString();
            string tenbp = dgv_BP.CurrentRow.Cells[1].Value.ToString();
            if (mabp.TrimEnd() == string.Empty || tenbp.TrimEnd() == string.Empty)
            {
                MessageBox.Show("Không được để trống dữ liệu");
            }
            else
            {
                if (xlnv.suaBP(mabp, tenbp))
                {
                    MessageBox.Show("Sửa Thành Công");
                    cbb_MaBP.DataSource = xlnv.loadBP();
                    cbb_MaBP.DisplayMember = "TenBP";
                    cbb_MaBP.ValueMember = "MaBP";
                    dgv_BP.DataSource = xlnv.loadBP();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void dgv_BP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mabp = dgv_BP.CurrentRow.Cells[0].Value.ToString();
            cbb_MaBP.Text = dgv_BP.CurrentRow.Cells[1].Value.ToString();
            dgv_NhanVien.DataSource = xlnv.loadNVtheobp(mabp);
        }

        private void QL_NhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void QL_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn Chắc Chắn Muốn Đóng Form Không?", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txt_NgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_TaoMa_Click(object sender, EventArgs e)
        {
            int kq = xlnv.layMaQuanLy();
            kq = kq + 1;
            txt_MaQL.Text = "QL0" + kq.ToString();
            btn_Themql.Enabled = true;
            txt_MaQL.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = xlnv.layMaNV();
            kq++;
            txt_MaNV.Text = "NV0" + kq.ToString();
            txt_MaNV.Enabled = false;
        }

        private void grb_NhanVien_Enter(object sender, EventArgs e)
        {

        }
    }
}
