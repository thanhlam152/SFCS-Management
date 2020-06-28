using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFCSManagement
{
    public partial class MaintenanceForm : Form
    {

        bool enable = true;
        public MaintenanceForm()
        {
            InitializeComponent();
            enable = Program.checkEnabled();
            if (enable) EnableSystem();
            else DisableSystem();
        }

        private void UpdateSystemStatus()
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();

            SqlCommand scmd = new SqlCommand("update Enable set Enable = @Enable", sql_cnt);
            scmd.Parameters.AddWithValue("@Enable", enable.ToString());

            scmd.ExecuteNonQuery();
            sql_cnt.Close();
        }

        private void DisableSystem()
        {
            enable = false;
            txtNotification.Text = ("Hệ thống đã bị vô hiệu thống để phục vụ việc bảo trì. Để tái kích hoạt hệ thống, vui lòng chọn Enable.");
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
            UpdateSystemStatus();
        }

        private void EnableSystem()
        {
            enable = true;
            txtNotification.Text = ("Để thực hiện bảo trì hệ thống. Vui lòng chọn Disable để tạm thời vô hiệu hóa các dịch vụ online.");
            btnEnable.Enabled = false;
            btnDisable.Enabled = true;
            UpdateSystemStatus();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            DisableSystem();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            EnableSystem();
        }
    }
}
