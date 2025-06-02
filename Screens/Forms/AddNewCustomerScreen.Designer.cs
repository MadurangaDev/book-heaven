namespace BookHaven.Screens.Forms
{
    partial class AddNewCustomerScreen
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
            lbl_closeBtn = new Label();
            lblFormTitle = new Label();
            label2 = new Label();
            txtBxFirstName = new TextBox();
            label3 = new Label();
            txtBxLastName = new TextBox();
            label4 = new Label();
            txtBxPhone = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lbl_closeBtn
            // 
            lbl_closeBtn.AutoSize = true;
            lbl_closeBtn.Cursor = Cursors.Hand;
            lbl_closeBtn.Font = new Font("Font Awesome 6 Pro Regular", 15F);
            lbl_closeBtn.ForeColor = Color.FromArgb(120, 123, 108);
            lbl_closeBtn.Location = new Point(354, 13);
            lbl_closeBtn.Name = "lbl_closeBtn";
            lbl_closeBtn.Size = new Size(37, 25);
            lbl_closeBtn.TabIndex = 4;
            lbl_closeBtn.Text = "";
            lbl_closeBtn.Click += lbl_closeBtn_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Quicksand", 14F, FontStyle.Bold);
            lblFormTitle.Location = new Point(19, 9);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(184, 35);
            lblFormTitle.TabIndex = 5;
            lblFormTitle.Text = "New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // txtBxFirstName
            // 
            txtBxFirstName.Location = new Point(182, 85);
            txtBxFirstName.Name = "txtBxFirstName";
            txtBxFirstName.Size = new Size(201, 27);
            txtBxFirstName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 6;
            label3.Text = "Last Name:";
            // 
            // txtBxLastName
            // 
            txtBxLastName.Location = new Point(182, 126);
            txtBxLastName.Name = "txtBxLastName";
            txtBxLastName.Size = new Size(201, 27);
            txtBxLastName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label4.Location = new Point(25, 170);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 6;
            label4.Text = "Phone:";
            // 
            // txtBxPhone
            // 
            txtBxPhone.Location = new Point(182, 170);
            txtBxPhone.Name = "txtBxPhone";
            txtBxPhone.Size = new Size(201, 27);
            txtBxPhone.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 23, 41);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Quicksand", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 232);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(360, 56);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Add Customer";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddNewCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 316);
            Controls.Add(btnSubmit);
            Controls.Add(txtBxPhone);
            Controls.Add(txtBxLastName);
            Controls.Add(txtBxFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFormTitle);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewCustomerScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_closeBtn;
        private Label lblFormTitle;
        private Label label2;
        private TextBox txtBxFirstName;
        private Label label3;
        private TextBox txtBxLastName;
        private Label label4;
        private TextBox txtBxPhone;
        private Button btnSubmit;
    }
}