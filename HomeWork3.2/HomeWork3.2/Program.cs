using System;

namespace HomeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite:");
            Console.WriteLine("1.jei loptopas");
            Console.WriteLine("2.jei stacionarus");
            var pasirinkimas = Console.ReadLine();
        
            while (pasirinkimas != "1" && pasirinkimas != "2")
            {
                Console.WriteLine("Jus neteisingai pasirinkote");
                Console.WriteLine("Pasirinkite is naujo");
                pasirinkimas = Console.ReadLine();
            }

            if (pasirinkimas == "1")
            {
                Console.WriteLine("Jus pasironkote loptopa");
            }

            if (pasirinkimas == "2")
            {
                Console.WriteLine("Jus pasironkote stacionaru");
            }
        }
    }
}
