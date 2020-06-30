namespace SFCSManagement
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSystem = new System.Windows.Forms.Panel();
            this.pbLogoCSE = new System.Windows.Forms.PictureBox();
            this.lbSystemName = new System.Windows.Forms.Label();
            this.pbLogoHCMUT = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.cbAvailable = new System.Windows.Forms.CheckBox();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.pnlSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.AutoScroll = true;
            this.pnlEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlEdit.Controls.Add(this.cbAvailable);
            this.pnlEdit.Controls.Add(this.btnBack);
            this.pnlEdit.Controls.Add(this.btnBrowse);
            this.pnlEdit.Controls.Add(this.pbItemImage);
            this.pnlEdit.Controls.Add(this.txtPrice);
            this.pnlEdit.Controls.Add(this.txtDescription);
            this.pnlEdit.Controls.Add(this.txtName);
            this.pnlEdit.Controls.Add(this.lbPrice);
            this.pnlEdit.Controls.Add(this.lbDescription);
            this.pnlEdit.Controls.Add(this.lbName);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Location = new System.Drawing.Point(232, 101);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(851, 534);
            this.pnlEdit.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(24, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 36);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "   TRỞ LẠI";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(594, 333);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 35);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbItemImage
            // 
            this.pbItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.Location = new System.Drawing.Point(530, 91);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(225, 225);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 17;
            this.pbItemImage.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(182, 288);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(313, 30);
            this.txtPrice.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(182, 154);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(313, 116);
            this.txtDescription.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(182, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(313, 30);
            this.txtName.TabIndex = 13;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(79, 291);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(79, 25);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Đơn giá";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(64, 154);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(94, 25);
            this.lbDescription.TabIndex = 10;
            this.lbDescription.Text = "Thông tin";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(41, 91);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 25);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tên món ăn";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(389, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlSystem
            // 
            this.pnlSystem.BackColor = System.Drawing.Color.LightGray;
            this.pnlSystem.Controls.Add(this.pbLogoCSE);
            this.pnlSystem.Controls.Add(this.lbSystemName);
            this.pnlSystem.Controls.Add(this.pbLogoHCMUT);
            this.pnlSystem.Location = new System.Drawing.Point(-1, -1);
            this.pnlSystem.Name = "pnlSystem";
            this.pnlSystem.Size = new System.Drawing.Size(1084, 89);
            this.pnlSystem.TabIndex = 3;
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
            // pnlOption
            // 
            this.pnlOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlOption.Controls.Add(this.btnMenu);
            this.pnlOption.Controls.Add(this.btnOrder);
            this.pnlOption.Location = new System.Drawing.Point(-1, 87);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(230, 548);
            this.pnlOption.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(174)))));
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
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
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
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.pnlBorder.Location = new System.Drawing.Point(212, 87);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(871, 10);
            this.pnlBorder.TabIndex = 6;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Checked = true;
            this.cbAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAvailable.Location = new System.Drawing.Point(182, 354);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(97, 29);
            this.cbAvailable.TabIndex = 21;
            this.cbAvailable.Text = "Có sẵn";
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1083, 635);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlSystem);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlBorder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.pnlSystem.ResumeLayout(false);
            this.pnlSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoHCMUT)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSystem;
        private System.Windows.Forms.PictureBox pbLogoCSE;
        private System.Windows.Forms.Label lbSystemName;
        private System.Windows.Forms.PictureBox pbLogoHCMUT;
        private System.Windows.Forms.Panel pnlOption;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox cbAvailable;
    }
}