using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lbError.Text = "";
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
            lbError.Text = "";

            if (username == String.Empty || password == String.Empty)
            {
                lbError.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu";
            }
            else
            {
                int vendorID = Authentication.authenticate(username, password, type);
                if (vendorID == -1) lbError.Text = "Không tìm thấy tài khoản.";
                else
                {
                    this.Hide();
                    switch(type)
                    {
                        case 0:
                            MaintenanceForm maintenanceForm = new MaintenanceForm();
                            maintenanceForm.ShowDialog();
                            break;
                        case 1:
                            if (vendorID == 0)
                            {
                                SystemReportView reportView = new SystemReportView(0, 0);
                                reportView.ShowDialog();
                                break;
                            }
                            break;
                        case 2:
                            OrderListView orderForm = new OrderListView(vendorID);
                            orderForm.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Vui lòng kiểm tra lại database");
                            break;
                    }
                    this.Close();
                }
            }
        }
    }
}
