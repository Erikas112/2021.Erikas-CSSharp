using System;

namespace Uzduotis2isSkaidriu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite trecia skaiciu:");
            var thirdNumber = Convert.ToDouble(Console.ReadLine());

            if(firstNumber > secondNumber && firstNumber < 100)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antra skaiciu ir pirmas skaicius yra mazesnis uz 100");
            }
            if (secondNumber > 0 && secondNumber > firstNumber)
            {
                Console.WriteLine("Antrasis skaicius yra didesnis uz 0 ir antrasis skaicius yra didesnis uz pirma");
            }
            if (firstNumber > secondNumber && firstNumber > thirdNumber || firstNumber > 0)
            {
                Console.WriteLine("Pirmasis skaicius yra didesnis uz antraji ir didesnis uz treciaji arba teigiamas");
            }
            if (thirdNumber >= 5 && thirdNumber <=10 || thirdNumber > firstNumber || thirdNumber> secondNumber)
            {
                Console.WriteLine("Treciasis skaicius itelpa i reziu nuo 5 iki 10 arba didesnis uz pirma skaiciu ir ");
            }
        }
    }
}
