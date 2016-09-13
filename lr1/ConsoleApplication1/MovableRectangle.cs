using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MovableRectangle : IMovable
    {
        private MovablePoint tomLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(MovablePoint a, MovablePoint b)
        {
            tomLeft = a;
            bottomRight = b;
        }

        public void MoveUp()
        {
            tomLeft.MoveUp();
            bottomRight.MoveUp();
        }
        public void MoveDown()
        {
            tomLeft.MoveDown();
            bottomRight.MoveDown();
        }
        public void MoveLeft()
        {
            tomLeft.MoveLeft();
            bottomRight.MoveLeft();
        }
        public void MoveRight()
        {
            tomLeft.MoveRight();
            bottomRight.MoveRight();
        }

        public override string ToString()
        {
            return String.Format("Прямоугольник с верхней левой точкой:{0} и нижней правой:{1}",tomLeft,bottomRight);
        }
    }
}
