using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class MenuView : Form
    {
        int VendorID = new int();

        public MenuView(int VendorID)
        {
            this.VendorID = VendorID;
            InitializeComponent();
            viewMenu();
            lbVendorName.Text = Program.getVendorName(VendorID).ToUpper();
        }

        private void viewMenu()
        {
            DataTable dt = Program.getMenu(VendorID);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                Panel pnlItem = new Panel();
                Panel pnlLine = new Panel();
                Label lbItemName = new Label();
                PictureBox pbItemImage = new PictureBox();
                Label lbSymbolVND = new Label();
                Label lbItemPrice = new Label();
                Label lbItemAvailable = new Label();
                Button btnDel = new Button();
                Button btnEdit = new Button();
                Label lbDescription = new Label();

                pnlMenu.Controls.Add(pnlItem);

                pnlItem.Controls.Add(lbDescription);
                pnlItem.Controls.Add(btnEdit);
                pnlItem.Controls.Add(btnDel);
                pnlItem.Controls.Add(lbItemAvailable);
                pnlItem.Controls.Add(lbItemPrice);
                pnlItem.Controls.Add(lbSymbolVND);
                pnlItem.Controls.Add(pnlLine);
                pnlItem.Controls.Add(lbItemName);
                pnlItem.Controls.Add(pbItemImage);
                pnlItem.Location = new System.Drawing.Point(13, 180 + 119 * i);
                pnlItem.Size = new System.Drawing.Size(650, 119);

                pnlLine.BackColor = System.Drawing.Color.Gray;
                pnlLine.Location = new System.Drawing.Point(2, 112);
                pnlLine.Size = new System.Drawing.Size(640, 1);

                lbItemName.AutoSize = true;
                lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbItemName.Location = new System.Drawing.Point(111, 3);
                lbItemName.Text = dt.Rows[i]["Name"].ToString();

                pbItemImage.Location = new System.Drawing.Point(3, 3);
                pbItemImage.Size = new System.Drawing.Size(104, 104);
                pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                if (!dt.Rows[i]["Image"].Equals(System.DBNull.Value))
                {
                    Byte[] data = (Byte[])(dt.Rows[i]["Image"]);
                    MemoryStream mem = new MemoryStream(data);
                    pbItemImage.Image = Image.FromStream(mem);
                }
                else pbItemImage.Image = pictureBox1.Image;
                
                lbSymbolVND.AutoSize = true;
                lbSymbolVND.Location = new System.Drawing.Point(410, 42);
                lbSymbolVND.Text = "đ";

                lbItemPrice.AutoSize = true;
                lbItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbItemPrice.Location = new System.Drawing.Point(422, 42);
                lbItemPrice.Text = dt.Rows[i]["Price"].ToString();

                lbItemAvailable.AutoSize = true;
                lbItemAvailable.ForeColor = System.Drawing.Color.Red;
                lbItemAvailable.Location = new System.Drawing.Point(113, 36);
                lbItemAvailable.Text = ((bool)dt.Rows[i]["Available"] == false) ? "Đã hết" : "";

                btnDel.BackColor = System.Drawing.Color.Red;
                btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDel.ForeColor = System.Drawing.Color.White;
                btnDel.Location = new System.Drawing.Point(572, 36);
                btnDel.Size = new System.Drawing.Size(71, 35);
                btnDel.Text = "Xóa";
                btnDel.UseVisualStyleBackColor = false;
                btnDel.Name = dt.Rows[i]["ID"].ToString();
                btnDel.Click += new System.EventHandler(this.btnDel_Click);


                btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
                btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnEdit.ForeColor = System.Drawing.Color.White;
                btnEdit.Location = new System.Drawing.Point(496, 36);
                btnEdit.Size = new System.Drawing.Size(71, 35);
                btnEdit.Text = "Sửa";
                btnEdit.UseVisualStyleBackColor = false;
                btnEdit.Name = dt.Rows[i]["ID"].ToString();
                btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

                lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbDescription.Location = new System.Drawing.Point(112, 56);
                lbDescription.Size = new System.Drawing.Size(228, 51);
                lbDescription.Text = dt.Rows[i]["Description"].ToString();
            }
            pnlGap.Location = new Point(pnlGap.Location.X, 180 + 119 * dt.Rows.Count);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderListView orderListView = new OrderListView(VendorID);
            this.Hide();
            orderListView.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(VendorID);
            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Program.DeleteItem(Int32.Parse(((Button)sender).Name));
            MenuView menuView = new MenuView(VendorID);
            this.Hide();
            menuView.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(VendorID, Int32.Parse(((Button)sender).Name));
            this.Hide();
            editForm.ShowDialog();
            this.Close();
        }
    }
}
