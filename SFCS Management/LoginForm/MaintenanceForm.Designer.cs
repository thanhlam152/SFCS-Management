namespace SFCSManagement
{
    partial class MaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.pnlSystem = new System.Windows.Forms.Panel();
            this.pbLogoCSE = new System.Windows.Forms.PictureBox();
            this.lbSystemName = new System.Windows.Forms.Label();
            this.pbLogoHCMUT = new System.Windows.Forms.PictureBox();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.lbNotification = new System.Windows.Forms.Label();
            this.pnlSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSystem
            // 
            this.pnlSystem.BackColor = System.Drawing.Color.LightGray;
            this.pnlSystem.Controls.Add(this.pbLogoCSE);
            this.pnlSystem.Controls.Add(this.lbSystemName);
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
            // lbSystemName
            // 
            this.lbSystemName.AutoSize = true;
            this.lbSystemName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.lbSystemName.Location = new System.Drawing.Point(116, 27);
            this.lbSystemName.Name = "lbSystemName";
            this.lbSystemName.Size = new System.Drawing.Size(310, 30);
            this.lbSystemName.TabIndex = 11;
            this.lbSystemName.Text = "Smart Food Court System";
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
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlBorder.Location = new System.Drawing.Point(213, 87);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(871, 10);
            this.pnlBorder.TabIndex = 2;
            // 
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlOption.Controls.Add(this.btnMaintain);
            this.pnlOption.Location = new System.Drawing.Point(0, 87);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(230, 548);
            this.pnlOption.TabIndex = 3;
            // 
            // btnMaintain
            // 
            this.btnMaintain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
            this.btnMaintain.FlatAppearance.BorderSize = 0;
            this.btnMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintain.ForeColor = System.Drawing.Color.White;
            this.btnMaintain.Location = new System.Drawing.Point(6, 14);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(221, 55);
            this.btnMaintain.TabIndex = 5;
            this.btnMaintain.Text = "Bảo trì hệ thống";
            this.btnMaintain.UseVisualStyleBackColor = false;
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnDisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(421, 321);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(126, 54);
            this.btnDisable.TabIndex = 5;
            this.btnDisable.Text = "Disable";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnEnable.Enabled = false;
            this.btnEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(749, 321);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(126, 54);
            this.btnEnable.TabIndex = 6;
            this.btnEnable.Text = "Enable";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // lbNotification
            // 
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.Location = new System.Drawing.Point(282, 120);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(754, 138);
            this.lbNotification.TabIndex = 7;
            this.lbNotification.Text = "Notification";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 635);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.pnlSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSystem.ResumeLayout(false);
            this.pnlSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystem;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lbSystemName;
        private System.Windows.Forms.PictureBox pbLogoHCMUT;
        private System.Windows.Forms.PictureBox pbLogoCSE;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Label lbNotification;
    }
}