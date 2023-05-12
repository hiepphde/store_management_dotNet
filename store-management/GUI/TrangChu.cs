using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHang
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            mnuNhanVien.Enabled = false;
            mnuPhongBan.Enabled = false;
            toolNhanSu.Enabled = false;
            lblTen.Text = FrmTaiKhoan.ten;
            if (FrmTaiKhoan.ten == "ADMIN" || FrmTaiKhoan.ten == "admin")
            {
                toolNhanSu.Enabled = true;
                mnuNhanVien.Enabled = true;
                mnuPhongBan.Enabled = true;
            }
        }

        private void mnuPhongBan_Click(object sender, EventArgs e)
        {
            FrmPhongBan pb = new FrmPhongBan();
            //pb.MdiParent = this;
            pb.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            //nv.MdiParent = this;
            nv.ShowDialog();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
            {
                return;
            }
            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private Form activeForm = null;
        private void openForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelShow.Controls.Add(childForm);
                panelShow.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
        }
        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            //openForm(new FrmBaoCao());
            FrmBaoCao bc = new FrmBaoCao();
            bc.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            FrmPass p = new FrmPass();
            p.ShowDialog();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham sp = new FrmSanPham();
            sp.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowDialog();
        }

        private void mnuBaoHanh_Click(object sender, EventArgs e)
        {
            FrmBaoHanh bh = new FrmBaoHanh();
            bh.ShowDialog();
        }

        private void mnuHDNhap_Click(object sender, EventArgs e)
        {
            FrmHDNhap hdNhap = new FrmHDNhap();
            hdNhap.Show();
        }

        private void mnuHDXuat_Click(object sender, EventArgs e)
        {
            FrmHDXuat hd = new FrmHDXuat();
            hd.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            FrmHDXuat hd = new FrmHDXuat();
            hd.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        
    }
}
