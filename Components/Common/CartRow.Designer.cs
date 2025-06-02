namespace BookHaven.Components.Common
{
    partial class CartRow
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
            lblQty = new Label();
            lblPrice = new Label();
            button1 = new Button();
            lblTotal = new Label();
            button2 = new Button();
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
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(165, 13);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(32, 20);
            lblQty.TabIndex = 0;
            lblQty.Text = "Qty";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(248, 13);
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
            button1.Location = new Point(424, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(324, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "total";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(92, 168, 92);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Font Awesome 6 Free Solid", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(383, 5);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 1;
            button2.Text = "";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // CartRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(lblQty);
            Controls.Add(lblTitle);
            Name = "CartRow";
            Size = new Size(464, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQty;
        private Label lblPrice;
        private Button button1;
        private Label lblTotal;
        private Button button2;
    }
}
