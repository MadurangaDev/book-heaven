namespace BookHaven.Components.Common
{
    partial class CustomerRow
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhone = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 13);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(301, 13);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(625, 13);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Font Awesome 6 Free Solid", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(985, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 1;
            button1.Text = "";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(16, 23, 41);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Font Awesome 6 Free Solid", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(944, 5);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 1;
            button2.Text = "";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CustomerRow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblPhone);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "CustomerRow";
            Size = new Size(1025, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhone;
        private Button button1;
        private Button button2;
    }
}
