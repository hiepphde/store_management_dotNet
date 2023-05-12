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
    public partial class FrmINBaoCao : Form
    {
        public FrmINBaoCao()
        {
            InitializeComponent();
        }

        private void FrmINBaoCao_Load(object sender, EventArgs e)
        {
            BaoCaoKho bck = new BaoCaoKho();
            bck.SetDatabaseLogon("sa", "sa");
            rpBaoCao.ReportSource = bck;
            rpBaoCao.Refresh();
        }
    }
}
