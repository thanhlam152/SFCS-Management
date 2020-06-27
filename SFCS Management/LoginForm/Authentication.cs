using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    public static class Authentication
    {
        public static int authenticate(String username, String password, int type)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select VendorID from EmployeeAccountDB where Username = @username and Password = @password and type = @type", sql_cnt);
            scmd.Parameters.AddWithValue("@username", username);
            scmd.Parameters.AddWithValue("@password", password);
            scmd.Parameters.AddWithValue("@type", type.ToString());

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return (dt.Rows.Count == 0) ? -1 : ((int) dt.Rows[0]["VendorID"]);
        }
    }
}
