using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            int a, b;

            Console.WriteLine("Please write your name:");

            string name = Console.ReadLine();

            Console.Write("Hello ");
            Console.WriteLine(name);

            Console.WriteLine("Please enter 1st number:" );
            // 1
            // string stringNumber = Console.Readline();
            //a = Convert.ToInt32(stringNumber);

            //2
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.Write("Sum is : ");
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
