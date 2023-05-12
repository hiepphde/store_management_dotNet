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
    public partial class FrmBaoCao : Form
    {
        DataTable tblBaoCao;
        public FrmBaoCao()
        {
            InitializeComponent();
            cbxLoai.Enabled = false;
        }

        private void load_LoaiXe()
        {
            string sql = "select distinct MaXe from SanPham";
            Functions.FillComboBox(sql, cbxLoai, "MaXe", "MaXe");
            cbxLoai.SelectedIndex = -1;
        }

        private void LoadData()
        {
            string sql = "select MaXe,SoluongNhap,SoluongBan,TonKho from BAOCAO";
            tblBaoCao = Functions.LoadDS(sql);
            dgvBaoCao.DataSource = tblBaoCao;

            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            LoadData();
            load_LoaiXe();
            txtNhap.Enabled = false;
            txtXuat.Enabled = false;
            txtKho.Enabled = false;
        }

        private void dgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNhap.Text = dgvBaoCao.CurrentRow.Cells[1].Value.ToString();
            txtXuat.Text = dgvBaoCao.CurrentRow.Cells[2].Value.ToString();
            cbxLoai.Text = dgvBaoCao.CurrentRow.Cells[0].Value.ToString();
            txtKho.Text = dgvBaoCao.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmINBaoCao inBC = new FrmINBaoCao();
            inBC.ShowDialog();
            
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
    }
}
