using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace SFCSManagement
{
    public partial class VendorReport : UserControl
    { 
        SqlConnection cnn;
        public VendorReport()
        {
            InitializeComponent();
            cnn = new SqlConnection(ConnectString.connectString);
            cnn.Open();

            string sql = "SELECT DISTINCT Name FROM VendorDB";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dataReader = cmd.ExecuteReader();

            string vendorName = "";
            while (dataReader.Read())
            {
                vendorName = dataReader[0].ToString();
                bxVendor.Items.Add(vendorName.Trim());

            }
            cnn.Close();
            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            thisButton.Checked = true;
            thisYearButton.Checked = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btnView.Enabled = false;
        }

        public VendorReport(int vendorID)
        {
            InitializeComponent();
            cnn = new SqlConnection(ConnectString.connectString);

            string vendorName = Program.getVendorName(vendorID);
            bxVendor.Items.Add(vendorName.Trim());
            bxVendor.Text = vendorName;

            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            thisButton.Checked = true;
            thisYearButton.Checked = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btnView.Enabled = false;
        }

        private void bxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bxField.SelectedIndex > -1 && bxType.SelectedIndex > -1 && bxVendor.SelectedIndex > -1)
            {
                btnView.Enabled = true;
            } else
            {
                btnView.Enabled = false;
            }
        }

        private void BxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bxField.SelectedIndex > -1)
            {
                if (bxType.SelectedIndex > -1 && bxVendor.SelectedIndex > -1)
                {
                    btnView.Enabled = true;                  
                } else
                {
                    btnView.Enabled = false;
                }
                if (bxField.Text == "Month")
                {
                    groupBox1.Visible = true;
                    groupBox2.Visible = false;
                }
                else if (bxField.Text == "Year")
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                }

            } else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                btnView.Enabled = false;
            }
            
        }
        public int slMonth { set; get; }
        public int countrow()
        {
            string stmt = "SELECT COUNT(*) FROM OrderDB";
            int count = 0;
            cnn.Open();
            SqlCommand cmdCount = new SqlCommand(stmt, cnn);
            count = (int)cmdCount.ExecuteScalar();
            cnn.Close();
           
            return count;
        }

        SaleList[] list;
        private void getData()
        {
            int n = countrow();
            list = new SaleList[n];

          
            string totalstring = "";
            string vname = "";
            int year = 0;
            int month = 0;
            int day = 0;

            string sql1 = "CREATE OR ALTER VIEW order_vendor " +
                "AS SELECT OrderDB.Total, day(OrderDB.Datetime) AS Day, month(OrderDB.Datetime) " +
                "AS Month, year(OrderDB.Datetime) AS Year, VendorDB.Name AS Vendor FROM OrderDB INNER JOIN VendorDB ON OrderDB.VendorID = VendorDB.ID";
            string sql2 = "SELECT * FROM order_vendor";
            cnn.Open();

            SqlCommand cmd1 = new SqlCommand(sql1, cnn);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(sql2, cnn);
            SqlDataReader dr = cmd2.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                totalstring = dr["Total"].ToString();
                vname = dr["Vendor"].ToString();
                year = Convert.ToInt32(dr["Year"]);
                month = Convert.ToInt32(dr["Month"]);
                day = Convert.ToInt32(dr["Day"]);

                list[i] = new SaleList();
                list[i].Total = Convert.ToInt32(totalstring.Trim()) ;
                list[i].Vendor = vname;
                list[i].Year = year;
                list[i].Month = month;
                list[i].Day = day;

                i++;
                
            }

            
            cnn.Close();

        }
        private void ProcessYear(string vendor)
        {
            Int32[] ttMonth=new Int32[12];
            int n = countrow();
            for (int i = 0; i < n; i++)
            {
                if (list[i].Vendor == vendor)
                {
                    for (int k = 1; k < 13; k++)
                    {   
                        if (thisYearButton.Checked == true)
                        {
                            if (list[i].Month == k && list[i].Year == DateTime.Now.Year)
                            {
                                ttMonth[k - 1] += list[i].Total;
                            }
                        } else if (lastYearButton.Checked == true)
                        {
                            if (list[i].Month == k && list[i].Year == DateTime.Now.Year - 1)
                            {
                                ttMonth[k - 1] += list[i].Total;
                            }
                        }
                        
                    }
                    
                }
            }

            int value = 0;
            for (int k = 0; k < 12; k++)
            {
                value = ttMonth[k];
            }
           
            cnn.Open();
            for (int i = 0; i < 12; i++)
            {
                SqlCommand cmd3 = new SqlCommand("UPDATE MonthRevenue SET Revenue = @rv WHERE Month = @month", cnn);
                cmd3.Parameters.AddWithValue("@rv", ttMonth[i]);
                cmd3.Parameters.AddWithValue("@month", i+1);
                cmd3.ExecuteNonQuery();
            }
            
            cnn.Close();

        }

        private void ProcessMonth(string vendor)
        {
            Int32[] ttDay = new Int32[31];
            int n = countrow();
            for (int i = 0; i < n; i++)
            {
                if (list[i].Vendor == vendor)
                {
                    for (int k = 1; k < 32; k++)
                    {
                        if (thisButton.Checked == true)
                        {
                            if (list[i].Day == k && list[i].Month == DateTime.Now.Month)
                            {
                                ttDay[k - 1] += list[i].Total;
                            }
                        } else if (lastButton.Checked == true)
                        {
                            if (list[i].Day == k && list[i].Month == DateTime.Now.Month - 1)
                            {
                                ttDay[k - 1] += list[i].Total;
                            }
                        }
                    }

                }
            }


            cnn.Open();
            for (int i = 0; i < 31; i++)
            {
                SqlCommand cmd3 = new SqlCommand("UPDATE DayRevenue SET Revenue = @rv WHERE Day = @day", cnn);
                cmd3.Parameters.AddWithValue("@rv", ttDay[i]);
                cmd3.Parameters.AddWithValue("@day", i + 1);
                cmd3.ExecuteNonQuery();
            }

            cnn.Close();

        }

        
        public void piechart()
        {
            string sql = "";
            if (bxField.Text == "Month")
            {
                sql = "select * from DayRevenue";
                cnn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter cmd = new SqlDataAdapter(sql, cnn);
                cmd.Fill(dt);
                chart2.DataSource = dt;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Days";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Revenue";
                chart2.Series["Revenue"].XValueMember = "Day";
                chart2.Series["Revenue"].YValueMembers = "Revenue";
            }
            else if (bxField.Text == "Year")
            {
                sql = "select * from MonthRevenue";
                cnn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter cmd = new SqlDataAdapter(sql, cnn);
                cmd.Fill(dt);
                chart2.DataSource = dt;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "Months";
                chart2.ChartAreas["ChartArea1"].AxisY.Title = "Revenue";
                chart2.Series["Revenue"].XValueMember = "Month";
                chart2.Series["Revenue"].YValueMembers = "Revenue";

            }

            


            /*SqlDataReader dr = cmd.ExecuteReader();
            Series sr = new Series();
           while(dr.Read())
            {
                this.chart1.Series[0].Points.AddY(dr.GetInt32(0));
            }*/
            cnn.Close();
        }
        public void linechart()
        {
            string sql = "";
            if (bxField.Text == "Month")
            {
                sql = "select * from DayRevenue";
                cnn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter cmd = new SqlDataAdapter(sql, cnn);
                cmd.Fill(dt);
                chart3.DataSource = dt;
                chart3.ChartAreas["ChartArea1"].AxisX.Title = "Days";
                chart3.ChartAreas["ChartArea1"].AxisY.Title = "Revenue";
                chart3.Series["Revenue"].XValueMember = "Day";
                chart3.Series["Revenue"].YValueMembers = "Revenue";
            }
            else if (bxField.Text == "Year")
            {
                sql = "select * from MonthRevenue";
                cnn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter cmd = new SqlDataAdapter(sql, cnn);
                cmd.Fill(dt);
                chart3.DataSource = dt;
                chart3.ChartAreas["ChartArea1"].AxisX.Title = "Months";
                chart3.ChartAreas["ChartArea1"].AxisY.Title = "Revenue";
                chart3.Series["Revenue"].XValueMember = "Month";
                chart3.Series["Revenue"].YValueMembers = "Revenue";

            }
            cnn.Close();
        }
        public void refreshdata()
        {
            getData();
            ProcessYear(bxVendor.Text);
            ProcessMonth(bxVendor.Text);
            thisButton.Checked = true;
            thisYearButton.Checked = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btnView.Enabled = false;
        }
        private void BtnView_Click(object sender, EventArgs e)
        {
            getData();
            ProcessYear(bxVendor.Text);
            ProcessMonth(bxVendor.Text);
            if (bxType.Text == "Pie Chart")
            {
                piechart();
                chart1.Hide();
                chart3.Hide();
                chart2.Show();
                chart2.Series["Revenue"].IsValueShownAsLabel = true;
            }


            if (bxType.Text == "Line Chart")
            {
                linechart();
                chart1.Hide();
                chart2.Hide();
                chart3.Show();
                chart3.Series["Revenue"].IsValueShownAsLabel = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bxVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bxField.SelectedIndex > -1 && bxType.SelectedIndex > -1 && bxVendor.SelectedIndex > -1)
            {
                btnView.Enabled = true;
            }
            else
            {
                btnView.Enabled = false;
            }
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
