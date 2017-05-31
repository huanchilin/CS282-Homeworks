using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    public class Person
    {
        public string Name;
        public string Birthday;
        public string Email;
        public Position Pos;
        public double Orientation;

        public void MoveForward(double distance)
        {
            Pos.X = Pos.X + Math.Cos(Orientation * Math.PI / 180.0) * distance;
            Pos.Y = Pos.Y + Math.Sin(Orientation * Math.PI / 180.0) * distance;
        }

        public void TurnRight(double angle)
        {
            Orientation = Orientation + angle;
        }

        public void ShowPosition()
        {
            Console.WriteLine("{0}'s position is at: ({1},{2}) Orientation at {3} degree", Name, Pos.X, Pos.Y, Orientation);
        }

        public void DrawRectRight(double length, double width)
        {
            for (var count = 0; count < 2; count++)
            {
                this.MoveForward(length);
                this.TurnRight(90);
                this.MoveForward(width);
                this.TurnRight(90);
                this.ShowPosition();
            }
        }

        public void DrawRectRight()
        {
            DrawRectRight(50, 40);
        }

        public void DrawRectLeft(double length, double width)
        {
            for (var count = 0; count < 2; count++)
            {
                this.MoveForward(width);
                this.TurnRight(90);
                this.MoveForward(length);
                this.TurnRight(90);
                this.ShowPosition();
            }
        }

        public void DrawRectLeftt()
        {
            DrawRectLeft(50, 40);
        }
    }
}