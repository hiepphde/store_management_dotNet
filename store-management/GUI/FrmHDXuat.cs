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
    public partial class FrmHDXuat : Form
    {
        DataTable dtbHDXuat;
        public FrmHDXuat()
        {
            InitializeComponent();
            txtTongtien.Enabled = false;
            txtDongia.Enabled = false;
            txtSDT.Enabled = false;
            txtDiachi.Enabled = false;
        }

        private void LoadData()
        {
            string sql = "select  MaHD_Xuat,MaXe,DonGia,SoLuong,MaKH,SDT,ĐC_GiaoHang,NgayLap,GiamGia,TongTien,MaNV from HDXUAT";
            dtbHDXuat = Functions.LoadDS(sql);
            dgvHDXuat.DataSource = dtbHDXuat;

            dgvHDXuat.Columns[2].DefaultCellStyle.Format = "#,###";
            dgvHDXuat.Columns[8].DefaultCellStyle.Format = "#,###";
            dgvHDXuat.Columns[9].DefaultCellStyle.Format = "#,###";

            dgvHDXuat.AllowUserToAddRows = false;
            dgvHDXuat.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadCBX_MaXe()
        {
            string sql = "SELECT DISTINCT MaXe FROM HDNHAP";
            Functions.FillComboBox(sql, cbxMaXe, "MaXe", "MaXe");
            cbxMaXe.SelectedIndex = -1;
        }
        private void LoadCBX_MaNV()
        {
            string sql = "SELECT MaNV,HoTen FROM NHANVIEN";
            Functions.FillComboBox(sql, cbxMaNV, "MaNV", "HoTen");
            cbxMaNV.SelectedIndex = -1;
        }
        private void LoadCBX_KH()
        {
            string sql = "SELECT MaKH,HoTen FROM KHACHHANG";
            Functions.FillComboBox(sql, cbxMaKH, "MaKH", "HoTen");
            cbxMaKH.SelectedIndex = -1;
        }

        private void FrmHDXuat_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBX_MaXe();
            LoadCBX_KH();
            LoadCBX_MaNV();
        }

        private void dgvHDXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHDXuat.CurrentRow.Index;
            txtXuat.Text = dgvHDXuat.Rows[i].Cells[0].Value.ToString();
            cbxMaXe.Text = dgvHDXuat.Rows[i].Cells[1].Value.ToString();
            txtDongia.Text = dgvHDXuat.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text = dgvHDXuat.Rows[i].Cells[3].Value.ToString();
            cbxMaKH.Text = dgvHDXuat.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dgvHDXuat.Rows[i].Cells[5].Value.ToString();
            txtDiachi.Text = dgvHDXuat.Rows[i].Cells[6].Value.ToString();
            dtPNgaylap.Text = dgvHDXuat.Rows[i].Cells[7].Value.ToString();
            txtGiamgia.Text = dgvHDXuat.Rows[i].Cells[8].Value.ToString();
            txtTongtien.Text = dgvHDXuat.Rows[i].Cells[9].Value.ToString();
            cbxMaNV.Text = dgvHDXuat.Rows[i].Cells[10].Value.ToString();
        }

        private void tolbtnThem_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtDongia.Text = "";
            txtGiamgia.Text = "";
            cbxMaKH.Text = "";
            cbxMaNV.Text = "";
            cbxMaXe.Text = "";
            txtSDT.Text = "";
            txtSoluong.Text = "";
            txtTongtien.Text = "";
            txtXuat.Text = "";
            dtPNgaylap.Text = "1/1/2000";
        }

        private void tolbtnXoa_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            string key = "select MaHD_Xuat from HDXUAT where MaHD_Xuat = '" + txtXuat.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "delete from HDXUAT where MaHD_Xuat = '" + txtXuat.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Hóa đơn hành không tồn tại!");
                return;
            } 
        }

        private void tolbtnluu_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            if (txtXuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải mã hóa đơn xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXuat.Focus();
                return;
            }
            if (cbxMaXe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xe hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaXe.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return;
            } if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (cbxMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            } if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (cbxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNV.Focus();
                return;
            }
            string key = "SELECT MaHD_XUAT FROM HDXUAT WHERE MaHD_XUAT = N'" + txtXuat.Text + "'";
            if (Functions.CheckKey(key))
            {
                MessageBox.Show("Phiếu bảo hành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXuat.Clear();
                return;
            }
            string sql = "set dateformat dmy insert into HDXUAT values ('" + txtXuat.Text.Trim() + "','" + cbxMaXe.SelectedValue.ToString() + "',N'" + txtDongia.Text.Trim() + "','" + txtSoluong.Text.Trim() + "','" + cbxMaKH.SelectedValue.ToString() + "','" + txtSDT.Text.Trim() + "','" + txtDiachi.Text.Trim() + "','" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "','" + txtGiamgia.Text.Trim() + "','" + txtTongtien.Text.Trim() + "','" + cbxMaNV.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            LoadData();
        }

        private void tolbtnSua_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            if (txtXuat.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải mã hóa đơn xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXuat.Focus();
                return;
            }
            if (cbxMaXe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xe hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaXe.Focus();
                return;
            }
            if (txtDongia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDongia.Focus();
                return;
            } if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (cbxMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaKH.Focus();
                return;
            }
            if (txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            } if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (cbxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNV.Focus();
                return;
            }
            string key = "SELECT MAHD_XUAT from HDXUAT where MAHD_XUAT = N'" + txtXuat.Text + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "UPDATE HDXUAT SET Maxe='" + cbxMaXe.Text.Trim() + "',DonGia='" + txtDongia.Text.Trim() + "',SoLuong=N'" + txtSoluong.Text.Trim() + "',MaKH=N'" + cbxMaKH.SelectedValue.ToString() + "',SDT=N'" + txtSDT.Text.Trim() + "',ĐC_GiaoHang=N'" + txtDiachi.Text.Trim() + "',NgayLap='" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "', GiamGia=N'" + txtGiamgia.Text.Trim() + "',TongTien=N'" + txtTongtien.Text.Trim() + "',MaNV=N'" + cbxMaNV.SelectedValue.ToString() + "'WHERE MaHD_XUAT=N'" + txtXuat.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Phiếu bảo hành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXuat.Focus();
                return;
            }
        }

        private void tolbtXemin_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxMaXe_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxMaXe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable da = new DataTable();
            string sql = "select giaban from sanpham where maxe = '" + cbxMaXe.SelectedValue.ToString() + "' ";
            da = Functions.LoadDS(sql);
            if (da.Rows.Count > 0)
            {
                txtDongia.Text = da.Rows[0][0].ToString().Trim();
            }
        }

        private void cbxMaKH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable da = new DataTable();
            string sql = "select SDT,DIACHI from KHACHHANG where MaKH = '" + cbxMaKH.SelectedValue.ToString() + "' ";
            da = Functions.LoadDS(sql);
            if (da.Rows.Count > 0)
            {
                txtDiachi.Text = da.Rows[0][1].ToString().Trim();
                txtSDT.Text = da.Rows[0][0].ToString().Trim();
            }
        }
    }
}
