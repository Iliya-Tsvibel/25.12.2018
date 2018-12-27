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

            /*
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
             */
            /*
           Console.WriteLine("Zanesi liuboe chislo, chtobi proverit, esli ono prostoe");

           int m = 2;

           int a = Convert.ToInt32(Console.ReadLine());

           while (a % m != 0 && m < a)

           {
               m++; 

           }  




               if (a == m) 
               {
                   Console.WriteLine("Nishtyal! Naideno prostoe chislo. Nalei sebe stoparya.");
               }

              else
               {

               Console.WriteLine("Huem te po gubam! Mimo. Iwi dalshe i virivai po volosinke iz zhopi.");
           }


         */
            /*
               Console.WriteLine("Napishi liuboe chislo i budet podschitana aceret");


               int x = Convert.ToInt32(Console.ReadLine());

               int atz = 1;

               int i = 2;


               while (i <= x)

                   {

                   atz = atz*i;

                   i++;

               }
               Console.WriteLine(atz);

       */
            Console.WriteLine("Vpishi chislo a");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hui s toboi, vpishi ewe odno chislo b i uznaesh skolko budet a umnozhennoe na b");

            int b = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int sum = 0;

            while (i<=b)

            {
                sum = sum + a;

                i++;
            }

            Console.WriteLine(sum);


        }

    }
}