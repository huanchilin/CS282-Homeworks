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
            Person person = new Person()
            {
                Name = "Thomas",
                Birthday = "0523",
                Email = "huanchilin@gmail.com",
                Orientation = 0.0,
                Pos = Position.Generate()
            };
            Console.WriteLine("Do you want to trun Left or Right?");
            string turn = Console.ReadLine();
            if (turn == "Left")
            {
                Console.WriteLine("Please enter your desired rectangle's length");
                double length = 0.0;
                bool success_length = double.TryParse(Console.ReadLine(), out length);
                Console.WriteLine("Please enter your desired rectangle's width");
                double width = 0.0;
                bool success_width = double.TryParse(Console.ReadLine(), out width);
                person.DrawRectLeft(length, width);
                if (success_length && success_width)
                    person.DrawRectLeft(length, width);
                else
                    Console.WriteLine("Enter error! Please try again!");
            }
            if (turn == "Right")
            {
                Console.WriteLine("Please enter your desired rectangle's length");
                double length = 0.0;
                bool success_length = double.TryParse(Console.ReadLine(), out length);
                Console.WriteLine("Please enter your desired rectangle's width");
                double width = 0.0;
                bool success_width = double.TryParse(Console.ReadLine(), out width);
                person.DrawRectLeft(length, width);
                if (success_length && success_width)
                    person.DrawRectLeft(length, width);
                else
                    Console.WriteLine("Enter error! Please try again!");
            }
            else
                Console.WriteLine("Please re-enter your desired direction!");
        }
    }
}