namespace BookHaven.Screens.Forms
{
    partial class AddNewSupplierScreen
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
            txtBxName = new TextBox();
            label3 = new Label();
            txtBxPhone = new TextBox();
            label4 = new Label();
            txtBxEmail = new TextBox();
            label5 = new Label();
            btnSubmit = new Button();
            txtBxAddress = new TextBox();
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
            lblFormTitle.Size = new Size(166, 35);
            lblFormTitle.TabIndex = 5;
            lblFormTitle.Text = "New Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 6;
            label2.Text = "Supplier Name:";
            // 
            // txtBxName
            // 
            txtBxName.Location = new Point(182, 85);
            txtBxName.Name = "txtBxName";
            txtBxName.Size = new Size(201, 27);
            txtBxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 6;
            label3.Text = "Phone:";
            // 
            // txtBxPhone
            // 
            txtBxPhone.Location = new Point(182, 126);
            txtBxPhone.Name = "txtBxPhone";
            txtBxPhone.Size = new Size(201, 27);
            txtBxPhone.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label4.Location = new Point(25, 170);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txtBxEmail
            // 
            txtBxEmail.Location = new Point(182, 170);
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(201, 27);
            txtBxEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label5.Location = new Point(25, 215);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 6;
            label5.Text = "Address:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 23, 41);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Quicksand", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 281);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(360, 56);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Add Supplier";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtBxAddress
            // 
            txtBxAddress.Location = new Point(182, 215);
            txtBxAddress.Name = "txtBxAddress";
            txtBxAddress.Size = new Size(201, 27);
            txtBxAddress.TabIndex = 3;
            // 
            // AddNewSupplierScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 364);
            Controls.Add(btnSubmit);
            Controls.Add(txtBxAddress);
            Controls.Add(txtBxEmail);
            Controls.Add(txtBxPhone);
            Controls.Add(txtBxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFormTitle);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewSupplierScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_closeBtn;
        private Label lblFormTitle;
        private Label label2;
        private TextBox txtBxName;
        private Label label3;
        private TextBox txtBxPhone;
        private Label label4;
        private TextBox txtBxEmail;
        private Label label5;
        private Button btnSubmit;
        private TextBox txtBxAddress;
    }
}