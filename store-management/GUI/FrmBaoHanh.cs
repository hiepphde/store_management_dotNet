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
    public partial class FrmBaoHanh : Form
    {
        DataTable dtbBaoHanh;
        public FrmBaoHanh()
        {
            InitializeComponent();
        }

        private void LoadCBX_MaXe()
        {
            string sql = "SELECT MaXe FROM SANPHAM";
            Functions.FillComboBox(sql, cbxMaXe, "MaXe", "MaXe");
            cbxMaXe.SelectedIndex = -1;
        }
        private void LoadCBX_KH()
        {
            string sql = "SELECT MaKH,HoTen FROM KHACHHANG";
            Functions.FillComboBox(sql, cbxKH, "MaKH", "HoTen");
            cbxKH.SelectedIndex = -1;
        }
        private void LoadCBX_MaNV()
        {
            string sql = "SELECT MaNV,HoTen FROM NHANVIEN";
            Functions.FillComboBox(sql, cbxMaNV, "MaNV", "HoTen");
            cbxMaNV.SelectedIndex = -1;
        }
        private void LoadData()
        {
            string sql = "select MaBH,MaXe,kh.HoTen,Gia,NgayXuat,ThoiGianBH,TinhTrangXe,nv.HoTen from BAOHANH bh,KHACHHANG kh,NHANVIEN nv where bh.MaKH = kh.MaKH and bh.MaNV = nv.MaNV";
            dtbBaoHanh = Functions.LoadDS(sql);
            dgvBHanh.DataSource = dtbBaoHanh;

            dgvBHanh.AllowUserToAddRows = false;
            dgvBHanh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void FrmBaoHanh_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBX_MaXe();
            LoadCBX_KH();
            LoadCBX_MaNV();
        }


        private void dgvBHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBHanh.CurrentRow.Index;
            txtMaBH.Text = dgvBHanh.Rows[i].Cells[0].Value.ToString();
            cbxMaXe.Text = dgvBHanh.Rows[i].Cells[1].Value.ToString();
            cbxKH.Text = dgvBHanh.Rows[i].Cells[2].Value.ToString();
            txtGia.Text = dgvBHanh.Rows[i].Cells[3].Value.ToString();
            dtPNGaySX.Text = dgvBHanh.Rows[i].Cells[4].Value.ToString();
            dtPNGaySX.Text = dgvBHanh.Rows[i].Cells[5].Value.ToString();
            txtTTxe.Text = dgvBHanh.Rows[i].Cells[6].Value.ToString();
            cbxMaNV.Text = dgvBHanh.Rows[i].Cells[7].Value.ToString();
        }

        private void tolbtnThem_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtMaBH.Text = "";
            cbxMaNV.Text = "";
            cbxMaXe.Text = "";
            cbxKH.Text = "";
            txtTTxe.Text = "";
            dtPNGaySX.Text = "1/1/2000";
            dtPNgayBH.Text = "1/1/2000";
        }

        private void tolbtnXemin_Click(object sender, EventArgs e)
        {
            rptBaoHanh bh = new rptBaoHanh();
            bh.ShowDialog();
            
        }

        private void tolbtnXoa_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            string key = "select maBH from BAOHANH where maBH = '" + txtMaBH.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "delete from BAOHANH where MaBH = '" + txtMaBH.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Phiếu bảo hành không tồn tại!");
                return;
            } 
        }

        private void tolbtnluu_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();

            if (txtMaBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBH.Focus();
                return;
            }
            //if (txtMaxe.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mã xe hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMaxe.Focus();
            //    return;
            //}
            //if (txtTenKH.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtTenKH.Focus();
            //    return;
            //}
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập phí bảo hành xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            } if (txtTTxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTTxe.Focus();
                return;
            } 
            //if (txtMaNV.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMaNV.Focus();
            //    return;
            //}
            string key = "SELECT MaBH FROM BAOHANH WHERE MaBH = N'" + txtMaBH.Text + "'";
            if (Functions.CheckKey(key))
            {
                MessageBox.Show("Phiếu bảo hành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBH.Clear();
                //txtMaxe.Focus();
                //txtTenKH.Focus();
                //txtGia.Focus();
                //dtPNGaySX.Value.Date.ToString("dd/MM/yyyy");
                //dtPNgayBH.Value.Date.ToString("dd/MM/yyyy");
                //txtTTxe.Focus();
                //txtMaNV.Focus();
                return;
            }
            string sql = "set dateformat dmy insert into BAOHANH values ('" + txtMaBH.Text.Trim() + "','" + cbxMaXe.SelectedValue.ToString() + "','" + txtGia.Text.Trim() + "','" + dtPNGaySX.Value.Date.ToString("dd/MM/yyyy").Trim() + "','" + dtPNgayBH.Value.Date.ToString("dd/MM/yyyy").Trim() + "',N'" + txtTTxe.Text.Trim() + "','" + cbxMaNV.SelectedValue.ToString() + "',N'" + cbxKH.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            LoadData();
        }

        private void tolbtnSua_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            //if (txtMaxe.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mã xe hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMaxe.Focus();
            //    return;
            //}
            //if (txtTenKH.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtTenKH.Focus();
            //    return;
            //}
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập phí bảo hành xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            } if (txtTTxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tình trạng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTTxe.Focus();
                return;
            } 
            //if (txtMaNV.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMaNV.Focus();
            //    return;
            //}
            string key = "SELECT MaBH FROM BAOHANH WHERE MaBH = N'" + txtMaBH.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "SET DATEFORMAT DMY UPDATE BAOHANH SET Maxe='" + cbxMaXe.SelectedValue.ToString() + "',MaKH=N'" + cbxKH.SelectedValue.ToString() + "',Gia='" + txtGia.Text.Trim() + "',NgayXuat='" + dtPNGaySX.Value.Date.ToString("dd/MM/yyyy").Trim() + "',ThoiGianBH='" + dtPNgayBH.Value.Date.ToString("dd/MM/yyyy").Trim() + "', TinhTrangXe=N'" + txtTTxe.Text.Trim() + "', MaNV='" + cbxMaNV.SelectedValue.ToString() + "'WHERE MaBH='" + txtMaBH.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Phiếu bảo hành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBH.Focus();
                return;
            }

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
