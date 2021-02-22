namespace QL_QuanCafe
{
    partial class QL_Ban_KhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_Ban_KhuyenMai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ck_GG = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Ban = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TrangThai = new System.Windows.Forms.TextBox();
            this.txt_SoCho = new System.Windows.Forms.TextBox();
            this.txt_TenBan = new System.Windows.Forms.TextBox();
            this.txt_MaBan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bn_TaoMaGiamGia = new System.Windows.Forms.Button();
            this.bn_XoaGG = new System.Windows.Forms.Button();
            this.bn_ThemGG = new System.Windows.Forms.Button();
            this.bn_LuuGG = new System.Windows.Forms.Button();
            this.dGVGiamGia = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Ngay = new System.Windows.Forms.DateTimePicker();
            this.txt_PhanTram = new System.Windows.Forms.TextBox();
            this.txt_MaGiamGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TaoMa = new System.Windows.Forms.Button();
            this.btn_XoaBan = new System.Windows.Forms.Button();
            this.btn_Luuban = new System.Windows.Forms.Button();
            this.btn_ThemBan = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiamGia)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin của bàn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ck_GG);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox3.Location = new System.Drawing.Point(780, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 51);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giảm giá";
            // 
            // ck_GG
            // 
            this.ck_GG.AutoSize = true;
            this.ck_GG.ForeColor = System.Drawing.Color.Black;
            this.ck_GG.Location = new System.Drawing.Point(26, 21);
            this.ck_GG.Name = "ck_GG";
            this.ck_GG.Size = new System.Drawing.Size(94, 21);
            this.ck_GG.TabIndex = 0;
            this.ck_GG.Text = "Giảm giá";
            this.ck_GG.UseVisualStyleBackColor = true;
            this.ck_GG.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 76);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = global::QL_QuanCafe.Properties.Resources.ICOADD;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QL_QuanCafe.Properties.Resources.Deleteico;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = global::QL_QuanCafe.Properties.Resources.sưa;
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // dgv_Ban
            // 
            this.dgv_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_Ban.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Ban.Location = new System.Drawing.Point(51, 259);
            this.dgv_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ban.Name = "dgv_Ban";
            this.dgv_Ban.Size = new System.Drawing.Size(905, 287);
            this.dgv_Ban.TabIndex = 67;
            this.dgv_Ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ban_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Số Chỗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tên Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã Bàn";
            // 
            // txt_TrangThai
            // 
            this.txt_TrangThai.Location = new System.Drawing.Point(580, 89);
            this.txt_TrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrangThai.Name = "txt_TrangThai";
            this.txt_TrangThai.Size = new System.Drawing.Size(199, 22);
            this.txt_TrangThai.TabIndex = 62;
            // 
            // txt_SoCho
            // 
            this.txt_SoCho.Location = new System.Drawing.Point(248, 89);
            this.txt_SoCho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoCho.Name = "txt_SoCho";
            this.txt_SoCho.Size = new System.Drawing.Size(132, 22);
            this.txt_SoCho.TabIndex = 61;
            this.txt_SoCho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCho_KeyPress);
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.Location = new System.Drawing.Point(580, 27);
            this.txt_TenBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Size = new System.Drawing.Size(199, 22);
            this.txt_TenBan.TabIndex = 60;
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.Location = new System.Drawing.Point(248, 27);
            this.txt_MaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Size = new System.Drawing.Size(132, 22);
            this.txt_MaBan.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bn_TaoMaGiamGia);
            this.groupBox2.Controls.Add(this.bn_XoaGG);
            this.groupBox2.Controls.Add(this.bn_ThemGG);
            this.groupBox2.Controls.Add(this.bn_LuuGG);
            this.groupBox2.Controls.Add(this.dGVGiamGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_Ngay);
            this.groupBox2.Controls.Add(this.txt_PhanTram);
            this.groupBox2.Controls.Add(this.txt_MaGiamGia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1028, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 548);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảm giá";
            // 
            // bn_TaoMaGiamGia
            // 
            this.bn_TaoMaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_TaoMaGiamGia.ForeColor = System.Drawing.Color.Blue;
            this.bn_TaoMaGiamGia.ImageKey = "Create-New-icon.png";
            this.bn_TaoMaGiamGia.ImageList = this.imageList1;
            this.bn_TaoMaGiamGia.Location = new System.Drawing.Point(67, 130);
            this.bn_TaoMaGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.bn_TaoMaGiamGia.Name = "bn_TaoMaGiamGia";
            this.bn_TaoMaGiamGia.Size = new System.Drawing.Size(103, 78);
            this.bn_TaoMaGiamGia.TabIndex = 72;
            this.bn_TaoMaGiamGia.Text = "Tạo Mã";
            this.bn_TaoMaGiamGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_TaoMaGiamGia.UseVisualStyleBackColor = true;
            this.bn_TaoMaGiamGia.Click += new System.EventHandler(this.bn_TaoMaGiamGia_Click);
            // 
            // bn_XoaGG
            // 
            this.bn_XoaGG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_XoaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_XoaGG.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_XoaGG.ImageKey = "Button-Close-icon.png";
            this.bn_XoaGG.ImageList = this.imageList1;
            this.bn_XoaGG.Location = new System.Drawing.Point(573, 130);
            this.bn_XoaGG.Margin = new System.Windows.Forms.Padding(4);
            this.bn_XoaGG.Name = "bn_XoaGG";
            this.bn_XoaGG.Size = new System.Drawing.Size(88, 78);
            this.bn_XoaGG.TabIndex = 71;
            this.bn_XoaGG.Text = "Xóa";
            this.bn_XoaGG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_XoaGG.UseVisualStyleBackColor = false;
            this.bn_XoaGG.Click += new System.EventHandler(this.bn_XoaGG_Click);
            // 
            // bn_ThemGG
            // 
            this.bn_ThemGG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_ThemGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_ThemGG.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_ThemGG.ImageKey = "Button-Add-icon.png";
            this.bn_ThemGG.ImageList = this.imageList1;
            this.bn_ThemGG.Location = new System.Drawing.Point(233, 130);
            this.bn_ThemGG.Margin = new System.Windows.Forms.Padding(4);
            this.bn_ThemGG.Name = "bn_ThemGG";
            this.bn_ThemGG.Size = new System.Drawing.Size(98, 78);
            this.bn_ThemGG.TabIndex = 70;
            this.bn_ThemGG.Text = "Thêm";
            this.bn_ThemGG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_ThemGG.UseVisualStyleBackColor = false;
            this.bn_ThemGG.Click += new System.EventHandler(this.bn_ThemGG_Click);
            // 
            // bn_LuuGG
            // 
            this.bn_LuuGG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bn_LuuGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_LuuGG.ForeColor = System.Drawing.Color.MediumBlue;
            this.bn_LuuGG.ImageKey = "Save-icon.png";
            this.bn_LuuGG.ImageList = this.imageList1;
            this.bn_LuuGG.Location = new System.Drawing.Point(403, 130);
            this.bn_LuuGG.Margin = new System.Windows.Forms.Padding(4);
            this.bn_LuuGG.Name = "bn_LuuGG";
            this.bn_LuuGG.Size = new System.Drawing.Size(90, 78);
            this.bn_LuuGG.TabIndex = 69;
            this.bn_LuuGG.Text = "Lưu";
            this.bn_LuuGG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bn_LuuGG.UseVisualStyleBackColor = false;
            this.bn_LuuGG.Click += new System.EventHandler(this.bn_LuuGG_Click);
            // 
            // dGVGiamGia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGVGiamGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGVGiamGia.ContextMenuStrip = this.contextMenuStrip2;
            this.dGVGiamGia.Location = new System.Drawing.Point(33, 216);
            this.dGVGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.dGVGiamGia.Name = "dGVGiamGia";
            this.dGVGiamGia.Size = new System.Drawing.Size(706, 287);
            this.dGVGiamGia.TabIndex = 68;
            this.dGVGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGiamGia_CellClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1,
            this.xóaToolStripMenuItem1,
            this.sửaToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 76);
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Image = global::QL_QuanCafe.Properties.Resources.ICOADD;
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem1.Text = "Thêm";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // xóaToolStripMenuItem1
            // 
            this.xóaToolStripMenuItem1.Image = global::QL_QuanCafe.Properties.Resources.Deleteico;
            this.xóaToolStripMenuItem1.Name = "xóaToolStripMenuItem1";
            this.xóaToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem1.Text = "Xóa";
            this.xóaToolStripMenuItem1.Click += new System.EventHandler(this.xóaToolStripMenuItem1_Click);
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Image = global::QL_QuanCafe.Properties.Resources.sưa;
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            this.sửaToolStripMenuItem1.Click += new System.EventHandler(this.sửaToolStripMenuItem1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày Sử dụng:";
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Ngay.Location = new System.Drawing.Point(440, 42);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(200, 22);
            this.txt_Ngay.TabIndex = 4;
            this.txt_Ngay.Value = new System.DateTime(2020, 12, 5, 10, 12, 5, 0);
            // 
            // txt_PhanTram
            // 
            this.txt_PhanTram.Location = new System.Drawing.Point(370, 87);
            this.txt_PhanTram.Name = "txt_PhanTram";
            this.txt_PhanTram.Size = new System.Drawing.Size(83, 22);
            this.txt_PhanTram.TabIndex = 3;
            this.txt_PhanTram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PhanTram_KeyPress);
            // 
            // txt_MaGiamGia
            // 
            this.txt_MaGiamGia.Location = new System.Drawing.Point(181, 40);
            this.txt_MaGiamGia.Name = "txt_MaGiamGia";
            this.txt_MaGiamGia.Size = new System.Drawing.Size(98, 22);
            this.txt_MaGiamGia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phần trăm giảm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Giảm giá:";
            // 
            // btn_TaoMa
            // 
            this.btn_TaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMa.ForeColor = System.Drawing.Color.Blue;
            this.btn_TaoMa.ImageKey = "Create-New-icon.png";
            this.btn_TaoMa.ImageList = this.imageList1;
            this.btn_TaoMa.Location = new System.Drawing.Point(103, 146);
            this.btn_TaoMa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoMa.Name = "btn_TaoMa";
            this.btn_TaoMa.Size = new System.Drawing.Size(100, 78);
            this.btn_TaoMa.TabIndex = 58;
            this.btn_TaoMa.Text = "Tạo Mã";
            this.btn_TaoMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TaoMa.UseVisualStyleBackColor = true;
            this.btn_TaoMa.Click += new System.EventHandler(this.btn_TaoMa_Click);
            // 
            // btn_XoaBan
            // 
            this.btn_XoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaBan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_XoaBan.ImageKey = "Button-Close-icon.png";
            this.btn_XoaBan.ImageList = this.imageList1;
            this.btn_XoaBan.Location = new System.Drawing.Point(708, 146);
            this.btn_XoaBan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaBan.Name = "btn_XoaBan";
            this.btn_XoaBan.Size = new System.Drawing.Size(100, 78);
            this.btn_XoaBan.TabIndex = 57;
            this.btn_XoaBan.Text = "Xóa";
            this.btn_XoaBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_XoaBan.UseVisualStyleBackColor = false;
            this.btn_XoaBan.Click += new System.EventHandler(this.btn_XoaBan_Click);
            // 
            // btn_Luuban
            // 
            this.btn_Luuban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Luuban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luuban.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Luuban.ImageKey = "Save-icon.png";
            this.btn_Luuban.ImageList = this.imageList1;
            this.btn_Luuban.Location = new System.Drawing.Point(502, 146);
            this.btn_Luuban.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luuban.Name = "btn_Luuban";
            this.btn_Luuban.Size = new System.Drawing.Size(100, 78);
            this.btn_Luuban.TabIndex = 55;
            this.btn_Luuban.Text = "Lưu";
            this.btn_Luuban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luuban.UseVisualStyleBackColor = false;
            this.btn_Luuban.Click += new System.EventHandler(this.btn_Luuban_Click);
            // 
            // btn_ThemBan
            // 
            this.btn_ThemBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ThemBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemBan.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_ThemBan.ImageKey = "Button-Add-icon.png";
            this.btn_ThemBan.ImageList = this.imageList1;
            this.btn_ThemBan.Location = new System.Drawing.Point(298, 146);
            this.btn_ThemBan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemBan.Name = "btn_ThemBan";
            this.btn_ThemBan.Size = new System.Drawing.Size(107, 78);
            this.btn_ThemBan.TabIndex = 56;
            this.btn_ThemBan.Text = "Thêm";
            this.btn_ThemBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThemBan.UseVisualStyleBackColor = false;
            this.btn_ThemBan.Click += new System.EventHandler(this.btn_ThemBan_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaGiamGia";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Giảm giá";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PhanTram";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phần trăm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayGiamGia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Sử dụng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBan";
            this.Column1.HeaderText = "Mã Bàn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBan";
            this.Column2.HeaderText = "Tên Bàn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoCho";
            this.Column3.HeaderText = "Số Chổ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // QL_Ban_KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1871, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_TaoMa);
            this.Controls.Add(this.btn_XoaBan);
            this.Controls.Add(this.btn_Luuban);
            this.Controls.Add(this.dgv_Ban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TrangThai);
            this.Controls.Add(this.txt_SoCho);
            this.Controls.Add(this.txt_TenBan);
            this.Controls.Add(this.txt_MaBan);
            this.Controls.Add(this.btn_ThemBan);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "QL_Ban_KhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_Ban";
            this.Load += new System.EventHandler(this.QL_Ban_KhuyenMai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiamGia)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoMa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_XoaBan;
        private System.Windows.Forms.Button btn_Luuban;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgv_Ban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TrangThai;
        private System.Windows.Forms.TextBox txt_SoCho;
        private System.Windows.Forms.TextBox txt_TenBan;
        private System.Windows.Forms.TextBox txt_MaBan;
        private System.Windows.Forms.Button btn_ThemBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ck_GG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.Button bn_TaoMaGiamGia;
        private System.Windows.Forms.Button bn_XoaGG;
        private System.Windows.Forms.Button bn_ThemGG;
        private System.Windows.Forms.Button bn_LuuGG;
        private System.Windows.Forms.DataGridView dGVGiamGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_Ngay;
        private System.Windows.Forms.TextBox txt_PhanTram;
        private System.Windows.Forms.TextBox txt_MaGiamGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}