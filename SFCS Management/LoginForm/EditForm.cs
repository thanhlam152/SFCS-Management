using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SFCSManagement
{
    public partial class EditForm : Form
    {
        int VendorID = new int();
        int ItemID = new int();
        public EditForm(int VendorID)
        {
            this.VendorID = VendorID;
            InitializeComponent();
            btnSave.Text = "Thêm";
            btnSave.Click += new System.EventHandler(this.Create_Click);
        }

        public EditForm(int VendorID, int ItemID)
        {
            this.VendorID = VendorID;
            this.ItemID = ItemID;
            InitializeComponent();
            viewItem();
            btnSave.Text = "Lưu";
            btnSave.Click += new System.EventHandler(this.Save_Click);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuView menuView = new MenuView(VendorID);
            this.Hide();
            menuView.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderListView orderListView = new OrderListView(VendorID);
            this.Hide();
            orderListView.ShowDialog();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG|*.png|JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    String imgLocation = ofd.FileName;
                    pbItemImage.ImageLocation = imgLocation;
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            if (pbItemImage.ImageLocation != null)
            {
                FileStream stream = new FileStream(pbItemImage.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
            }

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd;
            if (image != null)
            {
                scmd = new SqlCommand("insert into ItemDB (Name, Price, VendorID, Available, Description, Image) values (@Name, @Price, @VendorID, @Available, @Description, @Image)", sql_cnt);
                scmd.Parameters.AddWithValue("@Image", image);
            }
            else
            {
                scmd = new SqlCommand("insert into ItemDB (Name, Price, VendorID, Available, Description) values (@Name, @Price, @VendorID, @Available, @Description)", sql_cnt);
            }
            scmd.Parameters.AddWithValue("@Name", txtName.Text);
            scmd.Parameters.AddWithValue("@Price", Int64.Parse(txtPrice.Text));
            scmd.Parameters.AddWithValue("@VendorID", VendorID);
            scmd.Parameters.AddWithValue("@Available", cbAvailable.Checked);
            scmd.Parameters.AddWithValue("@Description", txtDescription.Text);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            if (pbItemImage.ImageLocation != null)
            {
                FileStream stream = new FileStream(pbItemImage.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
            }

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd;
            if (image != null)
            {
                scmd = new SqlCommand("update ItemDB set Name = @Name, Price = @Price, VendorID = @VendorID, Available = @Available, Description = @Description, Image = @Image where ID = @ItemID", sql_cnt);
                scmd.Parameters.AddWithValue("@Image", image);
            }
            else
            {
                scmd = new SqlCommand("update ItemDB set Name = @Name, Price = @Price, VendorID = @VendorID, Available = @Available, Description = @Description where ID = @ItemID", sql_cnt);
            }
            scmd.Parameters.AddWithValue("@Name", txtName.Text);
            scmd.Parameters.AddWithValue("@Price", Int64.Parse(txtPrice.Text));
            scmd.Parameters.AddWithValue("@VendorID", VendorID);
            scmd.Parameters.AddWithValue("@Available", cbAvailable.Checked);
            scmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            scmd.Parameters.AddWithValue("@ItemID", ItemID);

            scmd.ExecuteNonQuery();
            sql_cnt.Close();
        }

        private void viewItem()
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from ItemDB where ID = @ItemID", sql_cnt);
            scmd.Parameters.AddWithValue("@ItemID", ItemID);
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtDescription.Text = dt.Rows[0]["Description"].ToString();
            txtPrice.Text = dt.Rows[0]["Price"].ToString();
            cbAvailable.Checked = (bool)dt.Rows[0]["Available"];

            if (!dt.Rows[0]["Image"].Equals(System.DBNull.Value))
            {
                Byte[] data = (Byte[])(dt.Rows[0]["Image"]);
                MemoryStream mem = new MemoryStream(data);
                pbItemImage.Image = Image.FromStream(mem);
            }
        }
    }
}
