using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class MenuView : Form
    {
        public Menu model;
        public MenuController controller;

        public MenuView()
        {
            controller = new MenuController();
            model = controller.model;

            InitializeComponent();

            viewMenu();
        }

        private void pbImage_DoubleClick(object sender, EventArgs e, String itemId)
        { 
            EditForm editForm = new EditForm();
            editForm.Name = itemId;
            editForm.btnSave.Click += (btnSave_sender, EventArgs) => { btnSave_Click(sender, EventArgs, itemId); };
            editForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            editForm.Show(this);

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("select * from ItemDB where id = @itemId", sql_cnt);
            scmd.Parameters.AddWithValue("@itemID", itemId);

            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            editForm.txtName.Text = dt.Rows[0]["name"].ToString();
            editForm.txtDes.Text = dt.Rows[0]["description"].ToString();
            editForm.txtPrice.Text = dt.Rows[0]["price"].ToString();
            editForm.txtStatus.Text = (dt.Rows[0]["available"].ToString() == "True") ? "1" : "0";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //AddForm addForm = new AddForm();
            //addForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            ///addForm.Show(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e, String itemId)
        {
            /*foreach(Item item in model.menu)
            {
                if (item.id.ToString() == itemId)
                {
                    EditForm;

                }
            }*/
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.getAllItem(ref model);
            viewMenu();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewMenu()
        {
            pnlMenu.Controls.Clear();

            #region DisplayMenu 

            int idx;

            //Create panel for each item
            for (idx = 0; idx < model.menu.Count; ++idx)
            {
                Item item = model.menu[idx];

                Panel pnlItem = new Panel();
                PictureBox pbImage = new PictureBox();
                TextBox txtName = new TextBox();
                TextBox txtDes = new TextBox();
                Label lbPrice = new Label();
                Label lbAvailable = new Label();

                pnlMenu.Controls.Add(pnlItem);
                pnlItem.Controls.Add(pbImage);
                pnlItem.Controls.Add(txtName);
                pnlItem.Controls.Add(txtDes);
                pnlItem.Controls.Add(lbPrice);
                pnlItem.Controls.Add(lbAvailable);

                pnlItem.Location = new Point(32 + 216 * (idx % 3), 32 + 288 * (idx / 3));
                pnlItem.Size = new Size(170, 262);
                pnlItem.BackColor = Color.White;

                pbImage.Location = new Point(2, 2);
                pbImage.Size = new Size(165, 134);
                pbImage.Name = item.id.ToString();
                pbImage.BorderStyle = BorderStyle.FixedSingle;
                pbImage.DoubleClick += (sender, EventArgs) => { pbImage_DoubleClick(sender, EventArgs, pbImage.Name); };

                txtName.Location = new Point(6, 141);
                txtName.Size = new Size(161, 45);
                txtName.BorderStyle = BorderStyle.None;
                txtName.Font = new Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtName.Multiline = true;
                txtName.Text = item.name.ToString();
                txtName.ReadOnly = true;
                txtName.BackColor = pnlItem.BackColor;

                txtDes.Location = new Point(6, 190);
                txtDes.Size = new Size(161, 42);
                txtDes.BorderStyle = BorderStyle.None;
                txtDes.Font = new Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtDes.Multiline = true;
                txtDes.Text = item.description.ToString();
                txtDes.ReadOnly = true;
                txtDes.BackColor = pnlItem.BackColor;

                lbPrice.Location = new Point(3, 236);
                lbPrice.Size = new Size(85, 16);
                lbPrice.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbPrice.Text = item.price.ToString() + " VND";

                lbAvailable.Location = new Point(120, 238);
                lbAvailable.Size = new Size(40, 14);
                lbAvailable.Text = (item.available.ToString() == "False") ? "Đã hết" : "";
            }

            //Create Add panel
            Panel pnlAdd = new Panel();
            PictureBox add_btn = new PictureBox();

            pnlMenu.Controls.Add(pnlAdd);
            pnlAdd.Controls.Add(add_btn);

            pnlAdd.Location = new Point(32 + 216 * (idx % 3), 32 + 288 * (idx / 3));
            pnlAdd.Size = new Size(170, 262);
            pnlAdd.BackColor = Color.WhiteSmoke;

            //add_btn.Image = Properties.Resources.add_btn;
            add_btn.Location = new System.Drawing.Point(45, 90);
            add_btn.Size = new System.Drawing.Size(80, 80);
            add_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            add_btn.Click += (sender, EventArgs) => { add_btn_Click(sender, EventArgs); };

            //Create gap to the end of the page
            Panel pnlGap = new Panel();

            pnlMenu.Controls.Add(pnlGap);

            pnlGap.Location = new Point(0, 32 + 288 * (idx / 3) + 288);
            pnlGap.Size = new Size(40, 40);

            #endregion DisplayMenu

        }
    }
}
