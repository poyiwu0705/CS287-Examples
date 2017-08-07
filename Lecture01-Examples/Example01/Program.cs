using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Name = "poyi";
            Console.Write("Hello,{0}", Name);

            string name = "fuck,the world";
            Console.Write(", come on,let us {0}", name);

            string centuries = "21";
            string years = "2017";
            string days = "08/07";
            string hours = "15:04";
            Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuries, years, days, hours);

            int centuriess = 21;
            int yearss = 2017;
            int dayss = 08 / 07;
            int hourss = 1504;
            Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuriess, yearss, dayss, hourss);

            byte centuriesss = 20; //
            ushort yearsss = 2000;
            uint daysss = 73048;
            ulong hoursss = 17531520;
            Console.WriteLine("{0} centuries is {1} years, or {2} days, or {3} hours.", centuriesss, yearsss, daysss, hoursss);
        }
    }
}