namespace BookHaven.Screens.Dashboard
{
    partial class OrdersTab
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
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlItemsContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 16F, FontStyle.Bold);
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 229, 228);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 49);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(12, 10, 9);
            label8.Location = new Point(947, 13);
            label8.Name = "label8";
            label8.Size = new Size(63, 23);
            label8.TabIndex = 0;
            label8.Text = "Actions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(12, 10, 9);
            label7.Location = new Point(748, 13);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 0;
            label7.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(12, 10, 9);
            label5.Location = new Point(598, 13);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 0;
            label5.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(12, 10, 9);
            label4.Location = new Point(416, 13);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 0;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 10, 9);
            label3.Location = new Point(183, 13);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 0;
            label3.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 10, 9);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 0;
            label2.Text = "Order ID";
            // 
            // pnlItemsContainer
            // 
            pnlItemsContainer.AutoScroll = true;
            pnlItemsContainer.BackColor = Color.White;
            pnlItemsContainer.Location = new Point(16, 135);
            pnlItemsContainer.Name = "pnlItemsContainer";
            pnlItemsContainer.Size = new Size(1025, 569);
            pnlItemsContainer.TabIndex = 3;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlItemsContainer);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "OrdersTab";
            Size = new Size(1057, 719);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label5;
        private Panel pnlItemsContainer;
    }
}
