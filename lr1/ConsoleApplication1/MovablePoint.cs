using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IMovable
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
    }

    class MovablePoint : IMovable
    {
        protected int x;
        protected int y;
        protected int xSpeed;
        protected int ySpeed;

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public void MoveUp()
        {
            y += 1;
        }
        public void MoveDown()
        {
            y -= 1;
        }
        public void MoveLeft()
        {
            x -= 1;
        }
        public void MoveRight()
        {
            x += 1;
        } 

        public override string ToString()
        {
            return String.Format("Точка с координатами x: {0} y:{1}", x, y);
        }
    }
}
