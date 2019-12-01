using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Rectangle:Shape// rectangle class implements shape interface
    {
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            Pen p = new Pen(Color.Bisque, 3);
            g.DrawRectangle(p, k, l, a, b);
        }
    }
}
