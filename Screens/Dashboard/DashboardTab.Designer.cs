namespace BookHaven.Screens.Dashboard
{
    partial class DashboardTab
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
            roundedPanel1 = new Components.Common.RoundedPanel();
            roundedPanel2 = new Components.Common.RoundedPanel();
            roundedPanel3 = new Components.Common.RoundedPanel();
            roundedPanel4 = new Components.Common.RoundedPanel();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderThickness = 2;
            roundedPanel1.Location = new Point(38, 38);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(231, 125);
            roundedPanel1.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderThickness = 2;
            roundedPanel2.Location = new Point(288, 38);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(231, 125);
            roundedPanel2.TabIndex = 0;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.BorderThickness = 2;
            roundedPanel3.Location = new Point(538, 38);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(231, 125);
            roundedPanel3.TabIndex = 0;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BorderColor = Color.FromArgb(231, 229, 228);
            roundedPanel4.BorderRadius = 20;
            roundedPanel4.BorderThickness = 2;
            roundedPanel4.Location = new Point(788, 38);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(231, 125);
            roundedPanel4.TabIndex = 0;
            // 
            // DashboardTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel4);
            Controls.Add(roundedPanel3);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Name = "DashboardTab";
            Size = new Size(1057, 719);
            ResumeLayout(false);
        }

        #endregion

        private Components.Common.RoundedPanel roundedPanel1;
        private Components.Common.RoundedPanel roundedPanel2;
        private Components.Common.RoundedPanel roundedPanel3;
        private Components.Common.RoundedPanel roundedPanel4;
    }
}
