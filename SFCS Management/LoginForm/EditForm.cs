using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("update ItemDB set name = @name, description = @description, price = @price, available = @available where id = @itemId", sql_cnt);
            scmd.Parameters.AddWithValue("@itemID", this.Name);
            scmd.Parameters.AddWithValue("@name", txtName.Text.ToString());
            scmd.Parameters.AddWithValue("@description", txtDes.Text.ToString());
            scmd.Parameters.AddWithValue("@price", txtPrice.Text.ToString());
            scmd.Parameters.AddWithValue("@available", txtStatus.Text.ToString());

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("delete from ItemDB where id = @itemId", sql_cnt);
            scmd.Parameters.AddWithValue("@itemID", this.Name);

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            this.Close();
        }
    }
}
