using System;

namespace Task1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a ededi 1-reqemlidirse cavabda 1-reqemli 2 - reqemlidise cavabda 2reqemli.....   5 - reqemlidise cavabda 5reqemli cap edin


            Console.WriteLine("Enter a number:");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a>=0&&a<=9)
            {
                Console.WriteLine("1-reqemli");
            }

            else if (a >=10 && a <=99)
            {
                Console.WriteLine("2reqemli");
            }

            else if (a >= 100 && a <= 999)
            {
                Console.WriteLine("3reqemli");
            }
            else if (a >= 1000 && a <= 9999)
            {
                Console.WriteLine("4reqemli");

            }
            else if (a >= 10000 && a <= 99999)
            {
                Console.WriteLine("5reqemli");

            }



        }
            
       
    }
}
