namespace QL_QuanCafe
{
    partial class QL_MonAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_MonAn));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_Dvt = new System.Windows.Forms.TextBox();
            this.txt_TenMon = new System.Windows.Forms.TextBox();
            this.txt_MaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiMon = new System.Windows.Forms.ComboBox();
            this.dgv_Menu = new System.Windows.Forms.DataGridView();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.Bn_File = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HinhMon = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_XoaMon = new System.Windows.Forms.Button();
            this.btn_Themmon = new System.Windows.Forms.Button();
            this.btn_Luumon = new System.Windows.Forms.Button();
            this.btn_TaoMa = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.xóaToolStripMenuItem,
            this.sửaToolStripMenuItem1,
            this.thêmToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 76);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::QL_QuanCafe.Properties.Resources.Deleteico;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem1
            // 
            this.sửaToolStripMenuItem1.Image = global::QL_QuanCafe.Properties.Resources.sưa;
            this.sửaToolStripMenuItem1.Name = "sửaToolStripMenuItem1";
            this.sửaToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.sửaToolStripMenuItem1.Text = "Sửa";
            this.sửaToolStripMenuItem1.Click += new System.EventHandler(this.sửaToolStripMenuItem1_Click);
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.Image = global::QL_QuanCafe.Properties.Resources.ICOADD;
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.thêmToolStripMenuItem1.Text = "Thêm";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(862, 160);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(149, 22);
            this.txt_Gia.TabIndex = 65;
            this.txt_Gia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Gia_KeyPress);
            // 
            // txt_Dvt
            // 
            this.txt_Dvt.Location = new System.Drawing.Point(251, 152);
            this.txt_Dvt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Dvt.Name = "txt_Dvt";
            this.txt_Dvt.Size = new System.Drawing.Size(149, 22);
            this.txt_Dvt.TabIndex = 63;
            // 
            // txt_TenMon
            // 
            this.txt_TenMon.Location = new System.Drawing.Point(546, 82);
            this.txt_TenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMon.Name = "txt_TenMon";
            this.txt_TenMon.Size = new System.Drawing.Size(239, 22);
            this.txt_TenMon.TabIndex = 62;
            // 
            // txt_MaMon
            // 
            this.txt_MaMon.Location = new System.Drawing.Point(218, 82);
            this.txt_MaMon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaMon.Name = "txt_MaMon";
            this.txt_MaMon.Size = new System.Drawing.Size(183, 22);
            this.txt_MaMon.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Hình Ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Tên Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã Món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Loại Món";
            // 
            // cbb_LoaiMon
            // 
            this.cbb_LoaiMon.FormattingEnabled = true;
            this.cbb_LoaiMon.Location = new System.Drawing.Point(375, 30);
            this.cbb_LoaiMon.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_LoaiMon.Name = "cbb_LoaiMon";
            this.cbb_LoaiMon.Size = new System.Drawing.Size(221, 24);
            this.cbb_LoaiMon.TabIndex = 51;
            this.cbb_LoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiMon_SelectedIndexChanged);
            // 
            // dgv_Menu
            // 
            this.dgv_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.MaLoai,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_Menu.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Menu.Location = new System.Drawing.Point(20, 323);
            this.dgv_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Menu.Name = "dgv_Menu";
            this.dgv_Menu.Size = new System.Drawing.Size(1036, 256);
            this.dgv_Menu.TabIndex = 66;
            this.dgv_Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Menu_CellClick);
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Enabled = false;
            this.txt_HinhAnh.Location = new System.Drawing.Point(556, 160);
            this.txt_HinhAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(133, 22);
            this.txt_HinhAnh.TabIndex = 67;
            // 
            // Bn_File
            // 
            this.Bn_File.Location = new System.Drawing.Point(711, 156);
            this.Bn_File.Name = "Bn_File";
            this.Bn_File.Size = new System.Drawing.Size(62, 31);
            this.Bn_File.TabIndex = 68;
            this.Bn_File.Text = "File";
            this.Bn_File.UseVisualStyleBackColor = true;
            this.Bn_File.Click += new System.EventHandler(this.Bn_File_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HinhMon
            // 
            this.HinhMon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.HinhMon.ImageSize = new System.Drawing.Size(16, 16);
            this.HinhMon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(831, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 125);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // btn_XoaMon
            // 
            this.btn_XoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_XoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMon.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_XoaMon.ImageKey = "Button-Close-icon.png";
            this.btn_XoaMon.ImageList = this.imageList1;
            this.btn_XoaMon.Location = new System.Drawing.Point(831, 219);
            this.btn_XoaMon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaMon.Name = "btn_XoaMon";
            this.btn_XoaMon.Size = new System.Drawing.Size(100, 78);
            this.btn_XoaMon.TabIndex = 55;
            this.btn_XoaMon.Text = "Xóa";
            this.btn_XoaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_XoaMon.UseVisualStyleBackColor = false;
            this.btn_XoaMon.Click += new System.EventHandler(this.btn_XoaMon_Click);
            // 
            // btn_Themmon
            // 
            this.btn_Themmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Themmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themmon.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Themmon.ImageKey = "Button-Add-icon.png";
            this.btn_Themmon.ImageList = this.imageList1;
            this.btn_Themmon.Location = new System.Drawing.Point(357, 219);
            this.btn_Themmon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Themmon.Name = "btn_Themmon";
            this.btn_Themmon.Size = new System.Drawing.Size(107, 78);
            this.btn_Themmon.TabIndex = 54;
            this.btn_Themmon.Text = "Thêm";
            this.btn_Themmon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Themmon.UseVisualStyleBackColor = false;
            this.btn_Themmon.Click += new System.EventHandler(this.btn_Themmon_Click);
            // 
            // btn_Luumon
            // 
            this.btn_Luumon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Luumon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luumon.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Luumon.ImageKey = "Save-icon.png";
            this.btn_Luumon.ImageList = this.imageList1;
            this.btn_Luumon.Location = new System.Drawing.Point(623, 219);
            this.btn_Luumon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luumon.Name = "btn_Luumon";
            this.btn_Luumon.Size = new System.Drawing.Size(100, 78);
            this.btn_Luumon.TabIndex = 53;
            this.btn_Luumon.Text = "Lưu";
            this.btn_Luumon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luumon.UseVisualStyleBackColor = false;
            this.btn_Luumon.Click += new System.EventHandler(this.btn_Luumon_Click);
            // 
            // btn_TaoMa
            // 
            this.btn_TaoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoMa.ForeColor = System.Drawing.Color.Blue;
            this.btn_TaoMa.ImageKey = "Create-New-icon.png";
            this.btn_TaoMa.ImageList = this.imageList1;
            this.btn_TaoMa.Location = new System.Drawing.Point(127, 219);
            this.btn_TaoMa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoMa.Name = "btn_TaoMa";
            this.btn_TaoMa.Size = new System.Drawing.Size(100, 78);
            this.btn_TaoMa.TabIndex = 71;
            this.btn_TaoMa.Text = "Tạo Mã";
            this.btn_TaoMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_TaoMa.UseVisualStyleBackColor = true;
            this.btn_TaoMa.Click += new System.EventHandler(this.btn_TaoMa_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaMon";
            this.Column1.HeaderText = "Mã Món";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMon";
            this.Column2.HeaderText = "Tên Món";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DVT";
            this.Column4.HeaderText = "Đơn Vị Tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HinhAnh";
            this.Column5.HeaderText = "Hình Ảnh";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.Name = "Column6";
            // 
            // QL_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1069, 609);
            this.Controls.Add(this.btn_TaoMa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bn_File);
            this.Controls.Add(this.txt_HinhAnh);
            this.Controls.Add(this.dgv_Menu);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txt_Dvt);
            this.Controls.Add(this.txt_TenMon);
            this.Controls.Add(this.txt_MaMon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_XoaMon);
            this.Controls.Add(this.btn_Themmon);
            this.Controls.Add(this.btn_Luumon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_LoaiMon);
            this.MaximizeBox = false;
            this.Name = "QL_MonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_MonAn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_MonAn_FormClosing);
            this.Load += new System.EventHandler(this.QL_MonAn_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_Dvt;
        private System.Windows.Forms.TextBox txt_TenMon;
        private System.Windows.Forms.TextBox txt_MaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XoaMon;
        private System.Windows.Forms.Button btn_Themmon;
        private System.Windows.Forms.Button btn_Luumon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LoaiMon;
        private System.Windows.Forms.DataGridView dgv_Menu;
        private System.Windows.Forms.TextBox txt_HinhAnh;
        private System.Windows.Forms.Button Bn_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList HinhMon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_TaoMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}