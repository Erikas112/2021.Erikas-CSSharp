using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Models
{
    public class Potatoe
    {
        public double Size { get;}
        public string SoftNess { get;}
        public double Weight { get;}
        public string Color { get;}
        public string Type { get;}

        public string Description { get;}

        public Potatoe(
            double localsize,
            string localsoftNes, 
            double localweight, 
            string localcolor,
            string localtype)
        {
            Description = GetInformation();
            Size = localsize;
            SoftNess = localsoftNes;
            Weight = localweight;
            Color = localcolor;
            Type = localtype;
            Description = GetInformation();
        }
        private string GetInformation()
        {
            return $"Bulvės dydis yra {Size}. " +
                $"Bulvės minkštumas yra {SoftNess}." +
                $" Bulvės svoris yra {Weight}. " +
                $"Bulvės spalva yra {Color}";
        }

    }

}

