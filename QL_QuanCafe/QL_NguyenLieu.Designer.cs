namespace QL_QuanCafe
{
    partial class QL_NguyenLieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_NguyenLieu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmt_Themnl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmt_XoaNl = new System.Windows.Forms.ToolStripMenuItem();
            this.cmt_suanl = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmt_Themncc = new System.Windows.Forms.ToolStripMenuItem();
            this.cmt_Xoancc = new System.Windows.Forms.ToolStripMenuItem();
            this.cmt_suancc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Loaimon = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_LoaiMon = new System.Windows.Forms.CheckBox();
            this.chk_ncc = new System.Windows.Forms.CheckBox();
            this.btn_TaoMa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_XoaNL = new System.Windows.Forms.Button();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.btn_ThemNL = new System.Windows.Forms.Button();
            this.cbb_LoaiMon = new System.Windows.Forms.ComboBox();
            this.btn_LuuNL = new System.Windows.Forms.Button();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.txt_TenNL = new System.Windows.Forms.TextBox();
            this.txt_MaNL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loaimon)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NL)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmt_Themnl,
            this.cmt_XoaNl,
            this.cmt_suanl});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 76);
            // 
            // cmt_Themnl
            // 
            this.cmt_Themnl.Image = global::QL_QuanCafe.Properties.Resources.ICOADD;
            this.cmt_Themnl.Name = "cmt_Themnl";
            this.cmt_Themnl.Size = new System.Drawing.Size(115, 24);
            this.cmt_Themnl.Text = "Thêm";
            this.cmt_Themnl.Click += new System.EventHandler(this.cmt_Themnl_Click);
            // 
            // cmt_XoaNl
            // 
            this.cmt_XoaNl.Image = global::QL_QuanCafe.Properties.Resources.Deleteico;
            this.cmt_XoaNl.Name = "cmt_XoaNl";
            this.cmt_XoaNl.Size = new System.Drawing.Size(115, 24);
            this.cmt_XoaNl.Text = "Xóa";
            this.cmt_XoaNl.Click += new System.EventHandler(this.cmt_XoaNl_Click);
            // 
            // cmt_suanl
            // 
            this.cmt_suanl.Image = global::QL_QuanCafe.Properties.Resources.sưa;
            this.cmt_suanl.Name = "cmt_suanl";
            this.cmt_suanl.Size = new System.Drawing.Size(115, 24);
            this.cmt_suanl.Text = "Sửa";
            this.cmt_suanl.Click += new System.EventHandler(this.cmt_suanl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_NCC);
            this.groupBox2.Location = new System.Drawing.Point(1089, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(721, 235);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhà Cung Cấp";
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgv_NCC.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_NCC.Location = new System.Drawing.Point(8, 23);
            this.dgv_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.Size = new System.Drawing.Size(705, 190);
            this.dgv_NCC.TabIndex = 0;
            this.dgv_NCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NCC_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNCC";
            this.Column7.HeaderText = "Mã NCC";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenNCC";
            this.Column8.HeaderText = "Tên NCC";
            this.Column8.Name = "Column8";
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "DChi";
            this.Column9.HeaderText = "Địa Chỉ";
            this.Column9.Name = "Column9";
            this.Column9.Width = 120;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DienThoai";
            this.Column10.HeaderText = "Điện Thoại";
            this.Column10.Name = "Column10";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmt_Themncc,
            this.cmt_Xoancc,
            this.cmt_suancc});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 76);
            // 
            // cmt_Themncc
            // 
            this.cmt_Themncc.Image = global::QL_QuanCafe.Properties.Resources.ICOADD;
            this.cmt_Themncc.Name = "cmt_Themncc";
            this.cmt_Themncc.Size = new System.Drawing.Size(115, 24);
            this.cmt_Themncc.Text = "Thêm";
            this.cmt_Themncc.Click += new System.EventHandler(this.cmt_Themncc_Click);
            // 
            // cmt_Xoancc
            // 
            this.cmt_Xoancc.Image = global::QL_QuanCafe.Properties.Resources.Deleteico;
            this.cmt_Xoancc.Name = "cmt_Xoancc";
            this.cmt_Xoancc.Size = new System.Drawing.Size(115, 24);
            this.cmt_Xoancc.Text = "Xóa";
            this.cmt_Xoancc.Click += new System.EventHandler(this.cmt_Xoancc_Click);
            // 
            // cmt_suancc
            // 
            this.cmt_suancc.Image = global::QL_QuanCafe.Properties.Resources.sưa;
            this.cmt_suancc.Name = "cmt_suancc";
            this.cmt_suancc.Size = new System.Drawing.Size(115, 24);
            this.cmt_suancc.Text = "Sửa";
            this.cmt_suancc.Click += new System.EventHandler(this.cmt_suancc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_Loaimon);
            this.groupBox3.Location = new System.Drawing.Point(1089, 269);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(721, 235);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Món";
            // 
            // dgv_Loaimon
            // 
            this.dgv_Loaimon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Loaimon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            this.dgv_Loaimon.Location = new System.Drawing.Point(8, 23);
            this.dgv_Loaimon.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Loaimon.Name = "dgv_Loaimon";
            this.dgv_Loaimon.Size = new System.Drawing.Size(705, 190);
            this.dgv_Loaimon.TabIndex = 1;
            this.dgv_Loaimon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loaimon_CellClick);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaLoai";
            this.Column11.HeaderText = "Mã Loại";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 230;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenLoai";
            this.Column12.HeaderText = "Tên Loại";
            this.Column12.Name = "Column12";
            this.Column12.Width = 250;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_TaoMa);
            this.panel1.Controls.Add(this.btn_XoaNL);
            this.panel1.Controls.Add(this.cbb_NCC);
            this.panel1.Controls.Add(this.btn_ThemNL);
            this.panel1.Controls.Add(this.cbb_LoaiMon);
            this.panel1.Controls.Add(this.btn_LuuNL);
            this.panel1.Controls.Add(this.txt_soLuongTon);
            this.panel1.Controls.Add(this.txt_DVT);
            this.panel1.Controls.Add(this.txt_TenNL);
            this.panel1.Controls.Add(this.txt_MaNL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 235);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_LoaiMon);
            this.groupBox1.Controls.Add(this.chk_ncc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(823, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 78);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác Khác";
            // 
            // chk_LoaiMon
            // 
            this.chk_LoaiMon.AutoSize = true;
            this.chk_LoaiMon.Location = new System.Drawing.Point(9, 49);
            this.chk_LoaiMon.Margin = new System.Windows.Forms.Padding(4);
            this.chk_LoaiMon.Name = "chk_LoaiMon";
            this.chk_LoaiMon.Size = new System.Drawing.Size(100, 22);
            this.chk_LoaiMon.TabIndex = 1;
            this.chk_LoaiMon.Text = "Loại Món";
            this.chk_LoaiMon.UseVisualStyleBackColor = true;
            this.chk_LoaiMon.CheckedChanged += new System.EventHandler(this.chk_LoaiMon_CheckedChanged);
            // 
            // chk_ncc
            // 
            this.chk_ncc.AutoSize = true;
            this.chk_ncc.Location = new System.Drawing.Point(9, 25);
            this.chk_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.chk_ncc.Name = "chk_ncc";
            this.chk_ncc.Size = new System.Drawing.Size(139, 22);
            this.chk_ncc.TabIndex = 0;
            this.chk_ncc.Text = "Nhà Cung Cấp";
            this.chk_ncc.UseVisualStyleBackColor = true;
            this.chk_ncc.CheckedChanged += new System.EventHandler(this.chk_ncc_CheckedChanged);
            // 
            // btn_TaoMa
            // 
            this.btn_TaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMa.ForeColor = System.Drawing.Color.Blue;
            this.btn_TaoMa.ImageKey = "Create-New-icon.png";
            this.btn_TaoMa.ImageList = this.imageList1;
            this.btn_TaoMa.Location = new System.Drawing.Point(79, 135);
            this.btn_TaoMa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoMa.Name = "btn_TaoMa";
            this.btn_TaoMa.Size = new System.Drawing.Size(100, 78);
            this.btn_TaoMa.TabIndex = 41;
            this.btn_TaoMa.Text = "Tạo Mã";
            this.btn_TaoMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TaoMa.UseVisualStyleBackColor = true;
            this.btn_TaoMa.Click += new System.EventHandler(this.btn_TaoMa_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Button-Add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Close-icon.png");
            this.imageList1.Images.SetKeyName(2, "Create-New-icon.png");
            this.imageList1.Images.SetKeyName(3, "edit-validated-icon.png");
            this.imageList1.Images.SetKeyName(4, "Save-icon.png");
            // 
            // btn_XoaNL
            // 
            this.btn_XoaNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XoaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNL.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_XoaNL.ImageKey = "Button-Close-icon.png";
            this.btn_XoaNL.ImageList = this.imageList1;
            this.btn_XoaNL.Location = new System.Drawing.Point(684, 135);
            this.btn_XoaNL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaNL.Name = "btn_XoaNL";
            this.btn_XoaNL.Size = new System.Drawing.Size(100, 78);
            this.btn_XoaNL.TabIndex = 40;
            this.btn_XoaNL.Text = "Xóa";
            this.btn_XoaNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_XoaNL.UseVisualStyleBackColor = false;
            this.btn_XoaNL.Click += new System.EventHandler(this.btn_XoaNL_Click);
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(823, 90);
            this.cbb_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(205, 24);
            this.cbb_NCC.TabIndex = 11;
            // 
            // btn_ThemNL
            // 
            this.btn_ThemNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ThemNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNL.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_ThemNL.ImageKey = "Button-Add-icon.png";
            this.btn_ThemNL.ImageList = this.imageList1;
            this.btn_ThemNL.Location = new System.Drawing.Point(273, 135);
            this.btn_ThemNL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemNL.Name = "btn_ThemNL";
            this.btn_ThemNL.Size = new System.Drawing.Size(107, 78);
            this.btn_ThemNL.TabIndex = 39;
            this.btn_ThemNL.Text = "Thêm";
            this.btn_ThemNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThemNL.UseVisualStyleBackColor = false;
            this.btn_ThemNL.Click += new System.EventHandler(this.btn_ThemNL_Click);
            // 
            // cbb_LoaiMon
            // 
            this.cbb_LoaiMon.FormattingEnabled = true;
            this.cbb_LoaiMon.Location = new System.Drawing.Point(432, 89);
            this.cbb_LoaiMon.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_LoaiMon.Name = "cbb_LoaiMon";
            this.cbb_LoaiMon.Size = new System.Drawing.Size(205, 24);
            this.cbb_LoaiMon.TabIndex = 10;
            // 
            // btn_LuuNL
            // 
            this.btn_LuuNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LuuNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LuuNL.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_LuuNL.ImageKey = "Save-icon.png";
            this.btn_LuuNL.ImageList = this.imageList1;
            this.btn_LuuNL.Location = new System.Drawing.Point(477, 135);
            this.btn_LuuNL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LuuNL.Name = "btn_LuuNL";
            this.btn_LuuNL.Size = new System.Drawing.Size(100, 78);
            this.btn_LuuNL.TabIndex = 38;
            this.btn_LuuNL.Text = "Lưu";
            this.btn_LuuNL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_LuuNL.UseVisualStyleBackColor = false;
            this.btn_LuuNL.Click += new System.EventHandler(this.btn_LuuNL_Click);
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.Location = new System.Drawing.Point(129, 89);
            this.txt_soLuongTon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soLuongTon.Name = "txt_soLuongTon";
            this.txt_soLuongTon.Size = new System.Drawing.Size(149, 22);
            this.txt_soLuongTon.TabIndex = 9;
            this.txt_soLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soLuongTon_KeyPress);
            // 
            // txt_DVT
            // 
            this.txt_DVT.Location = new System.Drawing.Point(863, 30);
            this.txt_DVT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(144, 22);
            this.txt_DVT.TabIndex = 8;
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Location = new System.Drawing.Point(524, 30);
            this.txt_TenNL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Size = new System.Drawing.Size(205, 22);
            this.txt_TenNL.TabIndex = 7;
            // 
            // txt_MaNL
            // 
            this.txt_MaNL.Location = new System.Drawing.Point(180, 30);
            this.txt_MaNL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNL.Name = "txt_MaNL";
            this.txt_MaNL.Size = new System.Drawing.Size(149, 22);
            this.txt_MaNL.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(661, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nhà Cung Cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(743, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nguyên Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nguyên Liệu";
            // 
            // dgv_NL
            // 
            this.dgv_NL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.TLoai,
            this.NCC});
            this.dgv_NL.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_NL.Location = new System.Drawing.Point(16, 269);
            this.dgv_NL.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NL.Name = "dgv_NL";
            this.dgv_NL.Size = new System.Drawing.Size(1055, 230);
            this.dgv_NL.TabIndex = 5;
            this.dgv_NL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NL_CellClick);
            this.dgv_NL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NL_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNL";
            this.Column1.HeaderText = "Mã Nguyên Liệu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNL";
            this.Column2.HeaderText = "Tên Nguyên Liệu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DVT";
            this.Column3.HeaderText = "Đơn Vị Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuongton";
            this.Column4.HeaderText = "Số Lượng Tồn";
            this.Column4.Name = "Column4";
            // 
            // TLoai
            // 
            this.TLoai.DataPropertyName = "MaLoai";
            this.TLoai.HeaderText = "Tên Loại";
            this.TLoai.Name = "TLoai";
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "MaNCC";
            this.NCC.HeaderText = "Nhà Cung Cấp";
            this.NCC.Name = "NCC";
            // 
            // QL_NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1827, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_NL);
            this.MaximizeBox = false;
            this.Name = "QL_NguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QL_NguyenLieu";
            this.Load += new System.EventHandler(this.QL_NguyenLieu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loaimon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmt_Themnl;
        private System.Windows.Forms.ToolStripMenuItem cmt_XoaNl;
        private System.Windows.Forms.ToolStripMenuItem cmt_suanl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmt_Themncc;
        private System.Windows.Forms.ToolStripMenuItem cmt_Xoancc;
        private System.Windows.Forms.ToolStripMenuItem cmt_suancc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Loaimon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_LoaiMon;
        private System.Windows.Forms.CheckBox chk_ncc;
        private System.Windows.Forms.Button btn_TaoMa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_XoaNL;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.Button btn_ThemNL;
        private System.Windows.Forms.ComboBox cbb_LoaiMon;
        private System.Windows.Forms.Button btn_LuuNL;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.TextBox txt_TenNL;
        private System.Windows.Forms.TextBox txt_MaNL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn TLoai;
        private System.Windows.Forms.DataGridViewComboBoxColumn NCC;

    }
}