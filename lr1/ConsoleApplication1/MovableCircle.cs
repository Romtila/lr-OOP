using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MovableCircle : IMovable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int radius, MovablePoint center)
        {
            this.radius = radius;
            this.center = center;
        }

        public void MoveUp()
        {
            center.MoveUp();
        }
        public void MoveDown()
        {
            center.MoveDown();
        }
        public void MoveLeft()
        {
            center.MoveLeft();
        }
        public void MoveRight()
        {
            center.MoveRight();
        }

        public override string ToString()
        {
            return String.Format("Окружность с радиусом: {0}", radius);
        }
    }
}
