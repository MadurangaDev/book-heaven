namespace BookHaven.Components.Common
{
    partial class BookSearchRow
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblPrice = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(161, 13);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(307, 13);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 20);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "price";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 92, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Font Awesome 6 Free Solid", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(430, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BookSearchRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblPrice);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Name = "BookSearchRow";
            Size = new Size(471, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblPrice;
        private Button button1;
    }
}
