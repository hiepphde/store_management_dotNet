namespace QuanLiCuaHang
{
    partial class FrmHDNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHDNhap));
            this.dtPNgaylap = new System.Windows.Forms.DateTimePicker();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.tolbtnluu = new System.Windows.Forms.ToolStripButton();
            this.tolbtnSua = new System.Windows.Forms.ToolStripButton();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblGianhap = new System.Windows.Forms.Label();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblMaCC = new System.Windows.Forms.Label();
            this.lblMaxe = new System.Windows.Forms.Label();
            this.lblMaNhap = new System.Windows.Forms.Label();
            this.tolbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.tolbtnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tolbtnXemin = new System.Windows.Forms.ToolStripButton();
            this.dgvHDNhap = new System.Windows.Forms.DataGridView();
            this.cbxMaXe = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPNgaylap
            // 
            this.dtPNgaylap.Location = new System.Drawing.Point(175, 147);
            this.dtPNgaylap.Margin = new System.Windows.Forms.Padding(2);
            this.dtPNgaylap.Name = "dtPNgaylap";
            this.dtPNgaylap.Size = new System.Drawing.Size(156, 20);
            this.dtPNgaylap.TabIndex = 102;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(310, 193);
            this.lblTongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(55, 13);
            this.lblTongtien.TabIndex = 101;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(491, 155);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(43, 13);
            this.lblMaNV.TabIndex = 100;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(412, 190);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(156, 20);
            this.txtTongtien.TabIndex = 99;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(616, 115);
            this.txtThue.Margin = new System.Windows.Forms.Padding(2);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(156, 20);
            this.txtThue.TabIndex = 98;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(616, 79);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(156, 20);
            this.txtGia.TabIndex = 96;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(616, 45);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(156, 20);
            this.txtSoluong.TabIndex = 93;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(175, 43);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(156, 20);
            this.txtNhap.TabIndex = 92;
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
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(491, 115);
            this.lblThue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(35, 13);
            this.lblThue.TabIndex = 91;
            this.lblThue.Text = "Thuế:\r\n";
            // 
            // lblGianhap
            // 
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.Location = new System.Drawing.Point(491, 83);
            this.lblGianhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(53, 13);
            this.lblGianhap.TabIndex = 90;
            this.lblGianhap.Text = "Giá nhập:";
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Location = new System.Drawing.Point(66, 155);
            this.lblNgaylap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(52, 13);
            this.lblNgaylap.TabIndex = 89;
            this.lblNgaylap.Text = "Ngày lập:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(491, 49);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(52, 13);
            this.lblSoluong.TabIndex = 88;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // lblMaCC
            // 
            this.lblMaCC.AutoSize = true;
            this.lblMaCC.Location = new System.Drawing.Point(66, 115);
            this.lblMaCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCC.Name = "lblMaCC";
            this.lblMaCC.Size = new System.Drawing.Size(97, 13);
            this.lblMaCC.TabIndex = 87;
            this.lblMaCC.Text = "Mã  nhà cung cấp:";
            // 
            // lblMaxe
            // 
            this.lblMaxe.AutoSize = true;
            this.lblMaxe.Location = new System.Drawing.Point(66, 78);
            this.lblMaxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxe.Name = "lblMaxe";
            this.lblMaxe.Size = new System.Drawing.Size(39, 13);
            this.lblMaxe.TabIndex = 86;
            this.lblMaxe.Text = "Mã xe:";
            // 
            // lblMaNhap
            // 
            this.lblMaNhap.AutoSize = true;
            this.lblMaNhap.Location = new System.Drawing.Point(66, 47);
            this.lblMaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhap.Name = "lblMaNhap";
            this.lblMaNhap.Size = new System.Drawing.Size(95, 13);
            this.lblMaNhap.TabIndex = 85;
            this.lblMaNhap.Text = "Mã hóa đơn nhập:";
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
            this.toolStrip1.Size = new System.Drawing.Size(901, 25);
            this.toolStrip1.TabIndex = 84;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tolbtnXemin
            // 
            this.tolbtnXemin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tolbtnXemin.Image = ((System.Drawing.Image)(resources.GetObject("tolbtnXemin.Image")));
            this.tolbtnXemin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolbtnXemin.Name = "tolbtnXemin";
            this.tolbtnXemin.Size = new System.Drawing.Size(48, 22);
            this.tolbtnXemin.Text = "Xem in";
            // 
            // dgvHDNhap
            // 
            this.dgvHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHDNhap.Location = new System.Drawing.Point(0, 219);
            this.dgvHDNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHDNhap.Name = "dgvHDNhap";
            this.dgvHDNhap.RowTemplate.Height = 24;
            this.dgvHDNhap.Size = new System.Drawing.Size(901, 164);
            this.dgvHDNhap.TabIndex = 83;
            this.dgvHDNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNhap_CellContentClick);
            // 
            // cbxMaXe
            // 
            this.cbxMaXe.FormattingEnabled = true;
            this.cbxMaXe.Location = new System.Drawing.Point(175, 75);
            this.cbxMaXe.Name = "cbxMaXe";
            this.cbxMaXe.Size = new System.Drawing.Size(156, 21);
            this.cbxMaXe.TabIndex = 103;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(616, 150);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(156, 21);
            this.cbxMaNV.TabIndex = 104;
            // 
            // cbxNCC
            // 
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(175, 112);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(156, 21);
            this.cbxNCC.TabIndex = 105;
            this.cbxNCC.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 383);
            this.Controls.Add(this.cbxNCC);
            this.Controls.Add(this.cbxMaNV);
            this.Controls.Add(this.cbxMaXe);
            this.Controls.Add(this.dtPNgaylap);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtThue);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lblThue);
            this.Controls.Add(this.lblGianhap);
            this.Controls.Add(this.lblNgaylap);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblMaCC);
            this.Controls.Add(this.lblMaxe);
            this.Controls.Add(this.lblMaNhap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvHDNhap);
            this.Name = "FrmHDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHDNhap";
            this.Load += new System.EventHandler(this.FrmHDNhap_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPNgaylap;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ToolStripButton tolbtnluu;
        private System.Windows.Forms.ToolStripButton tolbtnSua;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblGianhap;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblMaCC;
        private System.Windows.Forms.Label lblMaxe;
        private System.Windows.Forms.Label lblMaNhap;
        private System.Windows.Forms.ToolStripButton tolbtnXoa;
        private System.Windows.Forms.ToolStripButton tolbtnThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tolbtnXemin;
        private System.Windows.Forms.DataGridView dgvHDNhap;
        private System.Windows.Forms.ComboBox cbxMaXe;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.ComboBox cbxNCC;
    }
}