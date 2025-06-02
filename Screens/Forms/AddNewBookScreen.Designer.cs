namespace BookHaven.Screens.Forms
{
    partial class AddNewBookScreen
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
            txtBxISBN = new TextBox();
            label3 = new Label();
            txtBxTitle = new TextBox();
            label4 = new Label();
            txtBxAuthor = new TextBox();
            label5 = new Label();
            cmbBxGenre = new ComboBox();
            label6 = new Label();
            label8 = new Label();
            cmbBxSuppliers = new ComboBox();
            btnSubmit = new Button();
            numBxPrice = new NumericUpDown();
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
            lblFormTitle.Size = new Size(184, 35);
            lblFormTitle.TabIndex = 5;
            lblFormTitle.Text = "Add New Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 6;
            label2.Text = "ISBN Number:";
            // 
            // txtBxISBN
            // 
            txtBxISBN.Location = new Point(182, 85);
            txtBxISBN.Name = "txtBxISBN";
            txtBxISBN.Size = new Size(201, 27);
            txtBxISBN.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 6;
            label3.Text = "Book Title:";
            // 
            // txtBxTitle
            // 
            txtBxTitle.Location = new Point(182, 126);
            txtBxTitle.Name = "txtBxTitle";
            txtBxTitle.Size = new Size(201, 27);
            txtBxTitle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label4.Location = new Point(25, 170);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 6;
            label4.Text = "Author:";
            // 
            // txtBxAuthor
            // 
            txtBxAuthor.Location = new Point(182, 170);
            txtBxAuthor.Name = "txtBxAuthor";
            txtBxAuthor.Size = new Size(201, 27);
            txtBxAuthor.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label5.Location = new Point(25, 215);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 6;
            label5.Text = "Genre:";
            // 
            // cmbBxGenre
            // 
            cmbBxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxGenre.FormattingEnabled = true;
            cmbBxGenre.Items.AddRange(new object[] { "Fictions", "Non-Fictions", "Collectibles", "Education Materials" });
            cmbBxGenre.Location = new Point(182, 215);
            cmbBxGenre.Name = "cmbBxGenre";
            cmbBxGenre.Size = new Size(201, 28);
            cmbBxGenre.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label6.Location = new Point(23, 263);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 6;
            label6.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 8.25F, FontStyle.Bold);
            label8.Location = new Point(25, 310);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 6;
            label8.Text = "Supplier:";
            // 
            // cmbBxSuppliers
            // 
            cmbBxSuppliers.DisplayMember = "Text";
            cmbBxSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBxSuppliers.FormattingEnabled = true;
            cmbBxSuppliers.Location = new Point(182, 310);
            cmbBxSuppliers.Name = "cmbBxSuppliers";
            cmbBxSuppliers.Size = new Size(201, 28);
            cmbBxSuppliers.TabIndex = 7;
            cmbBxSuppliers.ValueMember = "Value";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(16, 23, 41);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Quicksand", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(23, 378);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(360, 56);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Add Book";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // numBxPrice
            // 
            numBxPrice.Location = new Point(182, 263);
            numBxPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numBxPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBxPrice.Name = "numBxPrice";
            numBxPrice.Size = new Size(201, 27);
            numBxPrice.TabIndex = 5;
            numBxPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddNewBookScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 458);
            Controls.Add(numBxPrice);
            Controls.Add(btnSubmit);
            Controls.Add(cmbBxSuppliers);
            Controls.Add(cmbBxGenre);
            Controls.Add(txtBxAuthor);
            Controls.Add(txtBxTitle);
            Controls.Add(txtBxISBN);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFormTitle);
            Controls.Add(lbl_closeBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewBookScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewBookScreen";
            ((System.ComponentModel.ISupportInitialize)numBxPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_closeBtn;
        private Label lblFormTitle;
        private Label label2;
        private TextBox txtBxISBN;
        private Label label3;
        private TextBox txtBxTitle;
        private Label label4;
        private TextBox txtBxAuthor;
        private Label label5;
        private ComboBox cmbBxGenre;
        private Label label6;
        private Label label8;
        private ComboBox cmbBxSuppliers;
        private Button btnSubmit;
        private NumericUpDown numBxPrice;
    }
}