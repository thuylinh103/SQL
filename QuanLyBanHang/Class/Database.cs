using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Class
{
    public class Database
    {
        private string connetion = @"Data Source=DESKTOP-A3IFC3A\SQLEXPRESS;Initial Catalog=NewQLCHTL;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connetion);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);//nội dung sql đc truyền vào
                cmd.CommandType = CommandType.StoredProcedure;//set command type cho cmd
                foreach (var para in lstPara)//gán các tham số cho cmd
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
