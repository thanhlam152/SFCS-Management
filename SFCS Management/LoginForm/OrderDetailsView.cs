using SFCSManagement;
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

namespace SFCSManagement
{
    public partial class OrderDetailsView : Form
    {
        private int VendorID = new int();
        private int OrderID = new int();
        public OrderDetailsView(int OrderID)
        {
            this.OrderID = OrderID;
            this.VendorID = getVendorIDByOrderID(OrderID);
            InitializeComponent();
            lbOrderID.Text += OrderID.ToString();
            lbVendorName.Text = Program.getVendorName(VendorID).ToUpper();
            viewOrderDetails();
        }

        private void viewOrderDetails()
        {
            DataTable dt = Program.getOrderDetails(OrderID);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                Panel pnlOrderLine = new Panel();
                Label lbItemName = new Label();
                Label lbItemQuantity = new Label();
                Label lbItemSubPrice = new Label();
                Label lbSymbolVND = new Label();
                Panel pnlLine = new Panel();

                pnlOrderDetails.Controls.Add(pnlOrderLine);

                pnlOrderLine.Controls.Add(pnlLine);
                pnlOrderLine.Controls.Add(lbSymbolVND);
                pnlOrderLine.Controls.Add(lbItemSubPrice);
                pnlOrderLine.Controls.Add(lbItemQuantity);
                pnlOrderLine.Controls.Add(lbItemName);
                pnlOrderLine.Location = new System.Drawing.Point(16, 154 + 73 * i);
                pnlOrderLine.Size = new System.Drawing.Size(635, 73);

                lbItemName.AutoSize = true;
                lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbItemName.Location = new System.Drawing.Point(22, 8);
                lbItemName.Text = dt.Rows[i]["Name"].ToString();

                lbItemQuantity.AutoSize = true;
                lbItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbItemQuantity.Location = new System.Drawing.Point(22, 41);
                lbItemQuantity.Text = "x" + dt.Rows[i]["Quantity"].ToString();

                lbItemSubPrice.AutoSize = true;
                lbItemSubPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbItemSubPrice.Location = new System.Drawing.Point(538, 30);
                lbItemSubPrice.Text = dt.Rows[i]["SubPrice"].ToString();
 
                lbSymbolVND.AutoSize = true;
                lbSymbolVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbSymbolVND.Location = new System.Drawing.Point(526, 30);
                lbSymbolVND.Text = "đ";

                pnlLine.BackColor = System.Drawing.Color.Gray;
                pnlLine.Location = new System.Drawing.Point(7, 69);
                pnlLine.Size = new System.Drawing.Size(620, 1);
            }

            pnlDoneArea.Location = new Point(pnlDoneArea.Location.X, 153 + 73 * dt.Rows.Count);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrderListView orderListView = new OrderListView(VendorID);
            orderListView.ShowDialog();
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            setOrderDone(OrderID);
            btnDone.Enabled = false;
        }

        private void setOrderDone(int OrderID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("update OrderDB set Done = @Done where ID = @OrderDB", sql_cnt);
            scmd.Parameters.AddWithValue("@Done", "true");
            scmd.Parameters.AddWithValue("@OrderDB", OrderID.ToString());
            scmd.ExecuteNonQuery();
            sql_cnt.Close();
        }

        private int getVendorIDByOrderID(int OrderID)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from OrderDB where ID = @OrderID", sql_cnt);
            scmd.Parameters.AddWithValue("@OrderID", OrderID.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            return (int)dt.Rows[0]["VendorID"];
        }
    }
}
