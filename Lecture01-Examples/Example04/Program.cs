using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入帳號:");
            string userName = Console.ReadLine();
            Console.Write("請輸入密碼:");
            string userPassword = Console.ReadLine();
            Console.WriteLine("{0},登入成功!", userName);

            Console.WriteLine("下面是測試，輸入會有順序");

            string userNamee = Console.ReadLine();
            string userPasswordd = Console.ReadLine();
            Console.Write("請輸入帳號:");
            Console.Write("請輸入密碼:");
            Console.WriteLine("{0},登入成功!", userName);

            Console.WriteLine("以下是回家作業錯誤的地方");

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

            Console.Write("請輸入Local No:");
            string LocalNo = Console.ReadLine();

            Console.Write("請輸入Japanese:");
            string Japanese = Console.ReadLine();

            Console.WriteLine("您輸入的資料如下:");
            Console.WriteLine(@"National No:{0}
Type:{1}
Species:{2}
Height:{3}
Weight:{4}
Abilities:{5}
Local No:{6}
Japanese:{7}"
, NationalNo, Type, Species, Height, Weight, Abilities, LocalNo, Japanese);
        }
    }
}