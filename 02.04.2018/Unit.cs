using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2018
{
    class Unit
    {
        public double x = 0;
        public double y = 0;
        public int Rotate = 0;
        public double Power = 1;

        public Unit(double x, double y, int r, double p)
        {
            this.x = x;
            this.y = y;
            this.Rotate = r;
            this.Power = p;
        }

        public Unit()
        {
            this.x = 0;
            this.y = 0;
            this.Rotate = 0;
            this.Power = 0;
        }

        public void Move()
        {
            x = Math.Sin(Rotate * Math.PI / 180) * Power + x;
            y = Math.Cos(Rotate * Math.PI / 180) * Power + y;

        }
        public void TurnRight()
        {
            Rotate += 5;
        }
        public void TurnLeft()
        {
            Rotate -= 5;

        }
        public void Accelator()
        {
            Power += 0.8;
        }
        public void Stop()
        {
            Power -= 0.9;
        }
    }
}
