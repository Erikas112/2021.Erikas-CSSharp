using System;

namespace Paskaita2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu");
            var age = Convert.ToInt32(Console.ReadLine());

            if(age >=20 && age < 50)
            {
                Console.WriteLine("Sveiki prisijunge!");

            }
            else if (age >=50 && age <=70)
            {
                Console.WriteLine("Jums specialus pasiulymas");
            }
            else
            {
                Console.WriteLine("Ateikite kita karta");

            }

        }
    }
}
