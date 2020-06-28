using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    public class MenuController
    {
        public Menu model;

        public MenuController()
        {
            model = new Menu();
            getAllItem(ref model);
        }

        public void getAllItem(ref Menu model)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select * from ItemDB", sql_cnt);

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            model.menu.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Item item = new Item((int)row["id"]);
                item.name = row["name"].ToString();
                item.description = row["description"].ToString();
                item.price = (Int64)row["price"];
                item.available = (bool)row["available"];

                model.menu.Add(item);
            }
        }
    }
}
