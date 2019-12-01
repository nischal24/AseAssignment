using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Factory
    {
        public Shape getShape(string k)
        {
            if (k == "rectangle")
            {
                return new Rectangle();
            }
            else if(k== "triangle")
            {
                return new Triangle();
            }
            else if(k== "circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}
