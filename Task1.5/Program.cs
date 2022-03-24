using System;

namespace Task1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a ededi b ededine tam bolunurse tam bolunur eks halda bolunmur

            Console.WriteLine("Enter a first number:");

            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number:");

            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{firstNumber}/{secondNumber}=");

            
            if (firstNumber%secondNumber==0)
            {
                Console.WriteLine(firstNumber/secondNumber);

            }
            
            else
            {
                Console.WriteLine("tam bölünmür");
            }











        }
    }
}
