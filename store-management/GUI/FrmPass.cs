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
    public partial class FrmPass : Form
    {
        public FrmPass()
        {
            InitializeComponent();
            txtTen.Enabled = false;
            txtTen.Text = FrmTaiKhoan.ten;
            txtMKCu.PasswordChar = '*';
            txtMKMoi.PasswordChar = '*';
            txtNhapLai.PasswordChar = '*';
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Functions.OpenConn();
            string ktMK = "select matkhau from TaiKhoan where (MatKhau = '" + txtMKCu.Text.Trim() + "' and tenDN = '" + txtTen.Text.Trim() + "')";
            if (Functions.CheckKey(ktMK))
            {
                if (txtMKMoi.Text.Trim() == txtNhapLai.Text.Trim())
                {
                    string sql = "update TAIKHOAN set matkhau = '" + txtMKMoi.Text.Trim() + "' where tenDN = '" + txtTen.Text.Trim() + "'";
                    Functions.RunSQL(sql);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!", "Thông báo");
                    txtNhapLai.Clear();
                    txtNhapLai.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu khum đúng!", "Thông báo");
                txtMKCu.Clear();
                txtMKCu.Focus();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
