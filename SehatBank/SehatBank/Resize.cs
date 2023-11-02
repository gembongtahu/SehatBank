using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    public class Resize
    {
        public void resizeControl(Rectangle r, Control c, Rectangle originalSize, int width, int height)
        {
            float xRatio = (float)(width) / (float)(originalSize.Width), yRatio = (float)(height) / (float)(originalSize.Height);
            int newX = (int)(r.X * xRatio), newY = (int)(r.Y * yRatio), newWidth = (int)(r.Width * xRatio), newHeight = (int)(r.Height * yRatio);
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        public void resizeFont(Font f, Control c, Rectangle originalSize, int height)
        {
            float ratio = (float)height / (float)originalSize.Height;
            int newSize = (int)(f.Size * ratio);
            c.Font = new Font(f.FontFamily, newSize, f.Style);
        }
    }
}
