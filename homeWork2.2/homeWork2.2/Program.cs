using System;

namespace homeWork2._2
{
    class Program
    {
        private static object then;

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 == 1)
            {
                Console.WriteLine(skaicius1+skaicius2+skaicius3);
            }
            if (skaicius2 == 2)
            {
                Console.WriteLine(skaicius1-skaicius3);
            }
            if (skaicius3 == 3)
            {
                Console.WriteLine(skaicius2*skaicius3);
            }

            { 
            }
        }
    }
}
