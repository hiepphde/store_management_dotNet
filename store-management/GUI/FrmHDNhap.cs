using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLiCuaHang
{
    public partial class FrmHDNhap : Form
    {
        DataTable dtbHDNhap;
        public FrmHDNhap()
        {
            InitializeComponent();
            txtTongtien.Enabled = false;
            
        }

        private void LoadData()
        {
            string sql = "select  MaHD_Nhap,MaXe,MaNCC,NgayLap,SoLuong,GiaNhap,Thue,TongTien,MaNV from HDNHAP";
            dtbHDNhap = Functions.LoadDS(sql);
            dgvHDNhap.DataSource = dtbHDNhap;

            dgvHDNhap.Columns[6].DefaultCellStyle.Format = "#,###";
            dgvHDNhap.Columns[7].DefaultCellStyle.Format = "#,###";
            dgvHDNhap.Columns[8].DefaultCellStyle.Format = "#,###";

            dgvHDNhap.AllowUserToAddRows = false;
            dgvHDNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadCBX_MaXe()
        {
            string sql = "SELECT MaXe FROM SANPHAM";
            Functions.FillComboBox(sql, cbxMaXe, "MaXe", "MaXe");
            cbxMaXe.SelectedIndex = -1;
        }

        private void LoadCBX_NCC()
        {
            string sql = "SELECT * FROM NHACC";
            Functions.FillComboBox(sql, cbxNCC, "MaNCC", "TenNCC");
            cbxNCC.SelectedIndex = -1;
        }
        private void LoadCBX_MaNV()
        {
            string sql = "SELECT MaNV,HoTen FROM NHANVIEN";
            Functions.FillComboBox(sql, cbxMaNV, "MaNV", "HoTen");
            cbxMaNV.SelectedIndex = -1;
        }
        private void FrmHDNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBX_MaNV();
            LoadCBX_MaXe();
            LoadCBX_NCC();
        }

        private void dgvHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHDNhap.CurrentRow.Index;
            txtNhap.Text = dgvHDNhap.Rows[i].Cells[0].Value.ToString();
            cbxMaXe.Text = dgvHDNhap.Rows[i].Cells[1].Value.ToString();
            cbxNCC.Text = dgvHDNhap.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text = dgvHDNhap.Rows[i].Cells[4].Value.ToString();
            txtGia.Text = dgvHDNhap.Rows[i].Cells[5].Value.ToString();
            dtPNgaylap.Text = dgvHDNhap.Rows[i].Cells[3].Value.ToString();
            cbxMaNV.Text = dgvHDNhap.Rows[i].Cells[8].Value.ToString();
            txtThue.Text = dgvHDNhap.Rows[i].Cells[6].Value.ToString();
            txtTongtien.Text = dgvHDNhap.Rows[i].Cells[7].Value.ToString();
        }

        private void tolbtnThem_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            cbxMaXe.Text = "";
            cbxMaNV.Text = "";
            cbxNCC.Text = "";
            txtNhap.Text = "";
            txtSoluong.Text = "";
            txtTongtien.Text = "";
            txtThue.Text = "";
            dtPNgaylap.Text = "1/1/2000";
        }

        private void tolbtnXoa_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            string key = "select MAHD_Nhap from HDNHAP where MAHD_Nhap = '" + txtNhap.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "delete from HDNHAP where MAHD_Nhap = '" + txtNhap.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Hóa đơn không tồn tại");
                return;
            }
        }

        private void tolbtnluu_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            if (txtNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
                return;
            }
            if (cbxMaXe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaXe.Focus();
                return;
            }
            //if (txtNhaCC.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtNhaCC.Focus();
            //    return;
            //}
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            } if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;

                if (txtThue.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập % thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThue.Focus();
                    return;
                }
            } if (cbxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNV.Focus();
                return;
            }

            string key = "SELECT MaHD_Nhap from HDNHAP where MaHD_Nhap = N'" + txtNhap.Text + "'";
            if (Functions.CheckKey(key))
            {
                MessageBox.Show("Hóa đơn tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Clear();
                return;
            }

            string sql = "set dateformat dmy insert into HDNHAP(MaHD_Nhap,MaXe,MaNCC,NgayLap,SoLuong,GiaNhap,Thue,MaNV)"
                +" values (N'" + txtNhap.Text.Trim() + "',N'" + cbxMaXe.SelectedValue.ToString() + "',N'" + cbxNCC.SelectedValue.ToString() + "','" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "','" + txtSoluong.Text.Trim() + "'," + txtGia.Text.Trim() + "," + txtThue.Text.Trim() + ",N'" + cbxMaNV.SelectedValue.ToString() + "')";
            Functions.RunSQL(sql);
            LoadData();
        }

        private void tolbtnSua_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            if (txtNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
                return;
            }
            
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            } if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            } if (cbxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            if (txtThue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập % thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThue.Focus();
                return;
            }
            
            string key = "SELECT MaHD_Nhap from HDNHAP where MaHD_Nhap = N'" + txtNhap.Text + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "UPDATE HDNHAP SET Maxe='" + cbxMaXe.SelectedValue.ToString() + "',MaNCC='" + cbxNCC.SelectedValue.ToString() + "',NgayLap='" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "', SoLuong=N'" + txtSoluong.Text.Trim() + "',GiaNhap=N'" + txtGia.Text.Trim() + "', Thue=N'" + txtThue.Text.Trim() + "',TongTien=N'" + txtTongtien.Text.Trim() + "',MaNV=N'" + cbxMaNV.SelectedValue.ToString() + "'WHERE MaHD_NHAP=N'" + txtNhap.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Phiếu bảo hành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
