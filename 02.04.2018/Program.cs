using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._04._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit u = new Unit();
            u.Accelator();
            u.Move();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
