using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("請輸入要幾個數字:");
            //int count = int.Parse(Console.ReadLine());
            //int[] numbers = new int[count];
            //以上都還沒有加上防呆(課後自己補上去)

            int[] numbers = new int[10];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            numbers[4] = int.Parse(Console.ReadLine());
            numbers[5] = int.Parse(Console.ReadLine());
            numbers[6] = int.Parse(Console.ReadLine());
            numbers[7] = int.Parse(Console.ReadLine());
            numbers[8] = int.Parse(Console.ReadLine());
            numbers[9] = int.Parse(Console.ReadLine());
            numbers[10] = int.Parse(Console.ReadLine());

            numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int index = 0; index < numbers.Length; index++)
                numbers[index]
        }
    }
}