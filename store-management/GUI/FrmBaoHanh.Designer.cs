namespace QuanLiCuaHang
{
    partial class FrmBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoHanh));
            this.dtPNgayBH = new System.Windows.Forms.DateTimePicker();
            this.dtPNGaySX = new System.Windows.Forms.DateTimePicker();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblNgayBH = new System.Windows.Forms.Label();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaxe = new System.Windows.Forms.Label();
            this.lblTTxe = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaBH = new System.Windows.Forms.Label();
            this.txtTTxe = new System.Windows.Forms.TextBox();
            this.txtMaBH = new System.Windows.Forms.TextBox();
            this.tolbtnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tolbtnSua = new System.Windows.Forms.ToolStripButton();
            this.tolbtnluu = new System.Windows.Forms.ToolStripButton();
            this.tolbtnXemin = new System.Windows.Forms.ToolStripButton();
            this.dgvBHanh = new System.Windows.Forms.DataGridView();
            this.cbxMaXe = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.cbxKH = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPNgayBH
            // 
            this.dtPNgayBH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNgayBH.Location = new System.Drawing.Point(513, 77);
            this.dtPNgayBH.Margin = new System.Windows.Forms.Padding(2);
            this.dtPNgayBH.Name = "dtPNgayBH";
            this.dtPNgayBH.Size = new System.Drawing.Size(151, 20);
            this.dtPNgayBH.TabIndex = 175;
            this.dtPNgayBH.TabStop = false;
            this.dtPNgayBH.Value = new System.DateTime(2021, 11, 23, 0, 0, 0, 0);
            // 
            // dtPNGaySX
            // 
            this.dtPNGaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNGaySX.Location = new System.Drawing.Point(513, 43);
            this.dtPNGaySX.Margin = new System.Windows.Forms.Padding(2);
            this.dtPNGaySX.Name = "dtPNGaySX";
            this.dtPNGaySX.Size = new System.Drawing.Size(151, 20);
            this.dtPNGaySX.TabIndex = 174;
            this.dtPNGaySX.TabStop = false;
            this.dtPNGaySX.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(226, 148);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(148, 20);
            this.txtGia.TabIndex = 173;
            // 
            // lblNgayBH
            // 
            this.lblNgayBH.AutoSize = true;
            this.lblNgayBH.Location = new System.Drawing.Point(417, 83);
            this.lblNgayBH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayBH.Name = "lblNgayBH";
            this.lblNgayBH.Size = new System.Drawing.Size(86, 13);
            this.lblNgayBH.TabIndex = 172;
            this.lblNgayBH.Text = "Ngày Bảo Hành:";
            // 
            // lblNgaySX
            // 
            this.lblNgaySX.AutoSize = true;
            this.lblNgaySX.Location = new System.Drawing.Point(417, 47);
            this.lblNgaySX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySX.Name = "lblNgaySX";
            this.lblNgaySX.Size = new System.Drawing.Size(78, 13);
            this.lblNgaySX.TabIndex = 170;
            this.lblNgaySX.Text = "Ngày sản xuất:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(129, 116);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(89, 13);
            this.lblTenKH.TabIndex = 171;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblMaxe
            // 
            this.lblMaxe.AutoSize = true;
            this.lblMaxe.Location = new System.Drawing.Point(130, 84);
            this.lblMaxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxe.Name = "lblMaxe";
            this.lblMaxe.Size = new System.Drawing.Size(39, 13);
            this.lblMaxe.TabIndex = 169;
            this.lblMaxe.Text = "Mã xe:";
            // 
            // lblTTxe
            // 
            this.lblTTxe.AutoSize = true;
            this.lblTTxe.Location = new System.Drawing.Point(416, 115);
            this.lblTTxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTTxe.Name = "lblTTxe";
            this.lblTTxe.Size = new System.Drawing.Size(72, 13);
            this.lblTTxe.TabIndex = 168;
            this.lblTTxe.Text = "Tình trạng xe:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(417, 147);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 167;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(130, 152);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(74, 13);
            this.lblGia.TabIndex = 166;
            this.lblGia.Text = "Giá bảo hành:";
            // 
            // lblMaBH
            // 
            this.lblMaBH.AutoSize = true;
            this.lblMaBH.Location = new System.Drawing.Point(130, 50);
            this.lblMaBH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaBH.Name = "lblMaBH";
            this.lblMaBH.Size = new System.Drawing.Size(73, 13);
            this.lblMaBH.TabIndex = 165;
            this.lblMaBH.Text = "Mã bảo hành:";
            // 
            // txtTTxe
            // 
            this.txtTTxe.Location = new System.Drawing.Point(513, 111);
            this.txtTTxe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTTxe.Name = "txtTTxe";
            this.txtTTxe.Size = new System.Drawing.Size(151, 20);
            this.txtTTxe.TabIndex = 164;
            // 
            // txtMaBH
            // 
            this.txtMaBH.Location = new System.Drawing.Point(226, 46);
            this.txtMaBH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBH.Name = "txtMaBH";
            this.txtMaBH.Size = new System.Drawing.Size(148, 20);
            this.txtMaBH.TabIndex = 160;
            // 
            // tolbtnThem
            // 
            this.tolbtnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnThem.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnThem.Image")));
            this.tolbtnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnThem.Name = "tolbtnThem";
            this.tolbtnThem.Size = new System.Drawing.Size(41, 22);
            this.tolbtnThem.Text = "Thêm";
            this.tolbtnThem.Click += new System.EventHandler(this.tolbtnThem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolbtnThem,
            this.tolbtnXoa,
            this.tolbtnSua,
            this.tolbtnluu,
            this.tolbtnXemin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 158;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tolbtnXoa
            // 
            this.tolbtnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnXoa.Image")));
            this.tolbtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnXoa.Name = "tolbtnXoa";
            this.tolbtnXoa.Size = new System.Drawing.Size(31, 22);
            this.tolbtnXoa.Text = "Xóa";
            this.tolbtnXoa.Click += new System.EventHandler(this.tolbtnXoa_Click);
            // 
            // tolbtnSua
            // 
            this.tolbtnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnSua.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnSua.Image")));
            this.tolbtnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnSua.Name = "tolbtnSua";
            this.tolbtnSua.Size = new System.Drawing.Size(30, 22);
            this.tolbtnSua.Text = "Sửa";
            this.tolbtnSua.Click += new System.EventHandler(this.tolbtnSua_Click);
            // 
            // tolbtnluu
            // 
            this.tolbtnluu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnluu.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnluu.Image")));
            this.tolbtnluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnluu.Name = "tolbtnluu";
            this.tolbtnluu.Size = new System.Drawing.Size(31, 22);
            this.tolbtnluu.Text = "Lưu";
            this.tolbtnluu.Click += new System.EventHandler(this.tolbtnluu_Click);
            // 
            // tolbtnXemin
            // 
            this.tolbtnXemin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnXemin.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnXemin.Image")));
            this.tolbtnXemin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnXemin.Name = "tolbtnXemin";
            this.tolbtnXemin.Size = new System.Drawing.Size(48, 22);
            this.tolbtnXemin.Text = "Xem in";
            this.tolbtnXemin.Click += new System.EventHandler(this.tolbtnXemin_Click);
            // 
            // dgvBHanh
            // 
            this.dgvBHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBHanh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBHanh.Location = new System.Drawing.Point(0, 199);
            this.dgvBHanh.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBHanh.Name = "dgvBHanh";
            this.dgvBHanh.RowTemplate.Height = 24;
            this.dgvBHanh.Size = new System.Drawing.Size(834, 150);
            this.dgvBHanh.TabIndex = 159;
            this.dgvBHanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBHanh_CellContentClick);
            // 
            // cbxMaXe
            // 
            this.cbxMaXe.FormattingEnabled = true;
            this.cbxMaXe.Location = new System.Drawing.Point(226, 81);
            this.cbxMaXe.Name = "cbxMaXe";
            this.cbxMaXe.Size = new System.Drawing.Size(148, 21);
            this.cbxMaXe.TabIndex = 176;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(513, 147);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(151, 21);
            this.cbxMaNV.TabIndex = 177;
            // 
            // cbxKH
            // 
            this.cbxKH.FormattingEnabled = true;
            this.cbxKH.Location = new System.Drawing.Point(225, 112);
            this.cbxKH.Name = "cbxKH";
            this.cbxKH.Size = new System.Drawing.Size(148, 21);
            this.cbxKH.TabIndex = 178;
            // 
            // FrmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 349);
            this.Controls.Add(this.cbxKH);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.cbxMaXe);
            this.Controls.Add(this.dtPNgayBH);
            this.Controls.Add(this.dtPNGaySX);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lblNgayBH);
            this.Controls.Add(this.lblNgaySX);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaxe);
            this.Controls.Add(this.lblTTxe);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblMaBH);
            this.Controls.Add(this.txtTTxe);
            this.Controls.Add(this.txtMaBH);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvBHanh);
            this.Name = "FrmBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo Hành";
            this.Load += new System.EventHandler(this.FrmBaoHanh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBHanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPNgayBH;
        private System.Windows.Forms.DateTimePicker dtPNGaySX;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblNgayBH;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaxe;
        private System.Windows.Forms.Label lblTTxe;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMaBH;
        private System.Windows.Forms.TextBox txtTTxe;
        private System.Windows.Forms.TextBox txtMaBH;
        private System.Windows.Forms.ToolStripButton tolbtnThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolbtnXoa;
        private System.Windows.Forms.ToolStripButton tolbtnSua;
        private System.Windows.Forms.ToolStripButton tolbtnluu;
        private System.Windows.Forms.ToolStripButton tolbtnXemin;
        private System.Windows.Forms.DataGridView dgvBHanh;
        private System.Windows.Forms.ComboBox cbxMaXe;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.ComboBox cbxKH;
    }
}