using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Three planets:");
            Console.WriteLine("Total moon of Earth are: "+(int)Planets.earth);
            Console.WriteLine("Total moons of Saturn are: "+(int)Planets.saturn);
            Console.WriteLine(Planets.neptune);
        }
    }
}
