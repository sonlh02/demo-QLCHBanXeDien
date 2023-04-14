using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanXeDien
{
    class ketnoi
    {
        string con_str = "Data Source=SON;Initial Catalog=QLCHBanXeDien;Integrated Security=True";
        public DataSet laydulieu(string query, string table_name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, table_name);
                return ds;
            }
            catch { }
            return null;

        }
        public bool thucthi(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                return sl > 0;
            }
            catch
            { }
            return false;
        }
    }
}
