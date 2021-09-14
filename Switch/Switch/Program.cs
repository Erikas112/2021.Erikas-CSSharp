using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 10");

            var grade = Console.ReadLine();

            switch (grade)
            {
                case "10":
                    Console.WriteLine("Puikiai");
                    break;
                case "9":
                    Console.WriteLine("Labai gerai");
                    break;
                case "8":
                    Console.WriteLine("Gerai");
                    break;
                default:
                    Console.WriteLine("Jus neislaikete");
                    break;
             }
        }
    }
}
