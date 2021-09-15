using System;

namespace homeWork2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sviesoforo spalvos koda, pateikiama kodu lentele:");
            Console.WriteLine("Raudonos spalvos kodas: #ff0a0a");
            Console.WriteLine("Geltonos spalvos kodas: #ffe20a");
            Console.WriteLine("Zalios spalvos kodas: #008509");
            var traffic = Console.ReadLine();

            switch (traffic)
            {
                case "#ff0a0a":
                    Console.WriteLine("Vaziuoti draudziama");
                    break;
                case "#ffe20a":
                    Console.WriteLine("Pasiruoskite");
                    break;
                case " #008509":
                    Console.WriteLine("Vaziuoti galima");
                    break;
                default:
                    Console.WriteLine("Neatpazinta spalva");
                    break;
            }
        }
    }
}
