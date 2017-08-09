using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product();

            Console.Write("請輸入Product ID:");
            try
            {
                product1.Id = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Product ID 格式錯誤");
                return;
            }

            Console.Write("請輸入Product Name:");
            product1.Name = Console.ReadLine();

            Console.Write("請輸入Product Price:");
            try
            {
                product1.Price = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Product Price格式錯誤");
                return;
            }

            Console.Write("請輸入Product Categories:");
            product1.Categories = Console.ReadLine();

            Console.WriteLine("輸入完畢，您輸入的Product資料如下：");
            Console.WriteLine(@"
        Product ID:{0}
      Product Name:{1}
     Product Price:{2}
Product Categories:{3}"
, product1.Id, product1.Name, product1.Price, product1.Categories);
        }
    }
}