namespace BookHaven.Components.Common
{
    partial class InventoryRow
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
            lblDate = new Label();
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
            lblQty.Location = new Point(339, 13);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(30, 20);
            lblQty.TabIndex = 0;
            lblQty.Text = "qty";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(664, 13);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(42, 20);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "price";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(935, 13);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(85, 20);
            lblDate.TabIndex = 0;
            lblDate.Text = "88/88/8888";
            lblDate.TextAlign = ContentAlignment.TopRight;
            // 
            // InventoryRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDate);
            Controls.Add(lblPrice);
            Controls.Add(lblQty);
            Controls.Add(lblTitle);
            Name = "InventoryRow";
            Size = new Size(1025, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQty;
        private Label lblPrice;
        private Label lblDate;
    }
}
