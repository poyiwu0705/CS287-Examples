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
            string sql =
            @"
            select*from table
            where id > 10
            ";
            Console.WriteLine(sql);

            string SQL =
            @"
select*from table
where id > 20
            ";

            string SQL2 = @"select*from table where id > 20";
            Console.WriteLine(sql);
            Console.WriteLine(SQL);
            Console.WriteLine(SQL2);

            string path = "C:\\data";
            Console.WriteLine(path);

            string path1 = "C:\\CS287-Examples\\Lecture01-Examples\\Example01\bin";
            Console.WriteLine(path1);

            string path2 = @"C:\CS287-Examples\Lecture01-Examples\Example01\bin";
            Console.WriteLine(path2);
        }
    }
}