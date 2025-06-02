namespace BookHaven.Screens.Forms
{
    partial class UpdateOrderStatusScreen
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
            btnSubmit = new Button();
            cmbBxStatus = new ComboBox();
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
            lblFormTitle.Size = new Size(256, 35);
            lblFormTitle.TabIndex = 5;
            lblFormTitle.Text = "Update Order Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 6;
            label2.Text = "Status:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 23, 41);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Quicksand", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 162);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(360, 56);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Update Status";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbBxStatus
            // 
            cmbBxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxStatus.FormattingEnabled = true;
            cmbBxStatus.Items.AddRange(new object[] { "Pending", "Processing", "Sent", "Fulfilled", "Canceled" });
            cmbBxStatus.Location = new Point(182, 97);
            cmbBxStatus.Name = "cmbBxStatus";
            cmbBxStatus.Size = new Size(201, 28);
            cmbBxStatus.TabIndex = 10;
            // 
            // UpdateOrderStatusScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 245);
            Controls.Add(cmbBxStatus);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(lblFormTitle);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateOrderStatusScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_closeBtn;
        private Label lblFormTitle;
        private Label label2;
        private Button btnSubmit;
        private ComboBox cmbBxStatus;
    }
}