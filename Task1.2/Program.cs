using System;

namespace Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a - ededi 3-e bolunən cüt ədəddirsə "3-e bolunur cutdur" ,3-e bolunən tek ededdirse "3-e bolunur tekdir" eks halda "3-e bolunmur" sözünü ekranda çap edin

            Console.WriteLine("Enter a number:");

            int a = Convert.ToInt32(Console.ReadLine());

            if (a%3!=0)
            {
                Console.WriteLine("3-e bolunmur");
            }
            else if (a%2==0)
            {
                Console.WriteLine("3-e bolunur cutdur");

            }
            else
            {
                Console.WriteLine("3-e bolunur tekdir");
            }
        }
    }
}
