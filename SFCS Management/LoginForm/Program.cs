using LoginForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static String getVendorName(int VendorID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from VendorDB where ID = @VendorID", sql_cnt);
            scmd.Parameters.AddWithValue("@VendorID", VendorID.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return dt.Rows[0]["Name"].ToString();
        }

        public static bool checkEnabled()
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select Enable from Enable", sql_cnt);

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return ((bool)dt.Rows[0]["Enable"] == true);
        }

        public static DataTable getOrderDetails(int OrderID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from OrderLineDB where OrderID = @OrderID", sql_cnt);
            scmd.Parameters.AddWithValue("@OrderID", OrderID.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return dt;
        } 

        public static DataTable getListOfOrder(int VendorID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from OrderDB where VendorID = @VendorID and Done = @Done", sql_cnt);
            scmd.Parameters.AddWithValue("@VendorID", VendorID.ToString());
            scmd.Parameters.AddWithValue("@Done", "false");
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return dt;
        }

        public static DataTable getMenu(int VendorID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from ItemDB where VendorID = @VendorID", sql_cnt);
            scmd.Parameters.AddWithValue("@VendorID", VendorID.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return dt;
        }

        public static void DeleteItem(int ItemID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("delete from ItemDB where ID = @ItemID", sql_cnt);
            scmd.Parameters.AddWithValue("@ItemID", ItemID);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SystemReportView());
        }
    }
}
