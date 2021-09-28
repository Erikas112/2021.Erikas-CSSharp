using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTruck.Models
{
    public class Truck
    {
        public Truck(string name, string model, DateTime yearOfManufacture, string description, int id)
        {
            Name = name;
            Model = model;
            YearOfManufacture = yearOfManufacture;
            Description = description;
            Id = id;
        }
        public string Name { get; }
        public string Model { get; }
        public int Id { get; }
        public DateTime YearOfManufacture { get; }
        public string Description { get; }

        public string GetInformation()
        {
            return $"{Name} {Model} {YearOfManufacture} {Description}";
        }
    }
}
