using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Components.Common
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.FromArgb(231, 229, 228);
        public int BorderThickness { get; set; } = 2;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = BorderRadius * 2;

                // Draw rounded rectangle
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(Width - radius - 1, Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, Height - radius - 1, radius, radius, 90, 90);
                path.CloseFigure();

                // Fill background
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw border
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}
