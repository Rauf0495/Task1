using System;

namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a - ededi 3-e bolunurse "Yes" ,bölünmürsə "No" sözünü ekranda çap edin

            Console.WriteLine("Enter a number:");

            int a=Convert.ToInt32(Console.ReadLine());

            if (a%3==0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
