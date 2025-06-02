namespace BookHaven.Screens.Forms
{
    partial class AddNewRecordScreen
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
            label3 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            cmbBxBook = new ComboBox();
            numBxQty = new NumericUpDown();
            numBxPrice = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numBxQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBxPrice).BeginInit();
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
            lblFormTitle.Size = new Size(153, 35);
            lblFormTitle.TabIndex = 5;
            lblFormTitle.Text = "New Record";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 6;
            label2.Text = "Book:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label3.Location = new Point(25, 129);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 6;
            label3.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label4.Location = new Point(25, 175);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 6;
            label4.Text = "Price:";
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
            btnSubmit.Text = "Add Record";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbBxBook
            // 
            cmbBxBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxBook.FormattingEnabled = true;
            cmbBxBook.Location = new Point(182, 83);
            cmbBxBook.Name = "cmbBxBook";
            cmbBxBook.Size = new Size(201, 28);
            cmbBxBook.TabIndex = 10;
            cmbBxBook.ValueMember = "Value";
            cmbBxBook.DisplayMember = "Text";
            // 
            // numBxQty
            // 
            numBxQty.Location = new Point(182, 129);
            numBxQty.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numBxQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBxQty.Name = "numBxQty";
            numBxQty.Size = new Size(201, 27);
            numBxQty.TabIndex = 11;
            numBxQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numBxPrice
            // 
            numBxPrice.Location = new Point(182, 174);
            numBxPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numBxPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBxPrice.Name = "numBxPrice";
            numBxPrice.Size = new Size(201, 27);
            numBxPrice.TabIndex = 12;
            numBxPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddNewRecordScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 316);
            Controls.Add(numBxPrice);
            Controls.Add(numBxQty);
            Controls.Add(cmbBxBook);
            Controls.Add(btnSubmit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFormTitle);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewRecordScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookScreen";
            ((System.ComponentModel.ISupportInitialize)numBxQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBxPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_closeBtn;
        private Label lblFormTitle;
        private Label label2;
        private Label label3;
        private TextBox txtBxLastName;
        private Label label4;
        private TextBox txtBxPhone;
        private Button btnSubmit;
        private ComboBox cmbBxBook;
        private NumericUpDown numBxQty;
        private NumericUpDown numBxPrice;
    }
}