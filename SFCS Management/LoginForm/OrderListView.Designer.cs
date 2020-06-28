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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogoCSE = new System.Windows.Forms.PictureBox();
            this.lbSystem = new System.Windows.Forms.Label();
            this.pbLogoHCMUT = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pbLogoCSE);
            this.panel1.Controls.Add(this.lbSystem);
            this.panel1.Controls.Add(this.pbLogoHCMUT);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 89);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 548);
            this.panel2.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel3.Location = new System.Drawing.Point(213, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 10);
            this.panel3.TabIndex = 2;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.AutoScroll = true;
            this.pnlOrderList.Location = new System.Drawing.Point(234, 101);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(850, 534);
            this.pnlOrderList.TabIndex = 3;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 635);
            this.Controls.Add(this.pnlOrderList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSystem;
        private System.Windows.Forms.PictureBox pbLogoHCMUT;
        private System.Windows.Forms.PictureBox pbLogoCSE;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlOrderList;
    }
}