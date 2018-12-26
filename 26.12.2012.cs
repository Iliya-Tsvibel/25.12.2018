using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Iluha Makuha golova dva uha");

            int x = 1;
            string txt = "Kak ono?";
            float f = 5.5f;
            double d = 13.456;

            x = 25;

            Console.WriteLine(x);
            Console.WriteLine(txt);

            Console.WriteLine("Vpishi svoe pogonyalo");
            string name = Console.ReadLine();
            Console.Write("Zdorovo ");
            Console.WriteLine(name);
            Console.WriteLine("Napishi liuboe chislo, chtobi proverit, esli ono dvoichnoe");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            if (a % 2 == 0)
            {
                // if true 
                Console.WriteLine("Ohuenno, eto dvoichnoe chislo!");
            }
            else
            {
                // if false
                Console.WriteLine("Hui po vsei morde, ne dvoichnoe, oblomis.");
            }

            // 1. i = 1;
            // 2. while 1 <= a -> print(i) and i = i++

            int i = 1;
            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

