using BookHaven.Components.Common;

namespace BookHaven.Screens.Auth
{
    partial class LoginScreen
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
            lbl_bookIcon = new Label();
            pnl_loginRightPanel = new Panel();
            lbl_description = new Label();
            lbl_welcome = new Label();
            lbl_minimizeBtn = new Label();
            lbl_closeBtn = new Label();
            pnl_loginForm = new RoundedPanel();
            btn_Login = new Button();
            txtbx_Pass = new RichTextBox();
            lbl_Pass = new Label();
            txtbx_email = new RichTextBox();
            lbl_Email = new Label();
            pnl_loginType = new RoundedPanel();
            btn_cashierTypeBtn = new Button();
            btn_adminTypeBtn = new Button();
            lbl_appSlogan = new Label();
            lbl_appName = new Label();
            pnl_loginRightPanel.SuspendLayout();
            pnl_loginForm.SuspendLayout();
            pnl_loginType.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_bookIcon
            // 
            lbl_bookIcon.AutoSize = true;
            lbl_bookIcon.Font = new Font("Font Awesome 6 Pro Thin", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bookIcon.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_bookIcon.Location = new Point(178, 34);
            lbl_bookIcon.Name = "lbl_bookIcon";
            lbl_bookIcon.Size = new Size(52, 30);
            lbl_bookIcon.TabIndex = 0;
            lbl_bookIcon.Text = "";
            // 
            // pnl_loginRightPanel
            // 
            pnl_loginRightPanel.BackColor = Color.FromArgb(245, 245, 244);
            pnl_loginRightPanel.Controls.Add(lbl_description);
            pnl_loginRightPanel.Controls.Add(lbl_welcome);
            pnl_loginRightPanel.Controls.Add(lbl_minimizeBtn);
            pnl_loginRightPanel.Controls.Add(lbl_closeBtn);
            pnl_loginRightPanel.Location = new Point(672, 0);
            pnl_loginRightPanel.Name = "pnl_loginRightPanel";
            pnl_loginRightPanel.Size = new Size(672, 756);
            pnl_loginRightPanel.TabIndex = 1;
            // 
            // lbl_description
            // 
            lbl_description.Font = new Font("Quicksand", 9F);
            lbl_description.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_description.Location = new Point(112, 370);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(444, 73);
            lbl_description.TabIndex = 3;
            lbl_description.Text = "Streamline your bookstore operations with our comprehensive management system. Manage inventory, process sales, track orders, and more - all in one place.";
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Quicksand", 12F, FontStyle.Bold);
            lbl_welcome.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_welcome.Location = new Point(112, 320);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(243, 30);
            lbl_welcome.TabIndex = 2;
            lbl_welcome.Text = "Welcome to BookHaven";
            // 
            // lbl_minimizeBtn
            // 
            lbl_minimizeBtn.AutoSize = true;
            lbl_minimizeBtn.Cursor = Cursors.Hand;
            lbl_minimizeBtn.Font = new Font("Font Awesome 6 Sharp Regular", 12F);
            lbl_minimizeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_minimizeBtn.Location = new Point(586, 13);
            lbl_minimizeBtn.Name = "lbl_minimizeBtn";
            lbl_minimizeBtn.Size = new Size(30, 21);
            lbl_minimizeBtn.TabIndex = 1;
            lbl_minimizeBtn.Text = "";
            lbl_minimizeBtn.Click += lbl_minimizeBtn_Click;
            // 
            // lbl_closeBtn
            // 
            lbl_closeBtn.AutoSize = true;
            lbl_closeBtn.Cursor = Cursors.Hand;
            lbl_closeBtn.Font = new Font("Font Awesome 6 Pro Regular", 15F);
            lbl_closeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_closeBtn.Location = new Point(622, 9);
            lbl_closeBtn.Name = "lbl_closeBtn";
            lbl_closeBtn.Size = new Size(37, 25);
            lbl_closeBtn.TabIndex = 0;
            lbl_closeBtn.Text = "";
            lbl_closeBtn.Click += lbl_closeBtn_Click;
            // 
            // pnl_loginForm
            // 
            pnl_loginForm.BorderColor = Color.FromArgb(231, 229, 228);
            pnl_loginForm.BorderRadius = 8;
            pnl_loginForm.BorderThickness = 2;
            pnl_loginForm.Controls.Add(btn_Login);
            pnl_loginForm.Controls.Add(txtbx_Pass);
            pnl_loginForm.Controls.Add(lbl_Pass);
            pnl_loginForm.Controls.Add(txtbx_email);
            pnl_loginForm.Controls.Add(lbl_Email);
            pnl_loginForm.Controls.Add(pnl_loginType);
            pnl_loginForm.Controls.Add(lbl_appSlogan);
            pnl_loginForm.Controls.Add(lbl_appName);
            pnl_loginForm.Controls.Add(lbl_bookIcon);
            pnl_loginForm.Location = new Point(131, 139);
            pnl_loginForm.Name = "pnl_loginForm";
            pnl_loginForm.Size = new Size(403, 476);
            pnl_loginForm.TabIndex = 2;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(16, 23, 41);
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(29, 394);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(343, 48);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txtbx_Pass
            // 
            txtbx_Pass.BackColor = Color.WhiteSmoke;
            txtbx_Pass.BorderStyle = BorderStyle.FixedSingle;
            txtbx_Pass.Location = new Point(31, 328);
            txtbx_Pass.MaximumSize = new Size(341, 42);
            txtbx_Pass.MinimumSize = new Size(341, 42);
            txtbx_Pass.Name = "txtbx_Pass";
            txtbx_Pass.Size = new Size(341, 42);
            txtbx_Pass.TabIndex = 7;
            txtbx_Pass.Text = "";
            // 
            // lbl_Pass
            // 
            lbl_Pass.AutoSize = true;
            lbl_Pass.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            lbl_Pass.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_Pass.Location = new Point(28, 301);
            lbl_Pass.Name = "lbl_Pass";
            lbl_Pass.Size = new Size(79, 23);
            lbl_Pass.TabIndex = 6;
            lbl_Pass.Text = "Password";
            // 
            // txtbx_email
            // 
            txtbx_email.BackColor = Color.WhiteSmoke;
            txtbx_email.BorderStyle = BorderStyle.FixedSingle;
            txtbx_email.Font = new Font("Segoe UI", 9F);
            txtbx_email.Location = new Point(31, 236);
            txtbx_email.MaximumSize = new Size(341, 42);
            txtbx_email.MinimumSize = new Size(341, 42);
            txtbx_email.Name = "txtbx_email";
            txtbx_email.Size = new Size(341, 42);
            txtbx_email.TabIndex = 5;
            txtbx_email.Text = "";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            lbl_Email.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_Email.Location = new Point(28, 209);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(50, 23);
            lbl_Email.TabIndex = 4;
            lbl_Email.Text = "Email";
            // 
            // pnl_loginType
            // 
            pnl_loginType.BackColor = Color.FromArgb(245, 245, 244);
            pnl_loginType.BorderColor = Color.FromArgb(245, 245, 244);
            pnl_loginType.BorderRadius = 8;
            pnl_loginType.BorderThickness = 2;
            pnl_loginType.Controls.Add(btn_cashierTypeBtn);
            pnl_loginType.Controls.Add(btn_adminTypeBtn);
            pnl_loginType.Location = new Point(30, 154);
            pnl_loginType.Name = "pnl_loginType";
            pnl_loginType.Size = new Size(342, 41);
            pnl_loginType.TabIndex = 3;
            // 
            // btn_cashierTypeBtn
            // 
            btn_cashierTypeBtn.BackColor = Color.White;
            btn_cashierTypeBtn.FlatAppearance.BorderSize = 0;
            btn_cashierTypeBtn.FlatStyle = FlatStyle.Flat;
            btn_cashierTypeBtn.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            btn_cashierTypeBtn.ForeColor = Color.FromArgb(12, 10, 9);
            btn_cashierTypeBtn.Location = new Point(3, 3);
            btn_cashierTypeBtn.Name = "btn_cashierTypeBtn";
            btn_cashierTypeBtn.Size = new Size(168, 35);
            btn_cashierTypeBtn.TabIndex = 0;
            btn_cashierTypeBtn.Text = "Cashier";
            btn_cashierTypeBtn.UseVisualStyleBackColor = true;
            btn_cashierTypeBtn.Click += btn_cashierTypeBtn_Click;
            // 
            // btn_adminTypeBtn
            // 
            btn_adminTypeBtn.BackColor = Color.Transparent;
            btn_adminTypeBtn.FlatAppearance.BorderSize = 0;
            btn_adminTypeBtn.FlatStyle = FlatStyle.Flat;
            btn_adminTypeBtn.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            btn_adminTypeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            btn_adminTypeBtn.Location = new Point(171, 3);
            btn_adminTypeBtn.Name = "btn_adminTypeBtn";
            btn_adminTypeBtn.Size = new Size(168, 35);
            btn_adminTypeBtn.TabIndex = 0;
            btn_adminTypeBtn.Text = "Admin";
            btn_adminTypeBtn.UseVisualStyleBackColor = true;
            btn_adminTypeBtn.Click += btn_adminTypeBtn_Click;
            // 
            // lbl_appSlogan
            // 
            lbl_appSlogan.AutoSize = true;
            lbl_appSlogan.Font = new Font("Quicksand", 7F);
            lbl_appSlogan.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_appSlogan.Location = new Point(110, 112);
            lbl_appSlogan.Name = "lbl_appSlogan";
            lbl_appSlogan.Size = new Size(187, 18);
            lbl_appSlogan.TabIndex = 2;
            lbl_appSlogan.Text = "Bookstore Management System";
            // 
            // lbl_appName
            // 
            lbl_appName.AutoSize = true;
            lbl_appName.Font = new Font("Quicksand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_appName.ForeColor = Color.FromArgb(12, 10, 9);
            lbl_appName.Location = new Point(142, 77);
            lbl_appName.Name = "lbl_appName";
            lbl_appName.Size = new Size(123, 30);
            lbl_appName.TabIndex = 1;
            lbl_appName.Text = "BookHaven";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1344, 756);
            Controls.Add(pnl_loginForm);
            Controls.Add(pnl_loginRightPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1344, 756);
            MinimumSize = new Size(1344, 756);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            pnl_loginRightPanel.ResumeLayout(false);
            pnl_loginRightPanel.PerformLayout();
            pnl_loginForm.ResumeLayout(false);
            pnl_loginForm.PerformLayout();
            pnl_loginType.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_bookIcon;
        private Panel pnl_loginRightPanel;
        private RoundedPanel pnl_loginForm;
        private Label lbl_appName;
        private Label lbl_appSlogan;
        private Label lbl_closeBtn;
        private Label lbl_minimizeBtn;
        private Label lbl_description;
        private Label lbl_welcome;
        private RoundedPanel pnl_loginType;
        private Button btn_cashierTypeBtn;
        private Button btn_adminTypeBtn;
        private Label lbl_Email;
        private RichTextBox txtbx_email;
        private RichTextBox txtbx_Pass;
        private Label lbl_Pass;
        private Button btn_Login;
    }
}