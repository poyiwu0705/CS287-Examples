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
        }
    }
}