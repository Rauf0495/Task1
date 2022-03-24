using System;

namespace Task1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"cem 3 reqemlidirse "cem ucreqemlidir" eks halda "nezere alinmayıb" cap edilsin


            Console.WriteLine("Enter a first number:");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number:");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber+secondNumber>=10&&firstNumber+secondNumber<=99)
            {
                Console.WriteLine("cem ikireqemli ededdir");
            }
            else if (firstNumber+secondNumber>=100&&firstNumber+secondNumber<=999)

                Console.WriteLine("cem ucreqemlidir");
            else
            {
                Console.WriteLine("nezere alinmayıb");
            }
        }
    }
}
