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
    public partial class FrmSanPham : Form
    {
        DataTable dtbSanPham;
        DataSet ds_QLSP = new DataSet();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void ResetValues()
        {
            txtGiaBan.Text = "0";
            txtMauSon.Text = "";
            txtMaXe.Text = "";
            cboLoai.Text = "";
            NgaySX.Text = DateTime.Now.ToShortDateString();
            txtTenXe.Text = "";
            txtTGBH.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            txtMaXe.Enabled = true;
            txtMaXe.Focus();
        }

        private void LoadData()
        {
            string sql = "select MAXE,TENXE,LOAI,MAUSON,NGAYSX,TGBH,GIABAN,GHICHU from SANPHAM";
            dtbSanPham = Functions.LoadDS(sql);
            dgvSanPham.DataSource = dtbSanPham;

            dgvSanPham.Columns[0].Width = 70;
            dgvSanPham.Columns[1].Width = 120;
            dgvSanPham.Columns[2].Width = 80;
            dgvSanPham.Columns[3].Width = 100;
            dgvSanPham.Columns[4].Width = 80;
            dgvSanPham.Columns[5].Width = 60;
            dgvSanPham.Columns[6].Width = 110;
            dgvSanPham.Columns[7].Width = 80;

            dgvSanPham.Columns[6].DefaultCellStyle.Format = "#,###";

            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadCBX_Loai()
        {

            string sql = "SELECT DISTINCT LOAI from SanPham";
            Functions.FillComboBox(sql, cboLoai, "Loai", "Loai");
            cboLoai.SelectedIndex = -1;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa mã xe " + txtMaXe.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Functions.OpenConn();
                string key = "select MAXE from SANPHAM where MaXe = '" + txtMaXe.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    string sql = "delete from SANPHAM where MaXe = '" + txtMaXe.Text.Trim() + "'";
                    Functions.RunSQL(sql);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!!");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaXe.Enabled = false;
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadData();
            LoadCBX_Loai();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXe.Text = dgvSanPham.CurrentRow.Cells["MaXe"].Value.ToString();
            txtTenXe.Text = dgvSanPham.CurrentRow.Cells["TenXe"].Value.ToString();
            cboLoai.Text = dgvSanPham.CurrentRow.Cells["Loai"].Value.ToString();
            NgaySX.Text = dgvSanPham.CurrentRow.Cells["NgaySX"].Value.ToString();
            txtMauSon.Text = dgvSanPham.CurrentRow.Cells["MauSon"].Value.ToString();
            txtTGBH.Text = dgvSanPham.CurrentRow.Cells["TGBH"].Value.ToString();
            txtGiaBan.Text = dgvSanPham.CurrentRow.Cells["GiaBan"].Value.ToString();
            if (dgvSanPham.CurrentRow.Cells["GhiChu"].Value.ToString() == "Xe Mới")
            {
                ckGC.Checked = true;
            }
            else ckGC.Checked = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled)
            {
                Functions.OpenConn();
                string Sua;
                if (txtMaXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaXe.Focus();
                    return;
                }
                if (txtTenXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenXe.Focus();
                    return;
                }
                if (cboLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboLoai.Focus();
                    return;
                }

                string key = "SELECT MaXe FROM SanPham WHERE MaXe='" + txtMaXe.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    string ck;
                    if (ckGC.Checked)
                    {
                        ck = "Xe Mới";
                    }
                    else ck = "";
                    Sua = "UPDATE SanPham SET TENXE=N'" + txtTenXe.Text.Trim() + "',LOAI=N'" + cboLoai.Text.Trim() + "',MAUSON=N'" + txtMauSon.Text.Trim() + "',NGAYSX='" + NgaySX.Value.Date.ToString("dd/MM/yyyy") + "',TGBH=N'" + txtTGBH.Text.Trim() + "',GIABAN=N'" + txtGiaBan.Text.Trim() + "',GHICHU=N'" + ck + "' Where MAXE=N'" + txtMaXe.Text.Trim() + "'";
                    Functions.RunSQL(Sua);
                    LoadData();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;

                }
                else
                    MessageBox.Show("Mã sản phẩm này không tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaXe.Focus();
                return;


            }
            else
            {
                Functions.OpenConn();
                string Them;
                if (txtMaXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập xe hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaXe.Focus();
                    return;
                }
                if (txtTenXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenXe.Focus();
                    return;
                }
                if (cboLoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập loại xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboLoai.Focus();
                    return;
                }

                string key = "SELECT MaXe FROM SanPham WHERE MaXe='" + txtMaXe.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    MessageBox.Show("Mã sản phẩm này đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaXe.Focus();
                    return;
                }
                string ckG;
                if (ckGC.Checked)
                {
                    ckG = "Xe Mới";
                }
                else ckG = "";
                Them = "set dateformat dmy INSERT INTO SanPham(MaXe,TenXe,Loai,MauSon,NgaySX,TGBH,GiaBan,GhiChu)"
                + "VALUES(N'" + txtMaXe.Text.Trim() + "',N'" + txtTenXe.Text.Trim() + "',N'" + cboLoai.Text.Trim() + "',N'" + txtMauSon.Text.Trim() + "','" + NgaySX.Value.Date.ToString("dd/MM/yyyy") + "',N'" + txtTGBH.Text.Trim() + "',N'" + txtGiaBan.Text.Trim() + "',N'" + ckG + "')   ";
                Functions.RunSQL(Them);
                LoadData();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
