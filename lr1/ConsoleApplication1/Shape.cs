using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {
            color = "Black";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool IsFilled
        {
            get { return filled; }
            set { filled = value; }
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return "Фигура";
        }
    }
}
