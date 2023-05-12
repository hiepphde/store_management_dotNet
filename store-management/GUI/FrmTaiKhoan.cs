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
    public partial class FrmTaiKhoan : Form
    {
        public static DataTable dt;
        public static string ten;
        public FrmTaiKhoan()
        {
            InitializeComponent();

            txtPass.PasswordChar = '*';
            txtTen.Clear();
            txtTen.Focus();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền tên Đăng nhập!");
                return;
            }
            string sql = "Select TenDN,MatKhau from TaiKhoan where (tenDN = '" + txtTen.Text.Trim() + "' and MatKhau = '" + txtPass.Text.Trim() + "')";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Đăng Nhập Thành Công!");
                tenDN();
                txtTen.Focus();
                txtPass.Clear();

                TrangChu ct = new TrangChu();
                ct.Show();
                return;
            }
            else
            {
                MessageBox.Show("Sai Tên đăng nhập hoặc Mật khẩu!\nXin vui lòng nhập lại!");
                txtPass.Clear();
                txtTen.Clear();
                txtTen.Focus();
                return;
            }
        }
        private void tenDN()
        {
            dt = new DataTable();
            string sql = "select tenDN from TaiKhoan where tenDN = '" + txtTen.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Functions.conn);
            da.Fill(dt); 
            if (dt.Rows.Count > 0)
            {
                ten = dt.Rows[0]["TenDN"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Sai tên Đăng Nhập!\nVui lòng nhập lại!", "Thông báo !");
                ten = "";
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Thông báo!");
                txtTen.Focus();
                return;
            }
            tenDN();
            if (ten != "")
            {
                FrmPass p = new FrmPass();
                p.ShowDialog();
            }
            

        }
    }
}
