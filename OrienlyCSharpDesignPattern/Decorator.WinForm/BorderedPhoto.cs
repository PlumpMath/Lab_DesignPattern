using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Decorator.WinForm
{
    public class BorderedPhoto : Photo
    {
        Photo photo;
        Color color;

        public BorderedPhoto(Photo p, Color c)
        {
            this.photo = p;
            this.color = c;
        }

        public override void Drawer(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            photo.Drawer(sender, e);
            e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
        }
    }
}
