using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Napishi chislo");

            int a = Convert.ToInt32(Console.ReadLine());

         
            Console.WriteLine("Tak i bit, napishi ewe odno, ne ssi");

            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)

            {
                Console.WriteLine("Nishtyak polneishii! Ti ugadal: pervoe chislo delitsya na vtoroe bez ostatka. Vozmi s polki pirozgok.");
            }        
                     
            else

            {
                Console.WriteLine("Ebat, ti loh! Poprobui ewe raz. Nuzhno, chtobi pervoe chislo delilos na vtoroe bez ostatka. Flag v ruki.");
            }
            */

            /* Console.WriteLine("Napishi chislo");

           int a = Convert.ToInt32(Console.ReadLine());


           Console.WriteLine("Tak i bit, napishi ewe odno, ne ssi");

           int b = Convert.ToInt32(Console.ReadLine());

           int sum = a + b;

           double avg = sum / 2.0;

           Console.WriteLine(avg);
           */

            Console.WriteLine("Napishi kakoe-nibud chislo");

            int y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

       
            while (y > 0)
            {
                
                    sum = sum + y;

                    Console.WriteLine("Davai ewe odno.");

                    y = Convert.ToInt32(Console.ReadLine());

            }
                
                
                          

                      

            Console.WriteLine("Hui te v glotku! Ti zanes otricatelnoe chislo. Poluchi summu iz prediduwih zanesennih:");
                Console.WriteLine(sum);

            

        }

    }
}
