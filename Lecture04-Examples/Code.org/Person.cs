﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.org
{
    public class Person
    {
        public string Name;
        public Position Pos;
        public double Theta;

        public void MoveForward(double d)
        {
            Pos.X += d * Math.Cos(Theta * Math.PI / 180.0);
            Pos.Y += d * Math.Sin(Theta * Math.PI / 180.0);
        }

        public void TurnRight(double theta)
        {
            Theta += theta;
            Theta %= 360.0;
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1},{2})方位角:{3}度"
                , Name
                , Pos.X
                , Pos.Y
                , Theta);
        }
    }
}