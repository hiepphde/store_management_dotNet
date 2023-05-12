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
    public partial class FrmKhachHang : Form
    {
        DataTable dtbKhachHang;
        DataSet ds_QLKH = new DataSet();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = "select MAKH,HOTEN,NGAYSINH,DIACHI,SDT,PHAI from KHACHHANG";
            dtbKhachHang = Functions.LoadDS(sql);
            dgvKhachHang.DataSource = dtbKhachHang;

            dgvKhachHang.Columns[0].Width = 80;
            dgvKhachHang.Columns[1].Width = 170;
            dgvKhachHang.Columns[2].Width = 100;
            dgvKhachHang.Columns[3].Width = 100;
            dgvKhachHang.Columns[4].Width = 170;
            dgvKhachHang.Columns[5].Width = 80;

            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            NgaySinh.Text = DateTime.Now.ToShortDateString();
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            ckPhai.Checked = false;
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            LoadData();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtHoTen.Text = dgvKhachHang.CurrentRow.Cells["HoTen"].Value.ToString();
            NgaySinh.Text = dgvKhachHang.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["SDT"].Value.ToString();
            if (dgvKhachHang.CurrentRow.Cells["Phai"].Value.ToString() == "Nam")
            {
                ckPhai.Checked = true;
            }
            else ckPhai.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            txtMaKH.Enabled = true;
            txtMaKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn xóa mã khách hàng " + txtMaKH.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Functions.OpenConn();
                string key = "select MAKH from KHACHHANG where MAKH = '" + txtMaKH.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    string sql = "delete from KHACHHANG where MAKH = '" + txtMaKH.Text.Trim() + "'";
                    Functions.RunSQL(sql);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại!!");
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
            txtMaKH.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnSua.Enabled)
            {
                Functions.OpenConn();
                string Sua;
                if (txtHoTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTen.Focus();
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDT.Focus();
                    return;
                }


                string key = "SELECT MAKH FROM KHACHHANG WHERE MAKH='" + txtMaKH.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    string ckP;
                    if (ckPhai.Checked)
                    {
                        ckP = "Nam";
                    }
                    else ckP = "Nữ";
                    Sua = "UPDATE KHACHHANG SET HOTEN=N'" + txtHoTen.Text.Trim() + "',NGAYSINH='" + NgaySinh.Value.Date.ToString("dd/MM/yyyy") + "',DIACHI=N'" + txtDiaChi.Text.Trim() + "',SDT=N'" + txtSDT.Text.Trim() + "',PHAI=N'" + ckP + "' Where MAKH=N'" + txtMaKH.Text.Trim() + "'";
                    Functions.RunSQL(Sua);
                    LoadData();
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                }
                else
                    MessageBox.Show("Mã khách hàng này không tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return;


            }
            else
            {
                Functions.OpenConn();
                string Them;
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
                if (txtHoTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTen.Focus();
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Focus();
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDT.Focus();
                    return;
                }
                string key = "SELECT MAKH FROM KHACHHANG WHERE MAKH='" + txtMaKH.Text.Trim() + "'";
                if (Functions.CheckKey(key))
                {
                    MessageBox.Show("Mã sản khách hàng đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKH.Focus();
                    return;
                }
                string ckP;
                if (ckPhai.Checked)
                {
                    ckP = "Nam";
                }
                else ckP = "";
                Them = "set dateformat dmy INSERT INTO KHACHHANG(MAKH,HoTen,NgaySinh,DiaChi,SDT,Phai)"
                + "VALUES(N'" + txtMaKH.Text.Trim() + "',N'" + txtHoTen.Text.Trim() + "','" + NgaySinh.Value.Date.ToString("dd/MM/yyyy") + "',N'" + txtDiaChi.Text.Trim() + "',N'" + txtSDT.Text.Trim() + "',N'" + ckP + "')   ";
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
