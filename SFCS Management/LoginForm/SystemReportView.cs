using SFCSManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SystemReportView : Form
    {
        private List<Vendor> VendorsList;
        int Month;
        int Year;

        public SystemReportView(int month, int year)
        {
            this.Month = month;
            this.Year = year;
            InitializeComponent();
            cbMonth.Text = (month == 0) ? "All" : month.ToString();
            cbYear.Text = (year == 0) ? "All" : year.ToString();
            VendorsList = createListOfVendors();
            updateVendorsList(ref VendorsList);
            viewSystemReport();
        }

        public class Vendor
        {
            public int ID { get; set; }
            public String Name { get; set; }
            public int NumOfOrders { get; set; }
            public Int64 Profits { get; set; }

            public Vendor(int id, String name)
            {
                ID = id;
                Name = name;
                NumOfOrders = 0;
                Profits = 0;
            }
        }

        private List<Vendor> createListOfVendors()
        {
            List<Vendor> vendorList = new List<Vendor>();

            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from VendorDB", sql_cnt);
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            foreach(DataRow row in dt.Rows)
            {
                Vendor vendor = new Vendor((int)row["ID"], row["Name"].ToString());
                vendorList.Add(vendor);
            }

            return vendorList;
        }

        private void updateVendorsList(ref List<Vendor> vendorList)
        {
            SqlConnection sql_cnt = new SqlConnection(ConnectString.connectString);
            sql_cnt.Open();
            SqlCommand scmd = new SqlCommand("select * from OrderDB where Done = @Done", sql_cnt);
            scmd.Parameters.AddWithValue("@Done", true.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(scmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            scmd.ExecuteNonQuery();
            sql_cnt.Close();

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < vendorList.Count; ++i)
                {
                    if (vendorList[i].ID == (int)row["VendorID"])
                    {
                        DateTime orderDate = (DateTime)row["Datetime"];
                        if (((this.Month == 0) || (this.Month == orderDate.Month)) && ((this.Year == 0) || (this.Year == orderDate.Year)))
                        {
                            Vendor vendor = vendorList[i];
                            vendor.NumOfOrders++;
                            vendor.Profits += (Int64)row["Total"];
                        }
                    }
                }
            }
        }

        void viewSystemReport()
        {
            Vendor allVendors = new Vendor(0, "");

            foreach (Vendor vendor in VendorsList)
            {
                allVendors.Profits += vendor.Profits;
                allVendors.NumOfOrders += vendor.NumOfOrders;
            }

            for (int i = 0; i < VendorsList.Count; ++i)
            {
                Panel pnlVendorView  = new Panel();
                Panel pnlLine = new Panel();
                Label lbVendorPercent = new Label();
                Label lbVendorProfits = new Label();
                Label lbVendorOrders = new Label();
                Label lbVendorName = new Label();

                this.pnlReport.Controls.Add(pnlVendorView);

                pnlVendorView.Controls.Add(pnlLine);
                pnlVendorView.Controls.Add(lbVendorPercent);
                pnlVendorView.Controls.Add(lbVendorProfits);
                pnlVendorView.Controls.Add(lbVendorOrders);
                pnlVendorView.Controls.Add(lbVendorName);
                pnlVendorView.Location = new System.Drawing.Point(12, 206 + 51 * i);
                pnlVendorView.Size = new System.Drawing.Size(650, 51);

                pnlLine.BackColor = System.Drawing.SystemColors.GrayText;
                pnlLine.Location = new System.Drawing.Point(14, 50);
                pnlLine.Size = new System.Drawing.Size(622, 1);

                lbVendorPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbVendorPercent.Location = new System.Drawing.Point(538, 28);
                lbVendorPercent.Size = new System.Drawing.Size(96, 20);
                lbVendorPercent.Text = (VendorsList[i].Profits * 1.0f / allVendors.Profits).ToString("P2", new NumberFormatInfo { PercentPositivePattern = 1, PercentNegativePattern = 1 });
                lbVendorPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                lbVendorProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbVendorProfits.Location = new System.Drawing.Point(381, 28);
                lbVendorProfits.Size = new System.Drawing.Size(134, 20);
                lbVendorProfits.Text = VendorsList[i].Profits.ToString();
                lbVendorProfits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                lbVendorOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbVendorOrders.Location = new System.Drawing.Point(257, 28);
                lbVendorOrders.Size = new System.Drawing.Size(103, 20);
                lbVendorOrders.Text = VendorsList[i].NumOfOrders.ToString();
                lbVendorOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                lbVendorName.AutoSize = true;
                lbVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbVendorName.Location = new System.Drawing.Point(10, 28);
                lbVendorName.Size = new System.Drawing.Size(157, 20);
                lbVendorName.Text = VendorsList[i].Name.ToString();
            }

            lbTotalOrders.Text = allVendors.NumOfOrders.ToString();
            lbTotalProfits.Text = allVendors.Profits.ToString();
            pnlGrandTotals.Location = new Point(pnlGrandTotals.Location.X, 206 + 51 * VendorsList.Count);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int month = (cbMonth.Text == "All") ? 0 : Int32.Parse(cbMonth.Text);
            int year = (cbYear.Text == "All") ? 0 : Int32.Parse(cbYear.Text);
            SystemReportView reportView = new SystemReportView(month, year);
            this.Hide();
            reportView.ShowDialog();
            this.Close();
        }
    }
}
