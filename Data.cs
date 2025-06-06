using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teashop
{
    class Data
    {
        protected static string connstr = "Data Source=localhost; database=TeaShop; Integrated Security = SSPI";
        public static DataTable DataQuery(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int DataExcute(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public static int ExecuteScalar(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            int i = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return i;
        }
    }
}
