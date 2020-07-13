namespace SFCSManagement
{
    partial class VendorReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bxField = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bxVendor = new System.Windows.Forms.ComboBox();
            this.lastButton = new System.Windows.Forms.RadioButton();
            this.thisButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastYearButton = new System.Windows.Forms.RadioButton();
            this.thisYearButton = new System.Windows.Forms.RadioButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // bxType
            // 
            this.bxType.FormattingEnabled = true;
            this.bxType.Items.AddRange(new object[] {
            "Pie Chart",
            "Line Chart"});
            this.bxType.Location = new System.Drawing.Point(518, 34);
            this.bxType.Name = "bxType";
            this.bxType.Size = new System.Drawing.Size(121, 24);
            this.bxType.TabIndex = 0;
            this.bxType.SelectedIndexChanged += new System.EventHandler(this.bxType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(381, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(658, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bxField
            // 
            this.bxField.FormattingEnabled = true;
            this.bxField.Items.AddRange(new object[] {
            "Month",
            "Year"});
            this.bxField.Location = new System.Drawing.Point(711, 33);
            this.bxField.Name = "bxField";
            this.bxField.Size = new System.Drawing.Size(121, 24);
            this.bxField.TabIndex = 3;
            this.bxField.SelectedIndexChanged += new System.EventHandler(this.BxField_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 62);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(847, 350);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 63);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.EmptyPointStyle.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(847, 350);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Teal;
            this.btnView.Location = new System.Drawing.Point(319, 430);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(161, 53);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vendor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bxVendor
            // 
            this.bxVendor.FormattingEnabled = true;
            this.bxVendor.Location = new System.Drawing.Point(81, 34);
            this.bxVendor.Name = "bxVendor";
            this.bxVendor.Size = new System.Drawing.Size(151, 24);
            this.bxVendor.TabIndex = 8;
            this.bxVendor.SelectedIndexChanged += new System.EventHandler(this.bxVendor_SelectedIndexChanged);
            // 
            // lastButton
            // 
            this.lastButton.AutoSize = true;
            this.lastButton.Location = new System.Drawing.Point(6, 30);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(99, 21);
            this.lastButton.TabIndex = 9;
            this.lastButton.Text = "Last Month";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // thisButton
            // 
            this.thisButton.AutoSize = true;
            this.thisButton.Location = new System.Drawing.Point(122, 30);
            this.thisButton.Name = "thisButton";
            this.thisButton.Size = new System.Drawing.Size(99, 21);
            this.thisButton.TabIndex = 10;
            this.thisButton.Text = "This Month";
            this.thisButton.UseVisualStyleBackColor = true;
            this.thisButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastButton);
            this.groupBox1.Controls.Add(this.thisButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastYearButton);
            this.groupBox2.Controls.Add(this.thisYearButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 67);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lastYearButton
            // 
            this.lastYearButton.AutoSize = true;
            this.lastYearButton.Location = new System.Drawing.Point(6, 30);
            this.lastYearButton.Name = "lastYearButton";
            this.lastYearButton.Size = new System.Drawing.Size(90, 21);
            this.lastYearButton.TabIndex = 9;
            this.lastYearButton.Text = "Last Year";
            this.lastYearButton.UseVisualStyleBackColor = true;
            // 
            // thisYearButton
            // 
            this.thisYearButton.AutoSize = true;
            this.thisYearButton.Location = new System.Drawing.Point(122, 30);
            this.thisYearButton.Name = "thisYearButton";
            this.thisYearButton.Size = new System.Drawing.Size(90, 21);
            this.thisYearButton.TabIndex = 10;
            this.thisYearButton.Text = "This Year";
            this.thisYearButton.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 63);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Revenue";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(847, 348);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart3";
            this.chart3.Visible = false;
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // View_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bxVendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.bxField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bxType);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "View_Report";
            this.Size = new System.Drawing.Size(850, 534);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bxField;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bxVendor;
        private System.Windows.Forms.RadioButton lastButton;
        private System.Windows.Forms.RadioButton thisButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton lastYearButton;
        private System.Windows.Forms.RadioButton thisYearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}
