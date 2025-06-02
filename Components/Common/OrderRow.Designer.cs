namespace BookHaven.Components.Common
{
    partial class OrderRow
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
            lblOrderId = new Label();
            lblCustomer = new Label();
            lblDate = new Label();
            lblTotal = new Label();
            button2 = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(12, 13);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(22, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "id";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(183, 13);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(70, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "customer";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(416, 13);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(39, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "date";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(598, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "total";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 23, 41);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Font Awesome 6 Free Solid", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(985, 5);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 1;
            button2.Text = "";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(748, 13);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "status";
            // 
            // OrderRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(lblStatus);
            Controls.Add(lblTotal);
            Controls.Add(lblDate);
            Controls.Add(lblCustomer);
            Controls.Add(lblOrderId);
            Name = "OrderRow";
            Size = new Size(1025, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderId;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblTotal;
        private Button button2;
        private Label lblStatus;
    }
}
