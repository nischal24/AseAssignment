using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment
{
    class Triangle:Shape // triangle class implements from shape interface
    {
        public void drawShape(string[] res, Graphics g, int k, int l)
        {
            int point2 = 0;
            int temps = 0;
            int sideA = Convert.ToInt32(res[1]);
            int sideB = Convert.ToInt32(res[2]);
            int sideC = Convert.ToInt32(res[3]);
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                if (sideB > sideA)
                {
                    if (sideC > sideB)
                    {
                        temps = sideC;
                        sideC = sideA;
                        sideA = temps;

                    }
                    else
                    {
                        temps = sideB;
                        sideB = sideA;
                        sideA = temps;
                    }
                }
                if (sideC > sideA)
                {
                    temps = sideC;
                    sideC = sideA;
                    sideA = temps;

                }
                double sides = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(sides * (sides - sideA) * (sides - sideB) * (sides - sideC));
                double h = 2 * area / sideA;
                double point = (h * h) - (sideB * sideB);
                int sh = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);

                }
                else
                {
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);
                }
                Point[] points = new Point[3];
                points[0] = new Point(k, l);
                points[1] = new Point(k, sideA);
                points[2] = new Point(sh, point2);

                Pen pen = new Pen(Color.Black, 2);
                g.DrawLine(pen, points[0], points[1]);
                g.DrawLine(pen, points[1], points[2]);
                g.DrawLine(pen, points[0], points[2]);
            }
            else
            {
                MessageBox.Show("Triangle cannot be formed");
            }
        }
    }
}
