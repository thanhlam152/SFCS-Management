using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static int type = 0;

        void releaseChoice()
        {
            btnITer.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            btnManager.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            btnCook.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));

        }

        private void btnITer_Click(object sender, EventArgs e)
        {
            type = 0;
            releaseChoice();
            btnITer.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            type = 1;
            releaseChoice();
            btnManager.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            type = 2;
            releaseChoice();
            btnCook.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            txtMissedInput.Text = "";

            if (username == String.Empty || password == String.Empty)
            {
                txtMissedInput.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu";
            }
            else
            {
                int vendorID = Authentication.authenticate(username, password, type);
                if (vendorID == -1) txtMissedInput.Text = "Không tìm thấy tài khoản.";
                else
                {
                    txtMissedInput.Text = vendorID.ToString();
                    if (vendorID == 0)
                    {
                        Program.openMaintenanceForm();
                        this.Close();
                    }
                }
            }
        }           
        public void btnMenu_Click(object sender, EventArgs e)
        {
            createMenuView();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            createOrderForm();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = null;
            txtUsername.Text = null;
            this.Show();
        }

        private void createMenuView()
        {
            this.Hide();
            MenuView menuView = new MenuView();
            menuView.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            menuView.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            menuView.Show(this);
        }

        private void createOrderForm()
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            orderForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            orderForm.Show(this);
        }
    }
}
