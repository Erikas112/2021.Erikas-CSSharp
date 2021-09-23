using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Models
{
    public class PotatoeModel
    {
        public double Size { get; set; }
        public string SoftNess { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public string GetInformation()
        {
            return $"Bulvės dydis yra {Size}. Bulvės minkštumas yra {SoftNess}. Bulvės svoris yra {Weight}. Bulvės spalva yra {Color}";
        }
    }
}
