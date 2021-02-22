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
    public partial class QL_NguyenLieu : Form
    {
        public QL_NguyenLieu()
        {
            InitializeComponent();
        }
        Class_QL_NguyenLieu xlnl = new Class_QL_NguyenLieu();
        private void QL_NguyenLieu_Load(object sender, EventArgs e)
        {
            
            cbb_LoaiMon.DataSource = xlnl.loadcbbloaimon();
            cbb_LoaiMon.DisplayMember = "TenLoai";
            cbb_LoaiMon.ValueMember = "MaLoai";
            cbb_NCC.DataSource = xlnl.loadcbbncc();
            cbb_NCC.DisplayMember = "TenNCC";
            cbb_NCC.ValueMember = "MaNCC";
            TLoai.DataSource = xlnl.loadcbbloaimon();
            TLoai.DisplayMember = "TenLoai";
            TLoai.ValueMember = "MaLoai";
            NCC.DataSource = xlnl.loadcbbncc();
            NCC.DisplayMember = "TenNCC";
            NCC.ValueMember = "MaNCC";
            dgv_Loaimon.DataSource = xlnl.loadcbbloaimon();
            dgv_NCC.DataSource = xlnl.loadcbbncc();
            dgv_NL.DataSource = xlnl.loaddgvnl();
            txt_DVT.Enabled = txt_MaNL.Enabled = txt_soLuongTon.Enabled = txt_TenNL.Enabled = cbb_NCC.Enabled = cbb_LoaiMon.Enabled = btn_LuuNL.Enabled = btn_XoaNL.Enabled = false;
            Width = 830;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
        }

        private void btn_TaoMa_Click(object sender, EventArgs e)
        {
            int kq = xlnl.LayMaNL();
            kq++;
            txt_MaNL.Text = "NL0" + kq.ToString();
            btn_TaoMa.Enabled = false;
            btn_ThemNL.Enabled = true;
        }

        private void dgv_NL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_MaNL.Text = dgv_NL.CurrentRow.Cells[0].Value.ToString();
                txt_TenNL.Text = dgv_NL.CurrentRow.Cells[1].Value.ToString();
                txt_DVT.Text = dgv_NL.CurrentRow.Cells[2].Value.ToString();
                txt_soLuongTon.Text = dgv_NL.CurrentRow.Cells[3].Value.ToString();
                cbb_LoaiMon.SelectedValue = dgv_NL.CurrentRow.Cells[4].Value.ToString();
                cbb_NCC.SelectedValue = dgv_NL.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
            }
            btn_LuuNL.Enabled = true;
            btn_XoaNL.Enabled = true;
            btn_TaoMa.Enabled = true;
            txt_DVT.Enabled = txt_soLuongTon.Enabled = txt_TenNL.Enabled = cbb_NCC.Enabled = cbb_LoaiMon.Enabled = btn_LuuNL.Enabled = btn_XoaNL.Enabled = true;
        }

        private void dgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_NCC.Text = dgv_NCC.CurrentRow.Cells[1].Value.ToString();
            string ma = dgv_NCC.CurrentRow.Cells[0].Value.ToString();
            dgv_NL.DataSource = xlnl.loaddgvnltheoncc(ma);
        }

        private void dgv_Loaimon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_LoaiMon.Text = dgv_Loaimon.CurrentRow.Cells[1].Value.ToString();
            string ma = dgv_Loaimon.CurrentRow.Cells[0].Value.ToString();
            dgv_NL.DataSource = xlnl.loaddgvnltheolm(ma);
        }

        private void btn_ThemNL_Click(object sender, EventArgs e)
        {
            txt_DVT.Enabled = txt_soLuongTon.Enabled = txt_TenNL.Enabled = cbb_NCC.Enabled = cbb_LoaiMon.Enabled = btn_LuuNL.Enabled = btn_XoaNL.Enabled = true;
            txt_DVT.Clear();
            txt_soLuongTon.Clear();
            txt_TenNL.Clear();
            cbb_LoaiMon.SelectedIndex = 0;
            cbb_NCC.SelectedIndex = 0;
            btn_LuuNL.Enabled = true;
            btn_XoaNL.Enabled = false;
        }

        private void btn_LuuNL_Click(object sender, EventArgs e)
        {
            if (!btn_TaoMa.Enabled)
            {
                if (txt_DVT.Text == string.Empty || txt_MaNL.Text == string.Empty || txt_soLuongTon.Text == string.Empty || int.Parse(txt_soLuongTon.Text) < 0 || txt_TenNL.Text == string.Empty)
                {
                    MessageBox.Show("Mời Bạn Nhập Dữ Liệu Đầy Đủ");
                }
                else
                {
                    if (xlnl.kiemTraKCNL(txt_MaNL.Text))
                    {
                        if (xlnl.them(txt_MaNL.Text, txt_TenNL.Text, txt_DVT.Text, int.Parse(txt_soLuongTon.Text), cbb_LoaiMon.SelectedValue.ToString(), cbb_NCC.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Thêm Thành Công");
                            btn_TaoMa.Enabled = true;
                            dgv_NL.DataSource = xlnl.loaddgvnl();
                            txt_DVT.Clear();
                            txt_soLuongTon.Clear();
                            txt_TenNL.Clear();
                            cbb_LoaiMon.SelectedIndex = 0;
                            cbb_NCC.SelectedIndex = 0;
                            txt_MaNL.Clear();
                            btn_LuuNL.Enabled = false;
                            btn_ThemNL.Enabled = true;
                            txt_DVT.Enabled = txt_MaNL.Enabled = txt_soLuongTon.Enabled = txt_TenNL.Enabled = cbb_NCC.Enabled = cbb_LoaiMon.Enabled = btn_LuuNL.Enabled = btn_XoaNL.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại");
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
                if (MessageBox.Show("Bạn Có Muốn Sửa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txt_DVT.Text == string.Empty || txt_MaNL.Text == string.Empty || txt_soLuongTon.Text == string.Empty || int.Parse(txt_soLuongTon.Text) < 0 || txt_TenNL.Text == string.Empty)
                    {
                        MessageBox.Show("Mời bạn click dữ liệu trong bảng");
                    }
                    else
                    {
                        if (xlnl.sua(txt_MaNL.Text, txt_TenNL.Text, txt_DVT.Text, int.Parse(txt_soLuongTon.Text), cbb_LoaiMon.SelectedValue.ToString(), cbb_NCC.SelectedValue.ToString()))
                        {
                            MessageBox.Show("Sửa Thành Công");
                            dgv_NL.DataSource = xlnl.loaddgvnl();
                            txt_DVT.Clear();
                            txt_soLuongTon.Clear();
                            txt_TenNL.Clear();
                            cbb_LoaiMon.SelectedIndex = 0;
                            cbb_NCC.SelectedIndex = 0;
                            txt_MaNL.Clear();
                            btn_LuuNL.Enabled = false;
                            btn_XoaNL.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa Thất Bại");
                        }
                    }
                }
            }
        }

        private void btn_XoaNL_Click(object sender, EventArgs e)
        {
            if (txt_MaNL.Text == string.Empty)
            {
                MessageBox.Show("Mời bạn Click dữ liệu");
            }
            else
            {
                if (xlnl.xoa(txt_MaNL.Text))
                {
                    MessageBox.Show("Xóa Thành Công");
                    btn_XoaNL.Enabled = false;
                    dgv_NL.DataSource = xlnl.loaddgvnl();
                    txt_DVT.Clear();
                    txt_soLuongTon.Clear();
                    txt_TenNL.Clear();
                    cbb_LoaiMon.SelectedIndex = 0;
                    cbb_NCC.SelectedIndex = 0;
                    txt_MaNL.Clear();
                    btn_XoaNL.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void chk_ncc_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ncc.Checked)
            {
                if (chk_LoaiMon.Checked)
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = true;
                    Width = 1386;
                    groupBox3.Location = new System.Drawing.Point(817, 219);
                    groupBox2.Location = new System.Drawing.Point(817, 12);
                }
                else
                {
                    groupBox3.Visible = false;
                    groupBox2.Visible = true;
                    Width = 1386;
                }
            }
            else if (!chk_ncc.Checked && !chk_LoaiMon.Checked)
            {
                groupBox2.Visible = false;
                Width = 830;
                dgv_NL.DataSource = xlnl.loaddgvnl();
            }
            else if (!chk_ncc.Checked && chk_LoaiMon.Checked)
            {
                groupBox3.Visible = true;
                //groupBox2.Visible = false;
                Width = 1386;
                groupBox3.Location = new System.Drawing.Point(817, 12);
                dgv_NL.DataSource = xlnl.loaddgvnl();
            }
            else
            {
                groupBox2.Visible = false;
                Width = 1386;
                dgv_NL.DataSource = xlnl.loaddgvnl();
            }
        }

        private void chk_LoaiMon_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_LoaiMon.Checked)
            {
                if (chk_ncc.Checked)
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = true;
                    Width = 1386;
                    groupBox3.Location = new System.Drawing.Point(817, 219);
                    groupBox2.Location = new System.Drawing.Point(817, 12);
                }
                else
                {
                    groupBox3.Visible = true;
                    groupBox2.Visible = false;
                    Width = 1386;
                    groupBox3.Location = new System.Drawing.Point(817, 12);
                }
            }
            else if (!chk_LoaiMon.Checked && !chk_ncc.Checked)
            {
                groupBox3.Visible = false;
                Width = 830;
                dgv_NL.DataSource = xlnl.loaddgvnl();
            }
            else
            {
                groupBox3.Visible = false;
                Width = 1386;
                dgv_NL.DataSource = xlnl.loaddgvnl();
            }
        }

        private void cmt_Themncc_Click(object sender, EventArgs e)
        {
            string mancc = dgv_NCC.CurrentRow.Cells[0].Value.ToString();
            string tenncc = dgv_NCC.CurrentRow.Cells[1].Value.ToString();
            string diachi = dgv_NCC.CurrentRow.Cells[2].Value.ToString();
            string sdt = dgv_NCC.CurrentRow.Cells[3].Value.ToString();
            if (mancc == string.Empty || tenncc == string.Empty || diachi == string.Empty || sdt == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ dữ liệu");
            }
            else
            {
                if (xlnl.kiemTraKCNCC(mancc))
                {
                    if (xlnl.themncc(mancc, tenncc, diachi, sdt))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        cbb_NCC.DataSource = xlnl.loadcbbncc();
                        cbb_NCC.DisplayMember = "TenNCC";
                        cbb_NCC.ValueMember = "MaNCC";
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng Khóa Chính");
                }
            }
        }

        private void cmt_Themnl_Click(object sender, EventArgs e)
        {
            string manl = dgv_NL.CurrentRow.Cells[0].Value.ToString();
            string tennl = dgv_NL.CurrentRow.Cells[1].Value.ToString();
            string dvt = dgv_NL.CurrentRow.Cells[2].Value.ToString();
            string sl = dgv_NL.CurrentRow.Cells[3].Value.ToString();
            string maloai = dgv_NL.CurrentRow.Cells[4].Value.ToString();
            string mancc = dgv_NL.CurrentRow.Cells[5].Value.ToString();
            if (manl == string.Empty || tennl == string.Empty || dvt == string.Empty || sl == string.Empty || maloai == string.Empty || mancc == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ nha");
            }
            else
            {
                if (xlnl.kiemTraKCNL(manl))
                {
                    if (xlnl.them(manl, tennl, dvt, int.Parse(sl), maloai, mancc))
                    {
                        MessageBox.Show("Thêm Thành Công");
                        dgv_NL.DataSource = xlnl.loaddgvnl();
                        txt_DVT.Enabled = txt_MaNL.Enabled = txt_soLuongTon.Enabled = txt_TenNL.Enabled = cbb_NCC.Enabled = cbb_LoaiMon.Enabled = btn_LuuNL.Enabled = btn_XoaNL.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Trùng Khóa Chính");
                }
            }
        }

        private void cmt_suanl_Click(object sender, EventArgs e)
        {
            string manl = dgv_NL.CurrentRow.Cells[0].Value.ToString();
            string tennl = dgv_NL.CurrentRow.Cells[1].Value.ToString();
            string dvt = dgv_NL.CurrentRow.Cells[2].Value.ToString();
            string sl = dgv_NL.CurrentRow.Cells[3].Value.ToString();
            string maloai = cbb_LoaiMon.SelectedValue.ToString();
            string mancc = cbb_NCC.SelectedValue.ToString();
            if (manl == string.Empty || tennl == string.Empty || dvt == string.Empty || sl == string.Empty || maloai == string.Empty || mancc == string.Empty)
            {
                MessageBox.Show("Mời bạn nhập và chọn dữ liệu cần sửa");
            }
            else
            {
                if (xlnl.sua(manl, tennl, dvt, int.Parse(sl), maloai, mancc))
                {
                    MessageBox.Show("Sửa Thành Công");
                    dgv_NL.DataSource = xlnl.loaddgvnl();
                    txt_DVT.Clear();
                    txt_soLuongTon.Clear();
                    txt_TenNL.Clear();
                    cbb_LoaiMon.SelectedIndex = 0;
                    cbb_NCC.SelectedIndex = 0;
                    txt_MaNL.Clear();
                    btn_LuuNL.Enabled = false;
                    btn_XoaNL.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void cmt_XoaNl_Click(object sender, EventArgs e)
        {
            string manl = dgv_NL.CurrentRow.Cells[0].Value.ToString();
            if (manl == string.Empty)
            {
                MessageBox.Show("Mời bạn Click vào bảng");
            }
            else
            {
                if (xlnl.xoa(manl))
                {
                    MessageBox.Show("Xóa Thành Công");
                    btn_XoaNL.Enabled = false;
                    dgv_NL.DataSource = xlnl.loaddgvnl();
                    txt_DVT.Clear();
                    txt_soLuongTon.Clear();
                    txt_TenNL.Clear();
                    cbb_LoaiMon.SelectedIndex = 0;
                    cbb_NCC.SelectedIndex = 0;
                    txt_MaNL.Clear();
                    btn_XoaNL.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }

        private void cmt_Xoancc_Click(object sender, EventArgs e)
        {
            string mancc = dgv_NCC.CurrentRow.Cells[0].Value.ToString();
            if (mancc == string.Empty)
            {
                MessageBox.Show("Mời bạn chọn vào bảng");
            }
            else
            {
                if (xlnl.xoancc(mancc))
                {
                    MessageBox.Show("Xóa Thành Công");
                    cbb_NCC.DataSource = xlnl.loadcbbncc();
                    cbb_NCC.DisplayMember = "TenNCC";
                    cbb_NCC.ValueMember = "MaNCC";
                    dgv_NCC.DataSource = xlnl.loadcbbncc();
                }
                else
                {
                    MessageBox.Show("Không thể Xóa được");
                }
            }
        }

        private void cmt_suancc_Click(object sender, EventArgs e)
        {
            string mancc = dgv_NCC.CurrentRow.Cells[0].Value.ToString();
            string tenncc = dgv_NCC.CurrentRow.Cells[1].Value.ToString();
            string diachi = dgv_NCC.CurrentRow.Cells[2].Value.ToString();
            string sdt = dgv_NCC.CurrentRow.Cells[3].Value.ToString();
            if (mancc == string.Empty || tenncc == string.Empty || diachi == string.Empty || sdt == string.Empty)
            {
                MessageBox.Show("Mời bạn Click vào dòng bạn muốn sửa");
            }
            else
            {
                if (xlnl.suancc(mancc, tenncc, diachi, sdt))
                {
                    MessageBox.Show("Sửa Thành Công");
                    cbb_NCC.DataSource = xlnl.loadcbbncc();
                    cbb_NCC.DisplayMember = "TenNCC";
                    cbb_NCC.ValueMember = "MaNCC";
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void txt_soLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_NL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
