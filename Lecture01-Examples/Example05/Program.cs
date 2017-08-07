using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;     //float後面一定要有f(不管多長都要),不然會被當成Double的型態
            float b = 0.2f;     //float後面一定要有f(不管多長都要),不然會被當成Double的型態
            float c = 0.3f;     //float後面一定要有f(不管多長都要),不然會被當成Double的型態
            Console.WriteLine(a + b == c);      //程式語言中a+b==c 並不是一個肯定的公式，而是一個疑問句

            Console.WriteLine("以下是另一個程式");

            float e = 1.0f;
            float f = 2.0f;
            float g = e / f;
            Console.WriteLine("1/2={0}", g);

            float h = 1.0f / 2.0f;
            Console.WriteLine("1/2={0}", h);

            Console.WriteLine("以下為測試2");
            int i = 1;      //i為整數
            int j = 2;      //j為整數
            float k = i / j;        //整數/整數不會有小數，所以k值為0
            Console.WriteLine("1/2={0}", k);
            Console.WriteLine(i / j == k);
            Console.WriteLine("以上為測試2");

            Console.WriteLine(1 / 2);
            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(1.0 / 2.0);

            int l = 1;      //l為整數
            int m = 2;      //m為整數
            float n = l / m;        //整數/整數不會有小數，所以n值為0
            Console.WriteLine("1/2={0}", n);
            Console.WriteLine(l / m == n);
        }
    }
}