using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiCuaHang
{
    class Functions
    {

        public static SqlConnection conn = new SqlConnection(@"data source=DESKTOP-95UDENR\SQLEXPRESS; initial catalog=QL_CUAHANGXEMAYHT; user id=sa; password=sa");
        
        DataColumn[] key = new DataColumn[1];

        public static void OpenConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();

            }
            conn.Open();
        }

        public static DataTable LoadDS(string sql)
        {
            DataTable dt_Load = new DataTable();
            SqlDataAdapter da_Load = new SqlDataAdapter(sql, conn);
            da_Load.Fill(dt_Load);
            return dt_Load;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
                MessageBox.Show("Thực hiện thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter MyData = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillComboBox(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
    }
}
