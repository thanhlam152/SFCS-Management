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
    public partial class MaintenanceForm : Form
    {

        bool Enable = true;
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            Enable = false;
            txtNote.Text = ("Hệ thống đã bị vô hiệu thống để phục vụ việc bảo trì. Để tái kích hoạt hệ thống, vui lòng chọn Enable.");
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            Enable = true;
            txtNote.Text = ("Để thực hiện bảo trì hệ thống. Vui lòng chọn Disable để tạm thời vô hiệu hóa các dịch vụ online.");
            btnEnable.Enabled = false;
            btnDisable.Enabled = true;
        }
    }
}
