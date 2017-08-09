using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon Pokemon1 = new Pokemon();

            Console.Write("請輸入National No:");
            try
            {
                Pokemon1.NationalNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("National NO 輸入錯誤!");
                return;
            }

            Console.Write("請輸入Type:");
            Pokemon1.Type = Console.ReadLine();

            Console.Write("請輸入Species:");
            Pokemon1.Species = Console.ReadLine();

            Console.Write("請輸入Height:");
            try
            {
                Pokemon1.Height = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Height 輸入錯誤!");
                return;
            }

            Console.Write("請輸入Weight:");
            try
            {
                Pokemon1.Weight = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Weight 輸入錯誤!");
                return;
            }

            Console.Write("請輸入Abilities:");
            Pokemon1.Abilities = Console.ReadLine();

            Console.Write("請輸入Local No1:");
            Pokemon1.LocalNo1 = Console.ReadLine();

            Console.Write("請輸入Local No2:");
            Pokemon1.LocalNo2 = Console.ReadLine();

            Console.Write("請輸入Local No3:");
            Pokemon1.LocalNo3 = Console.ReadLine();

            Console.Write("請輸入Local No4:");
            Pokemon1.LocalNo4 = Console.ReadLine();

            Console.Write("請輸入Japanese:");
            Pokemon1.Japanese = Console.ReadLine();

            Console.WriteLine("您的寶可夢資料如下:");
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
, Pokemon1.NationalNo, Pokemon1.Type, Pokemon1.Species, Pokemon1.Height, Pokemon1.Weight, Pokemon1.Abilities, Pokemon1.LocalNo1, Pokemon1.LocalNo2, Pokemon1.LocalNo3, Pokemon1.LocalNo4, Pokemon1.Japanese);
        }
    }
}