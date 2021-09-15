using System;

namespace homeWork1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivęskite atstumą metrais");
            double metras = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite laika sekundemis");
            double sekundes = Convert.ToDouble(Console.ReadLine());

            double v = metras / sekundes;

            Console.WriteLine("greitis km/h yra: " + v);
        }
    }
}
