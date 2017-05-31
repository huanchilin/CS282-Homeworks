using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string html =
                @"select * from Table
                where id >10
                ";
            Console.WriteLine(html);
            string path = @"C:\xampp\htdoc\";
            Console.WriteLine(path);
        }
    }
}