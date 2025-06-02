using BookHaven.Enums;

namespace BookHaven.Components.Layout
{
    partial class DashboardLayout
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
            lbl_minimizeBtn = new Label();
            lbl_closeBtn = new Label();
            pnl_sideNavigation = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label12 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lbl_logoutIcon = new Label();
            btn_logout = new Button();
            lbl_appName = new Label();
            lbl_bookIcon = new Label();
            pnlTabContainer = new Panel();
            pnl_sideNavigation.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_minimizeBtn
            // 
            lbl_minimizeBtn.AutoSize = true;
            lbl_minimizeBtn.Cursor = Cursors.Hand;
            lbl_minimizeBtn.Font = new Font("Font Awesome 6 Sharp Regular", 12F);
            lbl_minimizeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_minimizeBtn.Location = new Point(1259, 13);
            lbl_minimizeBtn.Name = "lbl_minimizeBtn";
            lbl_minimizeBtn.Size = new Size(30, 21);
            lbl_minimizeBtn.TabIndex = 3;
            lbl_minimizeBtn.Text = "";
            lbl_minimizeBtn.Click += lbl_minimizeBtn_Click;
            // 
            // lbl_closeBtn
            // 
            lbl_closeBtn.AutoSize = true;
            lbl_closeBtn.Cursor = Cursors.Hand;
            lbl_closeBtn.Font = new Font("Font Awesome 6 Pro Regular", 15F);
            lbl_closeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_closeBtn.Location = new Point(1295, 9);
            lbl_closeBtn.Name = "lbl_closeBtn";
            lbl_closeBtn.Size = new Size(37, 25);
            lbl_closeBtn.TabIndex = 2;
            lbl_closeBtn.Text = "";
            lbl_closeBtn.Click += lbl_closeBtn_Click;
            // 
            // pnl_sideNavigation
            // 
            pnl_sideNavigation.BackColor = Color.White;
            pnl_sideNavigation.Controls.Add(panel5);
            pnl_sideNavigation.Controls.Add(panel6);
            pnl_sideNavigation.Controls.Add(panel4);
            pnl_sideNavigation.Controls.Add(panel3);
            pnl_sideNavigation.Controls.Add(panel2);
            pnl_sideNavigation.Controls.Add(panel1);
            pnl_sideNavigation.Controls.Add(lbl_logoutIcon);
            pnl_sideNavigation.Controls.Add(btn_logout);
            pnl_sideNavigation.Controls.Add(lbl_appName);
            pnl_sideNavigation.Controls.Add(lbl_bookIcon);
            pnl_sideNavigation.Location = new Point(0, 0);
            pnl_sideNavigation.Name = "pnl_sideNavigation";
            pnl_sideNavigation.Size = new Size(287, 756);
            pnl_sideNavigation.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(245, 245, 244);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(12, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 49);
            panel5.TabIndex = 10;
            panel5.Click += panel5_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label9.Location = new Point(69, 14);
            label9.Name = "label9";
            label9.Size = new Size(77, 23);
            label9.TabIndex = 1;
            label9.Text = "Suppliers";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label10.Location = new Point(13, 12);
            label10.Name = "label10";
            label10.Size = new Size(40, 24);
            label10.TabIndex = 0;
            label10.Text = "";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(245, 245, 244);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(12, 316);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 49);
            panel6.TabIndex = 9;
            panel6.Click += panel6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label11.Location = new Point(69, 14);
            label11.Name = "label11";
            label11.Size = new Size(54, 23);
            label11.TabIndex = 1;
            label11.Text = "Books";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label12.Location = new Point(13, 12);
            label12.Name = "label12";
            label12.Size = new Size(40, 24);
            label12.TabIndex = 0;
            label12.Text = "";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(245, 245, 244);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(12, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 49);
            panel4.TabIndex = 8;
            panel4.Click += panel4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label7.Location = new Point(69, 14);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 1;
            label7.Text = "Inventory";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label8.Location = new Point(13, 12);
            label8.Name = "label8";
            label8.Size = new Size(40, 24);
            label8.TabIndex = 0;
            label8.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(245, 245, 244);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 49);
            panel3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label5.Location = new Point(69, 14);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 1;
            label5.Text = "Customers";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label6.Location = new Point(13, 12);
            label6.Name = "label6";
            label6.Size = new Size(31, 24);
            label6.TabIndex = 0;
            label6.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 245, 244);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 49);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label3.Location = new Point(69, 14);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 1;
            label3.Text = "Orders";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label4.Location = new Point(13, 12);
            label4.Name = "label4";
            label4.Size = new Size(31, 24);
            label4.TabIndex = 0;
            label4.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 245, 244);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 49);
            panel1.TabIndex = 6;
            panel1.Click += panel1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label2.Location = new Point(69, 14);
            label2.Name = "label2";
            label2.Size = new Size(41, 23);
            label2.TabIndex = 1;
            label2.Text = "Cart";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Font Awesome 6 Pro Regular", 14F);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 24);
            label1.TabIndex = 0;
            label1.Text = "";
            // 
            // lbl_logoutIcon
            // 
            lbl_logoutIcon.AutoSize = true;
            lbl_logoutIcon.BackColor = Color.Transparent;
            lbl_logoutIcon.Font = new Font("Font Awesome 6 Pro Regular", 12F);
            lbl_logoutIcon.Location = new Point(49, 701);
            lbl_logoutIcon.Name = "lbl_logoutIcon";
            lbl_logoutIcon.Size = new Size(30, 21);
            lbl_logoutIcon.TabIndex = 5;
            lbl_logoutIcon.Text = "";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Quicksand", 10F, FontStyle.Bold);
            btn_logout.Location = new Point(25, 690);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(240, 41);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Logout        ";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += button1_Click;
            // 
            // lbl_appName
            // 
            lbl_appName.AutoSize = true;
            lbl_appName.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_appName.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_appName.Location = new Point(81, 15);
            lbl_appName.Name = "lbl_appName";
            lbl_appName.Size = new Size(123, 30);
            lbl_appName.TabIndex = 3;
            lbl_appName.Text = "BookHaven";
            // 
            // lbl_bookIcon
            // 
            lbl_bookIcon.AutoSize = true;
            lbl_bookIcon.Font = new Font("Font Awesome 6 Pro Thin", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bookIcon.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_bookIcon.Location = new Point(25, 18);
            lbl_bookIcon.Name = "lbl_bookIcon";
            lbl_bookIcon.Size = new Size(52, 30);
            lbl_bookIcon.TabIndex = 2;
            lbl_bookIcon.Text = "";
            // 
            // pnlTabContainer
            // 
            pnlTabContainer.Location = new Point(287, 37);
            pnlTabContainer.Name = "pnlTabContainer";
            pnlTabContainer.Size = new Size(1057, 719);
            pnlTabContainer.TabIndex = 5;
            // 
            // DashboardLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 244);
            ClientSize = new Size(1344, 756);
            Controls.Add(pnlTabContainer);
            Controls.Add(pnl_sideNavigation);
            Controls.Add(lbl_minimizeBtn);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "DashboardLayout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardLayout";
            pnl_sideNavigation.ResumeLayout(false);
            pnl_sideNavigation.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //private void InitializeComponentWithProp(UserRole userType)
        //{
        //    // Initialize the form with properties based on the user type
        //    this.userType = userType;
        //    // Additional initialization code can go here
        //}

        #endregion

        private Label lbl_minimizeBtn;
        private Label lbl_closeBtn;
        private Panel pnl_sideNavigation;
        private Label lbl_appName;
        private Label lbl_bookIcon;
        private Button btn_logout;
        private Label lbl_logoutIcon;
        private Panel pnlTabContainer;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private Panel panel6;
        private Label label11;
        private Label label12;
        private Panel panel5;
        private Label label9;
        private Label label10;
    }
}