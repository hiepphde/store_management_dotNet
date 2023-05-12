namespace QuanLiCuaHang
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolFile = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDanhMuc = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolNhanSu = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolQuanLy = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.panelShow = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolStripSeparator1,
            this.toolDanhMuc,
            this.toolStripSeparator2,
            this.toolNhanSu,
            this.toolStripSeparator3,
            this.toolQuanLy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMK,
            this.mnuDangXuat});
            this.toolFile.Image = ((System.Drawing.Image)(resources.GetObject("toolFile.Image")));
            this.toolFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(41, 22);
            this.toolFile.Text = "File";
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(146, 22);
            this.mnuDoiMK.Text = "Đổi Mật Khẩu";
            this.mnuDoiMK.Click += new System.EventHandler(this.mnuDoiMK_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(146, 22);
            this.mnuDangXuat.Text = "Đằng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDanhMuc
            // 
            this.toolDanhMuc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuKhachHang});
            this.toolDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("toolDanhMuc.Image")));
            this.toolDanhMuc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDanhMuc.Name = "toolDanhMuc";
            this.toolDanhMuc.Size = new System.Drawing.Size(78, 22);
            this.toolDanhMuc.Text = "Danh Mục";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(139, 22);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(139, 22);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolNhanSu
            // 
            this.toolNhanSu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNhanSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhongBan,
            this.mnuNhanVien});
            this.toolNhanSu.Image = ((System.Drawing.Image)(resources.GetObject("toolNhanSu.Image")));
            this.toolNhanSu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNhanSu.Name = "toolNhanSu";
            this.toolNhanSu.Size = new System.Drawing.Size(68, 22);
            this.toolNhanSu.Text = "Nhân Sự";
            // 
            // mnuPhongBan
            // 
            this.mnuPhongBan.Name = "mnuPhongBan";
            this.mnuPhongBan.Size = new System.Drawing.Size(132, 22);
            this.mnuPhongBan.Text = "Phòng Ban";
            this.mnuPhongBan.Click += new System.EventHandler(this.mnuPhongBan_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(132, 22);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolQuanLy
            // 
            this.toolQuanLy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoHanh,
            this.mnuHDNhap,
            this.mnuHDXuat,
            this.mnuBaoCao});
            this.toolQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("toolQuanLy.Image")));
            this.toolQuanLy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolQuanLy.Name = "toolQuanLy";
            this.toolQuanLy.Size = new System.Drawing.Size(66, 22);
            this.toolQuanLy.Text = "Quản Lý";
            // 
            // mnuBaoHanh
            // 
            this.mnuBaoHanh.Name = "mnuBaoHanh";
            this.mnuBaoHanh.Size = new System.Drawing.Size(153, 22);
            this.mnuBaoHanh.Text = "Bảo Hành";
            this.mnuBaoHanh.Click += new System.EventHandler(this.mnuBaoHanh_Click);
            // 
            // mnuHDNhap
            // 
            this.mnuHDNhap.Name = "mnuHDNhap";
            this.mnuHDNhap.Size = new System.Drawing.Size(153, 22);
            this.mnuHDNhap.Text = "Hóa Đơn Nhập";
            this.mnuHDNhap.Click += new System.EventHandler(this.mnuHDNhap_Click);
            // 
            // mnuHDXuat
            // 
            this.mnuHDXuat.Name = "mnuHDXuat";
            this.mnuHDXuat.Size = new System.Drawing.Size(153, 22);
            this.mnuHDXuat.Text = "Hóa Đơn Xuất";
            this.mnuHDXuat.Click += new System.EventHandler(this.mnuHDXuat_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(153, 22);
            this.mnuBaoCao.Text = "Báo Cáo";
            this.mnuBaoCao.Click += new System.EventHandler(this.mnuBaoCao_Click);
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.lblTen);
            this.panelShow.Controls.Add(this.label1);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 25);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(450, 265);
            this.panelShow.TabIndex = 2;
            this.panelShow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShow_Paint);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTen.Location = new System.Drawing.Point(52, 11);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(35, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 290);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Cửa Hàng";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolNhanSu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhongBan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem mnuHDNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHDXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label label1;

    }
}

