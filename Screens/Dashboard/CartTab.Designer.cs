namespace BookHaven.Screens.Dashboard
{
    partial class CartTab
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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlItemsContainer = new Panel();
            roundedPanel1 = new Components.Common.RoundedPanel();
            txtBxSearch = new TextBox();
            label1 = new Label();
            roundedPanel2 = new Components.Common.RoundedPanel();
            numBxFee = new NumericUpDown();
            txtBxAddress = new TextBox();
            cmbBxCustomer = new ComboBox();
            btnSubmit = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblTotal = new Label();
            label12 = new Label();
            label10 = new Label();
            pnlCartContainer = new Panel();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBxFee).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 229, 228);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 49);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(12, 10, 9);
            label5.Location = new Point(403, 13);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 0;
            label5.Text = "Action";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(12, 10, 9);
            label4.Location = new Point(307, 13);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 0;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(12, 10, 9);
            label3.Location = new Point(161, 13);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 0;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(12, 10, 9);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 0;
            label2.Text = "Title";
            // 
            // pnlItemsContainer
            // 
            pnlItemsContainer.AutoScroll = true;
            pnlItemsContainer.BackColor = Color.White;
            pnlItemsContainer.Location = new Point(16, 155);
            pnlItemsContainer.Name = "pnlItemsContainer";
            pnlItemsContainer.Size = new Size(471, 507);
            pnlItemsContainer.TabIndex = 3;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderThickness = 2;
            roundedPanel1.Controls.Add(txtBxSearch);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(pnlItemsContainer);
            roundedPanel1.Location = new Point(14, 16);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(505, 683);
            roundedPanel1.TabIndex = 4;
            // 
            // txtBxSearch
            // 
            txtBxSearch.Location = new Point(306, 25);
            txtBxSearch.Name = "txtBxSearch";
            txtBxSearch.PlaceholderText = "  Harry Potter";
            txtBxSearch.Size = new Size(181, 27);
            txtBxSearch.TabIndex = 5;
            txtBxSearch.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 14F, FontStyle.Bold);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 4;
            label1.Text = "Available Books";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderThickness = 2;
            roundedPanel2.Controls.Add(numBxFee);
            roundedPanel2.Controls.Add(txtBxAddress);
            roundedPanel2.Controls.Add(cmbBxCustomer);
            roundedPanel2.Controls.Add(btnSubmit);
            roundedPanel2.Controls.Add(label15);
            roundedPanel2.Controls.Add(label14);
            roundedPanel2.Controls.Add(label13);
            roundedPanel2.Controls.Add(panel2);
            roundedPanel2.Controls.Add(lblTotal);
            roundedPanel2.Controls.Add(label12);
            roundedPanel2.Controls.Add(label10);
            roundedPanel2.Controls.Add(pnlCartContainer);
            roundedPanel2.Location = new Point(538, 16);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(498, 683);
            roundedPanel2.TabIndex = 6;
            // 
            // numBxFee
            // 
            numBxFee.Location = new Point(210, 550);
            numBxFee.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numBxFee.Name = "numBxFee";
            numBxFee.Size = new Size(270, 27);
            numBxFee.TabIndex = 12;
            // 
            // txtBxAddress
            // 
            txtBxAddress.Location = new Point(210, 512);
            txtBxAddress.Name = "txtBxAddress";
            txtBxAddress.Size = new Size(270, 27);
            txtBxAddress.TabIndex = 11;
            // 
            // cmbBxCustomer
            // 
            cmbBxCustomer.DisplayMember = "Text";
            cmbBxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxCustomer.FormattingEnabled = true;
            cmbBxCustomer.Location = new Point(210, 475);
            cmbBxCustomer.Name = "cmbBxCustomer";
            cmbBxCustomer.Size = new Size(270, 28);
            cmbBxCustomer.TabIndex = 8;
            cmbBxCustomer.ValueMember = "Value";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 23, 41);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Quicksand", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(16, 606);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(464, 56);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Place Order";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Quicksand", 9F);
            label15.Location = new Point(16, 550);
            label15.Name = "label15";
            label15.Size = new Size(97, 23);
            label15.TabIndex = 5;
            label15.Text = "Delivery Fee:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Quicksand", 9F);
            label14.Location = new Point(16, 512);
            label14.Name = "label14";
            label14.Size = new Size(129, 23);
            label14.TabIndex = 5;
            label14.Text = "Delivery Address:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Quicksand", 9F);
            label13.Location = new Point(16, 475);
            label13.Name = "label13";
            label13.Size = new Size(81, 23);
            label13.TabIndex = 5;
            label13.Text = "Customer:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 229, 228);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(16, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 49);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(12, 10, 9);
            label6.Location = new Point(397, 13);
            label6.Name = "label6";
            label6.Size = new Size(56, 23);
            label6.TabIndex = 0;
            label6.Text = "Action";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(12, 10, 9);
            label11.Location = new Point(324, 13);
            label11.Name = "label11";
            label11.Size = new Size(45, 23);
            label11.TabIndex = 0;
            label11.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(12, 10, 9);
            label7.Location = new Point(248, 13);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
            label7.TabIndex = 0;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(12, 10, 9);
            label8.Location = new Point(165, 13);
            label8.Name = "label8";
            label8.Size = new Size(36, 23);
            label8.TabIndex = 0;
            label8.Text = "Qty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Quicksand", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(12, 10, 9);
            label9.Location = new Point(12, 13);
            label9.Name = "label9";
            label9.Size = new Size(42, 23);
            label9.TabIndex = 0;
            label9.Text = "Title";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Quicksand", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(367, 430);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(113, 30);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "LKR 10000";
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Quicksand", 12F, FontStyle.Bold);
            label12.Location = new Point(16, 430);
            label12.Name = "label12";
            label12.Size = new Size(67, 30);
            label12.TabIndex = 4;
            label12.Text = "Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Quicksand", 14F, FontStyle.Bold);
            label10.Location = new Point(16, 17);
            label10.Name = "label10";
            label10.Size = new Size(180, 35);
            label10.TabIndex = 4;
            label10.Text = "Shopping Cart";
            // 
            // pnlCartContainer
            // 
            pnlCartContainer.AutoScroll = true;
            pnlCartContainer.BackColor = Color.White;
            pnlCartContainer.Location = new Point(16, 132);
            pnlCartContainer.Name = "pnlCartContainer";
            pnlCartContainer.Size = new Size(464, 295);
            pnlCartContainer.TabIndex = 3;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Name = "CartTab";
            Size = new Size(1057, 719);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBxFee).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel pnlItemsContainer;
        private Components.Common.RoundedPanel roundedPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtBxSearch;
        private Label label1;
        private Components.Common.RoundedPanel roundedPanel2;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel pnlCartContainer;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label lblTotal;
        private Label label12;
        private Label label15;
        private Button btnSubmit;
        private TextBox txtBxAddress;
        private ComboBox cmbBxCustomer;
        private NumericUpDown numBxFee;
    }
}
