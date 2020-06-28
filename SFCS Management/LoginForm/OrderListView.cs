using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class OrderListView : Form
    {
        public OrderListView(int vendorID)
        {
            InitializeComponent();

            viewOrderList(vendorID);
        }

        private void lbName_Click(object sender, EventArgs e, String orderID)
        {
            /*OrderView orderView = new OrderView(orderID);
            orderView.Name = orderID;
            orderView.Show(this);*/

            viewOrderDetails(orderID);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuView menuView = new MenuView();
            menuView.ShowDialog();
            this.Close();
        }

        private void viewOrderList(int vendorID)
        {
            pnlOrderList.Controls.Clear();

            #region DisplayOrderList

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select * from OrderDB where VendorID = @vendorID and Done = @done", sql_cnt);
            scmd.Parameters.AddWithValue("@vendorID", vendorID.ToString());
            scmd.Parameters.AddWithValue("@done", "false");

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            int i;

            for (i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow row = dt.Rows[i];

                Panel pnl = new Panel();
                Label lbName = new Label();
                Label lbPrice = new Label();

                pnlOrderList.Controls.Add(pnl);
                pnl.Controls.Add(lbName);
                pnl.Controls.Add(lbPrice);

                pnl.Location = new Point(2, 12 + 90 * i);
                pnl.Size = new Size(667, 73);
                pnl.BorderStyle = BorderStyle.FixedSingle;

                lbName.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbName.Location = new Point(19, 22);
                lbName.Size = new Size(236, 31);
                lbName.Name = row["id"].ToString();
                lbName.Text = "Đơn hàng #" + row["id"].ToString();
                lbName.Click += (sender, EventArgs) => { lbName_Click(sender, EventArgs, lbName.Name.ToString()); };

                lbPrice.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbPrice.Location = new Point(472, 22);
                lbPrice.Size = new Size(215, 41);
                lbPrice.Text = row["Total"].ToString() + " VND";

            }

            #endregion DisplayOrderList
        }

        private void viewOrderDetails(String orderID)
        {
            pnlOrderList.Controls.Clear();
            pnlOrderList.AutoScroll = true;

            #region GetData

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select * from OrderLineDB where orderId = @orderID", sql_cnt);
            scmd.Parameters.AddWithValue("@orderId", orderID);

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            #endregion GetData

            Button btnBack = new Button();
            Label lbID = new Label();

            pnlOrderList.Controls.Add(btnBack);
            pnlOrderList.Controls.Add(lbID);

            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBack.ForeColor = Color.Gray;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(10, 15);
            btnBack.Size = new Size(103, 40);
            btnBack.Text = "TRỞ LẠI";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            //btnBack.Click += new EventHandler(this.btnBack_Click);

            lbID.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbID.Location = new Point(520, 30);
            lbID.Size = new Size(300, 40);
            lbID.Text = "ID ĐƠN HÀNG. " + orderID;

            Panel pnlIOrderLine = new Panel();
            Label lbIName = new Label();
            Label lbIPrice = new Label();
            Label lbIQuantity = new Label();

            pnlOrderList.Controls.Add(pnlIOrderLine);
            pnlIOrderLine.Controls.Add(lbIName);
            pnlIOrderLine.Controls.Add(lbIPrice);
            pnlIOrderLine.Controls.Add(lbIQuantity);

            pnlIOrderLine.Location = new Point(3, 100);
            pnlIOrderLine.Size = new Size(700, 44);
            pnlIOrderLine.BorderStyle = BorderStyle.None;

            lbIName.Location = new Point(13, 11);
            lbIName.Size = new Size(300, 21);
            lbIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbIName.Text = "Tên món";

            lbIPrice.Location = new Point(350, 11);
            lbIPrice.Size = new Size(150, 21);
            lbIPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbIPrice.Text = "Đơn giá";

            lbIQuantity.Location = new Point(525, 11);
            lbIQuantity.Size = new Size(100, 21);
            lbIQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbIQuantity.Text = "Số lượng";

            int i;

            for (i = 0; i < dt.Rows.Count; ++i)
            {
                DataRow row = dt.Rows[i];

                Panel pnlOrderLine = new Panel();
                Label lbName = new Label();
                Label lbPrice = new Label();
                Label lbQuantity = new Label();

                pnlOrderList.Controls.Add(pnlOrderLine);
                pnlOrderLine.Controls.Add(lbName);
                pnlOrderLine.Controls.Add(lbPrice);
                pnlOrderLine.Controls.Add(lbQuantity);

                pnlOrderLine.Location = new Point(3, 150 + 50 * i);
                pnlOrderLine.Size = new Size(700, 44);
                pnlOrderLine.BorderStyle = BorderStyle.None;

                lbName.Location = new Point(13, 11);
                lbName.Size = new Size(300, 21);
                lbName.Font = new Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbName.Text = row["Name"].ToString();

                lbPrice.Location = new Point(350, 11);
                lbPrice.Size = new Size(150, 21);
                lbPrice.Font = new Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbPrice.Text = row["price"].ToString() + " VND";

                lbQuantity.Location = new Point(550, 11);
                lbQuantity.Size = new Size(42, 21);
                lbQuantity.Font = new Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbQuantity.Text = "x" + row["quantity"].ToString();
            }

            Panel pnlGap = new Panel();

            pnlOrderList.Controls.Add(pnlGap);
            pnlGap.Location = new Point(3, 200 + 50 * i);
            pnlGap.Size = new Size(700, 100);
            pnlGap.BorderStyle = BorderStyle.None;

            Button btnDone = new Button();

            pnlGap.Controls.Add(btnDone);
            btnDone.Location = new Point(450, 11);
            btnDone.Size = new Size(100, 50);
            btnDone.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDone.Text = "Hoàn thành";
            btnDone.Click += (sender, EventArgs) => { btnDone_Click(sender, EventArgs, orderID); };
        }

        private void btnDone_Click(object sender, EventArgs e, String orderID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("update OrderDB set done = @done where id = @orderID", sql_cnt);
            scmd.Parameters.AddWithValue("@done", "true");
            scmd.Parameters.AddWithValue("@orderId", orderID);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            ((Button)sender).Enabled = false;

            MessageBox.Show("Đã gửi thông báo đến khách hàng");
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    viewOrderList(vendorID);
        //}
    }
}
