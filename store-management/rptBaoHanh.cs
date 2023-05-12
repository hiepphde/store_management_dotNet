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
    public partial class rptBaoHanh : Form
    {
        DataTable tb;
        public rptBaoHanh()
        {
            InitializeComponent();
        }



        private void rptBaoHanh_Load(object sender, EventArgs e)
        {
            string sql = "select * from BAOHANH";
            Functions.FillComboBox(sql, cbxIN, "MaBH", "MaBH");
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            string sql = " SELECT * From BAOHANH where MABH='" + cbxIN.SelectedValue.ToString() + "'";
            tb = Functions.LoadDS(sql);

            rpBaoHanh rp = new rpBaoHanh();
            rp.SetDataSource(tb);
            rp.SetDatabaseLogon("sa", "sa");
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
    }
}
