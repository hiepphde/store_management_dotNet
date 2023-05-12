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
    public partial class FrmHoaDonNhap : Form
    {
        DataTable dtbHDNhap;
        public FrmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = "select  MaHD_Nhap,MaXe,MaNCC,NgayLap,SoLuong,GiaNhap,Thue,TongTien,MaNV from HDNHAP";
            dtbHDNhap = Functions.LoadDS(sql);
            dgvHDNhap.DataSource = dtbHDNhap;

            dgvHDNhap.AllowUserToAddRows = false;
            dgvHDNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHDNhap.CurrentRow.Index;
            txtNhap.Text = dgvHDNhap.Rows[i].Cells[0].Value.ToString();
            txtMaxe.Text = dgvHDNhap.Rows[i].Cells[1].Value.ToString();
            txtNhaCC.Text = dgvHDNhap.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text = dgvHDNhap.Rows[i].Cells[4].Value.ToString();
            txtGia.Text = dgvHDNhap.Rows[i].Cells[5].Value.ToString();
            dtPNgaylap.Text = dgvHDNhap.Rows[i].Cells[3].Value.ToString();
            txtMaNV.Text = dgvHDNhap.Rows[i].Cells[8].Value.ToString();
            txtThue.Text = dgvHDNhap.Rows[i].Cells[6].Value.ToString();
            txtTongtien.Text = dgvHDNhap.Rows[i].Cells[7].Value.ToString();
        }

        private void tolbtnThem_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtMaxe.Text = "";
            txtMaNV.Text = "";
            txtNhaCC.Text = "";
            txtNhap.Text = "";
            txtSoluong.Text = "";
            txtTongtien.Text = "";
            txtThue.Text = "";
            dtPNgaylap.Text = "1/1/2000";
        }

        private void tolbtnXoa_Click(object sender, EventArgs e)
        {
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
            if (txtMaxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaxe.Focus();
                return;
            }
            if (txtNhaCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaCC.Focus();
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

                if (txtThue.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập % thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThue.Focus();
                    return;
                }
            } if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }

            string key = "SELECT MaHD_Nhap from HDNHAP where MaHD_Nhap = N'" + txtNhap.Text + "'";
            if (Functions.CheckKey(key))
            {
                MessageBox.Show("Hóa đơn tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Clear();
                return;
            }

            string sql = "set dateformat dmy insert into HDNHAP values (N'" + txtNhap.Text.Trim() + "',N'" + txtMaxe.Text.Trim() + "',N'" + txtNhaCC.Text.Trim() + "','" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "','" + txtSoluong.Text.Trim() + "','" + txtGia.Text.Trim() + "','" + txtThue.Text.Trim() + "','" + txtTongtien.Text.Trim() + "',N'" + txtMaNV.Text.Trim() + "')";
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
            if (txtMaxe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaxe.Focus();
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
            } if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtThue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập % thuế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThue.Focus();
                return;
            }
            if (txtNhaCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaCC.Focus();
                return;
            }
            string key = "SELECT MaHD_Nhap from HDNHAP where MaHD_Nhap = N'" + txtNhap.Text + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "UPDATE HDNHAP SET Maxe='" + txtMaxe.Text.Trim() + "',MaNCC='" + txtNhaCC.Text.Trim() + "',NgayLap='" + dtPNgaylap.Value.Date.ToString("dd/MM/yyyy").Trim() + "', SoLuong=N'" + txtSoluong.Text.Trim() + "',GiaNhap=N'" + txtGia.Text.Trim() + "', Thue=N'" + txtThue.Text.Trim() + "',TongTien=N'" + txtTongtien.Text.Trim() + "',MaNV=N'" + txtMaNV.Text.Trim() + "'WHERE MaHD_NHAP=N'" + txtNhap.Text.Trim() + "'";
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
    }
}
