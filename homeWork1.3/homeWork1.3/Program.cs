﻿using System;

namespace homeWork1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parašykite savo vardą:");
            var vardas = Console.ReadLine();
            Console.WriteLine("Parašykite savo pavardę");
            var pavarde = Console.ReadLine();
            Console.WriteLine("Parašykite savo gimimo vietą");
            var gimimoVieta = Console.ReadLine();
            Console.WriteLine(vardas + " " + pavarde + " " + gimimoVieta);
        }
    }
}
