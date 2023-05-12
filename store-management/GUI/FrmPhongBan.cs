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
    public partial class FrmPhongBan : Form
    {
        DataTable tblPhongBan;
        public FrmPhongBan()
        {
            InitializeComponent();
        }

        private void Load_Treeview()
        {
            treeView1.Nodes.Clear();
            Functions.OpenConn();
            DataTable nodecha = new DataTable();
            DataTable nodecon = new DataTable();
            nodecha = Functions.LoadDS("select maPH,tenPH from PhongBan");
            for (int i = 0; i < nodecha.Rows.Count; i++)
            {
                treeView1.Nodes.Add(nodecha.Rows[i][1].ToString() + "(" + nodecha.Rows[i][0].ToString().Trim() + ")");
                treeView1.Nodes[i].Tag = "1";
                nodecon = Functions.LoadDS("select nv.HoTen from NhanVien nv, PhongBan pb where nv.MaPH = pb.MaPH and pb.tenPH = N'" + nodecha.Rows[i][1].ToString() + "'");
                for (int j = 0; j < nodecon.Rows.Count; j++)
                {
                    treeView1.Nodes[i].Nodes.Add(nodecon.Rows[j][0].ToString());
                    treeView1.Nodes[i].Nodes[j].Tag = "2";
                }
            }
        }//add cái tên với cái mã chỗ nào ?
        // cái vòng for chỉ hiển thị tên nhân viên trong phòng ban thôi
        // còn load là cái select nodecha // em đã load lên như thế, thì nó hiện thị ra cái text chứ ko bốc là mã với tên đc đâu, nên em phải tách chuỗi
        //mà giờ lấy cái text ra trruocw da
        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Load_Treeview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            string key = "SELECT maPH FROM PhongBan WHERE maPH = N'" + txtMa.Text + "'";
            if (Functions.CheckKey(key))
            {
                MessageBox.Show("Mã Phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMa.Clear();
                txtMa.Focus();
                return;
            }
            string sql = "insert into PhongBan values ('" + txtMa.Text + "',N'" + txtTen.Text + "')";
            Functions.RunSQL(sql);
            treeView1.Nodes.Clear();
            Load_Treeview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
            string key = "select maPH from PhongBan where maPH = '" + txtMa.Text.Trim() + "'";
            if (Functions.CheckKey(key))
            {
                string sql = "Delete from PhongBan where maPH = '" + txtMa.Text.Trim() + "'";
                Functions.RunSQL(sql);
                txtMa.Clear();
                Load_Treeview();
            }
            else
            {
                MessageBox.Show("Phòng ban này không tồn tại!");
                return;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //txtMa.Text = treeView1.SelectedNode.IsSelected.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            string click = treeView1.SelectedNode.Text;
            string ma = click.Substring(click.Length - 5, 4);
            string ten = click.Substring(0, click.Length - 6);
            txtMa.Text = ma;
            txtTen.Text = ten;
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            string sql = "update PHONGBAN set TenPH = N'" + txtTen.Text.Trim() + "' where maPH = '" + txtMa.Text.Trim() + "'";
            Functions.RunSQL(sql);
            Load_Treeview();
        }
    }
}
