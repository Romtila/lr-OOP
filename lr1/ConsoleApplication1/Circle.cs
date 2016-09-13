using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Circle:Shape
    {
        protected double radius;

        public Circle()
        {
            radius = 1.0;
            color = "Black";
            filled = true;
        }
        public Circle(double radius) : base()
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return "Это круг";
        }
    }
}
