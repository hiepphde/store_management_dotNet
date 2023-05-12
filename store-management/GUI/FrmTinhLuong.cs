using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiCuaHang
{
    public partial class FrmTinhLuong : Form
    {
        DataTable dtbLuong;
        public FrmTinhLuong()
        {
            InitializeComponent();
        }

        private void FrmTinhLuong_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvLuong.Columns[1].Width = 140;
            dgvLuong.Columns[3].Width = 80;
        }

        private void LoadData()
        {
            string sql = "select nv.MaNV,HoTen,ChucVu,soNgay as N'Số Ngày Làm',(Luong * nc.soNgay) as N'Tổng Lương'  from NhanVien nv, NgayCong nc where nv.MaNV = nc.MaNV";
            dtbLuong = Functions.LoadDS(sql);
            dgvLuong.DataSource = dtbLuong;

            dgvLuong.AllowUserToAddRows = false;
            dgvLuong.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLuong.Columns[4].DefaultCellStyle.Format = "#,###";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //string kt_Ten = "select HoTen from NhanVien nv, NgayCong nc where nv.MaNV = nc.MaNV and nv.HoTen like '%" + txtTen.Text.Trim() + "%'";
            //if (Functions.CheckKey(kt_Ten))
            //{
                DataSet ds = new DataSet();
                string sql = "select nv.MaNV,HoTen,ChucVu,soNgay as N'Số Ngày Làm',(Luong * nc.soNgay) as N'Tổng Lương'  from NhanVien nv, NgayCong nc where nv.MaNV = nc.MaNV and (nv.HoTen like N'%" + txtTen.Text.Trim() + "%' or nv.MaNV like '%" + txtTen.Text + "%')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Functions.conn);
                da.Fill(ds);
                dgvLuong.DataSource = ds.Tables[0];
            //}
            //else
            //{
            //    MessageBox.Show("không tìm thấy Nhân Viên");
            //}
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
