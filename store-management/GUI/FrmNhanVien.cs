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
    public partial class FrmNhanVien : Form
    {
        DataTable dtbNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void Control_Enabled()
        {
            txtChucVu.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtLuong.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTen.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbxMaPhong.Enabled = false;
            radNam.Enabled = false;
            radNu.Enabled = false;
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCBX_MaPhong();
            btnLuu.Enabled = false;
            Control_Enabled();
        }

        private void LoadCBX_MaPhong()
        {
            string sql = "SELECT * FROM PHONGBAN";
            Functions.FillComboBox(sql, cbxMaPhong, "MaPH", "TenPH");
            cbxMaPhong.SelectedIndex = -1;
        }

        private void LoadData()
        {
            string sql = "select maNV,HoTen,Email,NgaySinh,DiaChi,SĐT,Phai,ChucVu,Luong,TenPH from NhanVien n, PHONGBAN p where n.MaPH = p.MaPH";
            dtbNhanVien = Functions.LoadDS(sql);
            dgvNV.DataSource = dtbNhanVien;
            dgvNV.Columns[8].DefaultCellStyle.Format = "#,###";
            dgvNV.AllowUserToAddRows = false;
            dgvNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            string key = "select maNV from NhanVien where maNV = '" + txtMaNV.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "delete from Nhanvien where MaNV = '" + txtMaNV.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
            }
            else
            {
                MessageBox.Show("Nhân Viên này không tồn tại!");
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtMaNV.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtLuong.Clear();
            txtSDT.Clear();
            txtTen.Clear();
            txtMaNV.Focus();
            cbxMaPhong.SelectedIndex = -1;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtLuong.Enabled = true;
            txtMaNV.Enabled = true;
            txtSDT.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbxMaPhong.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLuong.Text = dgvNV.CurrentRow.Cells[8].Value.ToString();
            txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
            txtChucVu.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();
            txtDiaChi.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
            cbxMaPhong.Text = dgvNV.CurrentRow.Cells[9].Value.ToString();
            dtpNgaySinh.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            string gt = dgvNV.CurrentRow.Cells[6].Value.ToString();
            if (dgvNV.CurrentRow.Cells[6].Value.ToString().Trim() == "Nam")
            {
                radNam.Checked = true;
            }
            else radNu.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtChucVu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtLuong.Enabled = true;
            txtSDT.Enabled = true;
            txtTen.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbxMaPhong.Enabled = true;
            radNam.Enabled = true;
            radNu.Enabled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (txtMaNV.Enabled)
            {
                string key = "select maNV from NhanVien where maNV = '" + txtMaNV.Text.Trim() + "'";
                if (Functions.CheckKey(key) == false)
                {
                    string gt;
                    if (radNam.Checked)
                        gt = "Nam";
                    else gt = "Nữ";

                    string sql = "set dateformat DMY insert into NhanVien(MaNV,HoTen,Email,NgaySinh,DiaChi,SĐT,Phai,Luong,ChucVu,MaPH)"
                               + "values ('" + txtMaNV.Text.Trim() + "',N'" + txtTen.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + dtpNgaySinh.Value.Date.ToString("dd/MM/yyyy") + "',N'" + txtDiaChi.Text.Trim() + "','" + txtSDT.Text.Trim() + "',N'" + gt + "'," + txtLuong.Text.Trim() + ",N'" + txtChucVu.Text.Trim() + "','" + cbxMaPhong.SelectedValue.ToString() + "')";
                    Functions.RunSQL(sql);
                    LoadData();
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    Control_Enabled();
                }
                else
                {
                    MessageBox.Show("Nhân Viên này đã tồn tại!");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                    return;
                }
            }
            else
            {
                txtMaNV.Enabled = false;
                string gt;
                if (radNam.Checked)
                    gt = "Nam";
                else gt = "Nữ";

                string sql = "set dateformat dmy update NhanVien set Hoten = N'" + txtTen.Text.Trim() + "',Email = '" + txtEmail.Text.Trim() + "',NgaySinh = '" + dtpNgaySinh.Value.Date.ToString("dd/MM/yyyy") + "',DiaChi = N'" + txtDiaChi.Text.Trim() + "',SĐT = '" + txtSDT.Text.Trim() + "',Phai = N'" + gt + "',Chucvu = N'" + txtChucVu.Text.Trim() + "',MaPH = '" + cbxMaPhong.SelectedValue.ToString() + "' where MaNV = '" + txtMaNV.Text.Trim() + "'";
                Functions.RunSQL(sql);
                LoadData();
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                Control_Enabled();
            }
        }

        private void FrmNhanVien_Move(object sender, EventArgs e)
        {
            //this.Location = this.initialLocation;
        }
        
        //Không cho di chuyển form.
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

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            FrmTinhLuong tl = new FrmTinhLuong();
            tl.ShowDialog();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
