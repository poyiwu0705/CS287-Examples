using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入National No:");
            string NationalNo = Console.ReadLine();

            Console.Write("請輸入Type:");
            string Type = Console.ReadLine();

            Console.Write("請輸入Species:");
            string Species = Console.ReadLine();

            Console.Write("請輸入Height:");
            string Height = Console.ReadLine();

            Console.Write("請輸入Weight:");
            string Weight = Console.ReadLine();

            Console.Write("請輸入Abilities:");
            string Abilities = Console.ReadLine();

            Console.Write("請輸入Local No1:");
            string LocalNo = Console.ReadLine();

            Console.Write("請輸入Local No2:");
            string LocalNo1 = Console.ReadLine();

            Console.Write("請輸入Local No3:");
            string LocalNo2 = Console.ReadLine();

            Console.Write("請輸入Local No4:");
            string LocalNo3 = Console.ReadLine();

            Console.Write("請輸入Japanese:");
            string Japanese = Console.ReadLine();

            Console.WriteLine("您輸入的資料如下:");
            Console.WriteLine(@"National No:{0}
       Type:{1}
    Species:{2}
     Height:{3}
     Weight:{4}
  Abilities:{5}
            {6}
   Local No:{7}
            {8}
            {9}
   Japanese:{10}"
, NationalNo, Type, Species, Height, Weight, Abilities, LocalNo, LocalNo1, LocalNo2, LocalNo3, Japanese);
        }
    }
}