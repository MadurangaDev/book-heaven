namespace BookHaven.Screens
{
    partial class LoadingScreen
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
            pic_loadder = new PictureBox();
            pnl_loader = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_loadder).BeginInit();
            SuspendLayout();
            // 
            // pic_loadder
            // 
            pic_loadder.ImageLocation = "..\\..\\..\\Assets\\Images\\Loading.png";
            pic_loadder.Location = new Point(0, 0);
            pic_loadder.Name = "pic_loadder";
            pic_loadder.Size = new Size(960, 540);
            pic_loadder.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_loadder.TabIndex = 0;
            pic_loadder.TabStop = false;
            // 
            // pnl_loader
            // 
            pnl_loader.Location = new Point(0, 539);
            pnl_loader.Name = "pnl_loader";
            pnl_loader.Size = new Size(0, 1);
            pnl_loader.TabIndex = 1;
            pnl_loader.BackColor = Color.FromArgb(128, 255, 255, 255);
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(pnl_loader);
            Controls.Add(pic_loadder);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(960, 540);
            MinimumSize = new Size(960, 540);
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingScreen";
            ((System.ComponentModel.ISupportInitialize)pic_loadder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_loadder;
        private Panel pnl_loader;
    }
}