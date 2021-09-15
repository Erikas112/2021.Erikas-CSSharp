using System;

namespace homeWork2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite norima gerima: 1 - limonadas; 2 - arbata; 3 - kakava; 4 - kava; 5  - nieko.");
            var chose = Console.ReadLine();
            var option = " ";
            
            switch (chose)
            {
             case "1":
              option = "limonadas";
               break;
             case "2":
              option = "arbata";
               break;
             case "3":
              option = "kakava";
               break;
             case "4":
              option = "kava";
               break;
             case "5":
              option = "nieko";
               break;
             default:
             Console.WriteLine("blogai įvestas pasirinkimas");
                    break;
            }
            if (option != " ")
            {

            }
            Console.WriteLine("Jus pasirinkote: " + option);
        }
    }
}
