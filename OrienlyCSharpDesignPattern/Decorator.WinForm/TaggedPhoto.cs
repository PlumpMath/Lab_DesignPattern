using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Decorator.WinForm
{
    class TaggedPhoto : Photo
    {
        Photo photo;
        string tag;
        int number;
        static int count;
        static List<string> tags = new List<string>();

        public TaggedPhoto(Photo p, string t)
        {
            photo = p;
            tag = t;
            tags.Add(t);
            number = ++count;
        }

        public override void Drawer(object source, System.Windows.Forms.PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawString(tag,
                new System.Drawing.Font("Arial", 16),
                new SolidBrush(Color.Black),
                new Point(80, 100 + number * 20));

        }

        public string ListTaggedPhotos()
        {
            string s = "Tags are: ";
            foreach (string t in tags) s += t + " ";
            return s;
        }
    }
}
