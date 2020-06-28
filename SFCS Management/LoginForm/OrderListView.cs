using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class OrderListView : Form
    {
        private int VendorID = new int();

        public OrderListView(int VendorID)
        {
            this.VendorID = VendorID;
            InitializeComponent();
            viewOrderList();
            lbVendorName.Text = Program.getVendorName(VendorID).ToUpper();
        }

        private void viewOrderList()
        {
            DataTable dt = Program.getListOfOrder(VendorID);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                Panel pnlOrder = new Panel();
                Panel pnlLine = new Panel();
                Button btnView = new Button();
                Label lbSymbolVND = new Label();
                Label lbTotal = new Label();
                Label lbOrderID = new Label();
                PictureBox pbOrderIcon = new PictureBox();

                pnlOrderList.Controls.Add(pnlOrder);

                pnlOrder.Controls.Add(pnlLine);
                pnlOrder.Controls.Add(btnView);
                pnlOrder.Controls.Add(lbTotal);
                pnlOrder.Controls.Add(lbSymbolVND);
                pnlOrder.Controls.Add(lbOrderID);
                pnlOrder.Controls.Add(pbOrderIcon);
                pnlOrder.Location = new System.Drawing.Point(13, 162 + 98 * i);
                pnlOrder.Size = new System.Drawing.Size(650, 98);

                pnlLine.BackColor = System.Drawing.Color.Gray;
                pnlLine.Location = new System.Drawing.Point(10, 87);
                pnlLine.Size = new System.Drawing.Size(630, 1);

                btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
                btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnView.ForeColor = System.Drawing.Color.White;
                btnView.Location = new System.Drawing.Point(530, 24);
                btnView.Size = new System.Drawing.Size(110, 46);
                btnView.Text = "Xem chi tiết";
                btnView.UseVisualStyleBackColor = false;
                btnView.Name = dt.Rows[i]["ID"].ToString();
                btnView.Click += (sender, EventArgs) => { btnView_Click(sender, EventArgs); };

                lbTotal.AutoSize = true;
                lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbTotal.Location = new System.Drawing.Point(100, 50);
                lbTotal.Text = dt.Rows[i]["Total"].ToString();

                lbSymbolVND.AutoSize = true;
                lbSymbolVND.Location = new System.Drawing.Point(90, 50);
                lbSymbolVND.Text = "đ";

                lbOrderID.AutoSize = true;
                lbOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbOrderID.Location = new System.Drawing.Point(90, 15);
                lbOrderID.Text = "Đơn hàng #" + dt.Rows[i]["ID"].ToString();

                pbOrderIcon.Image = this.pbOrderIcon.Image;
                pbOrderIcon.Location = new System.Drawing.Point(2, 3);
                pbOrderIcon.Size = new System.Drawing.Size(80, 80);
                pbOrderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pbOrderIcon.TabStop = false;
            }

            pnlGap.Location = new Point(pnlGap.Location.X, 162 + 98 * dt.Rows.Count);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int OrderID = Int32.Parse(((Button)sender).Name);
            OrderDetailsView orderDetailsView = new OrderDetailsView(VendorID, OrderID);
            this.Hide();
            orderDetailsView.ShowDialog();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuView menuView = new MenuView(VendorID);
            this.Hide();
            menuView.ShowDialog();
            this.Close();
        }
    }
}
