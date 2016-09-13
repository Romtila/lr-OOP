using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Square : Rectangle
    {
        public Square()
        {
            width = 1.0;
            height = 1.0;
            color = "Black";
            filled = true;
        }
        public Square(double a)
        {
            width = a;
            height = a;
        }
        public Square(double a, string color, bool filled)
        {
            width = a;
            height = a;
            this.color = color;
            this.filled = filled;
        }

        public Double Side
        {
            get { return base.height; }
            set
            {
                base.width = value;
                base.height = value;
            }
        }

        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 4 * height;
        }
        public override string ToString()
        {
            return "Это квадрат";
        }
    }
}
