using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public Rectangle()
        {
            width = 1.0;
            height = 2.0;
            color = "Black";
            filled = true;
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height  = height;
            color = "Black";
            filled = true;
        }
        public Rectangle(double width, double height, string color, bool filled)
        {
            this.width = width;
            this.height = height;
            this.color = color;
            this.filled = filled;
        }

        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPerimeter()
        {
            return 2 * (height + width);
        }
        public override string ToString()
        {
            return "Это прямоугольник";
        }
    }
}
