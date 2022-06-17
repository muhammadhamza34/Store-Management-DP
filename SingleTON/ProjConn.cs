using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace StoreManagementSystem
{
    public class ProjConn
    {
        private static SqlConnection conn;

        public static SqlConnection getcon()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-DC3STC6;Initial Catalog=Store_management_system;Integrated Security=True");
                conn.Open();
            }
            else
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn.Open();
            }
            
            return conn;

        }

        public static void Close()
        {
            conn.Close();
        }

        public static  DataTable display(string a)
        {
            SqlDataAdapter cd = new SqlDataAdapter(a, getcon());
            DataTable dt = new DataTable();
            dt.Clear();
            cd.Fill(dt);
            return dt;
        }

        public static DataTable Show(string a, int id)
        {
           
            SqlDataAdapter cd = new SqlDataAdapter(a + id, getcon());
            DataTable dt = new DataTable();
            dt.Clear();
            cd.Fill(dt);
            return dt;
        }

    }
}
