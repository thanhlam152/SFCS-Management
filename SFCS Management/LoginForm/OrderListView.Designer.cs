namespace SFCSManagement
{
    partial class OrderListView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderListView));
            this.pnlSystem = new System.Windows.Forms.Panel();
            this.pbLogoCSE = new System.Windows.Forms.PictureBox();
            this.lbSystem = new System.Windows.Forms.Label();
            this.pbLogoHCMUT = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.pnlGap = new System.Windows.Forms.Panel();
            this.pbOrderIcon = new System.Windows.Forms.PictureBox();
            this.lbOrderList = new System.Windows.Forms.Label();
            this.lbVendorName = new System.Windows.Forms.Label();
            this.pnlSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.pnlOrderList.SuspendLayout();
            this.pnlGap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSystem
            // 
            this.pnlSystem.BackColor = System.Drawing.Color.LightGray;
            this.pnlSystem.Controls.Add(this.pbLogoCSE);
            this.pnlSystem.Controls.Add(this.lbSystem);
            this.pnlSystem.Controls.Add(this.pbLogoHCMUT);
            this.pnlSystem.Location = new System.Drawing.Point(0, -1);
            this.pnlSystem.Name = "pnlSystem";
            this.pnlSystem.Size = new System.Drawing.Size(1084, 89);
            this.pnlSystem.TabIndex = 0;
            // 
            // pbLogoCSE
            // 
            this.pbLogoCSE.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoCSE.Image")));
            this.pbLogoCSE.Location = new System.Drawing.Point(991, 11);
            this.pbLogoCSE.Name = "pbLogoCSE";
            this.pbLogoCSE.Size = new System.Drawing.Size(70, 70);
            this.pbLogoCSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoCSE.TabIndex = 12;
            this.pbLogoCSE.TabStop = false;
            // 
            // lbSystem
            // 
            this.lbSystem.AutoSize = true;
            this.lbSystem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.lbSystem.Location = new System.Drawing.Point(116, 27);
            this.lbSystem.Name = "lbSystem";
            this.lbSystem.Size = new System.Drawing.Size(310, 30);
            this.lbSystem.TabIndex = 11;
            this.lbSystem.Text = "Smart Food Court System";
            // 
            // pbLogoHCMUT
            // 
            this.pbLogoHCMUT.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoHCMUT.Image")));
            this.pbLogoHCMUT.Location = new System.Drawing.Point(29, 11);
            this.pbLogoHCMUT.Name = "pbLogoHCMUT";
            this.pbLogoHCMUT.Size = new System.Drawing.Size(70, 70);
            this.pbLogoHCMUT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoHCMUT.TabIndex = 10;
            this.pbLogoHCMUT.TabStop = false;
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlOption.Controls.Add(this.btnMenu);
            this.pnlOption.Controls.Add(this.btnOrder);
            this.pnlOption.Location = new System.Drawing.Point(0, 87);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(230, 548);
            this.pnlOption.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(6, 75);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(221, 55);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Thực đơn";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(6, 14);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(221, 55);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Đơn hàng";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlBorder.Location = new System.Drawing.Point(213, 87);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(871, 10);
            this.pnlBorder.TabIndex = 2;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.AutoScroll = true;
            this.pnlOrderList.Controls.Add(this.pnlGap);
            this.pnlOrderList.Controls.Add(this.lbOrderList);
            this.pnlOrderList.Controls.Add(this.lbVendorName);
            this.pnlOrderList.Location = new System.Drawing.Point(234, 101);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(850, 534);
            this.pnlOrderList.TabIndex = 3;
            // 
            // pnlGap
            // 
            this.pnlGap.Controls.Add(this.pbOrderIcon);
            this.pnlGap.Location = new System.Drawing.Point(16, 345);
            this.pnlGap.Name = "pnlGap";
            this.pnlGap.Size = new System.Drawing.Size(811, 134);
            this.pnlGap.TabIndex = 2;
            // 
            // pbOrderIcon
            // 
            this.pbOrderIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbOrderIcon.Image")));
            this.pbOrderIcon.Location = new System.Drawing.Point(3, 12);
            this.pbOrderIcon.Name = "pbOrderIcon";
            this.pbOrderIcon.Size = new System.Drawing.Size(121, 113);
            this.pbOrderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrderIcon.TabIndex = 0;
            this.pbOrderIcon.TabStop = false;
            this.pbOrderIcon.Visible = false;
            // 
            // lbOrderList
            // 
            this.lbOrderList.AutoSize = true;
            this.lbOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderList.Location = new System.Drawing.Point(170, 101);
            this.lbOrderList.Name = "lbOrderList";
            this.lbOrderList.Size = new System.Drawing.Size(523, 29);
            this.lbOrderList.TabIndex = 1;
            this.lbOrderList.Text = "DANH SÁCH ĐƠN HÀNG ĐANG THỰC HIỆN";
            // 
            // lbVendorName
            // 
            this.lbVendorName.AutoSize = true;
            this.lbVendorName.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.lbVendorName.Location = new System.Drawing.Point(33, 17);
            this.lbVendorName.Name = "lbVendorName";
            this.lbVendorName.Size = new System.Drawing.Size(215, 38);
            this.lbVendorName.TabIndex = 0;
            this.lbVendorName.Text = "VENDOR NAME";
            // 
            // OrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 635);
            this.Controls.Add(this.pnlOrderList);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSystem.ResumeLayout(false);
            this.pnlSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlOrderList.ResumeLayout(false);
            this.pnlOrderList.PerformLayout();
            this.pnlGap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOrderIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystem;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lbSystem;
        private System.Windows.Forms.PictureBox pbLogoHCMUT;
        private System.Windows.Forms.PictureBox pbLogoCSE;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlOrderList;
        private System.Windows.Forms.Label lbOrderList;
        private System.Windows.Forms.Label lbVendorName;
        private System.Windows.Forms.Panel pnlGap;
        private System.Windows.Forms.PictureBox pbOrderIcon;
    }
}