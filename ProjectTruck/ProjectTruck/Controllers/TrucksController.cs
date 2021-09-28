using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTruck.Models;
using ProjectTruck.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTruck.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrucksController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Truck truck)
        {
            if (truck.Name == "")
            {
                return ValidationProblem("Nenurodėte vilkiko markės");               
            }
            if (truck.Model == "")
            {
                return ValidationProblem("Nenurodėte vilkiko modelio");
            }
            if (truck.YearOfManufacture == System.DateTime.MinValue)
            {
                return ValidationProblem("Nenurodėte pagaminimo metu");
            }
            if (truck.Description == "")
            {
                return ValidationProblem("Nenurodėte aprašymo");
            }
            if (truck.Id == 0)
            {
                return ValidationProblem("Nenurodėte indentifikacinio numerio");
            }
            var service = new TruckService();
            service.CreateTruck(truck);
            return Ok();
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            var service = new TruckService();
            var trucks = service.GetTrucks();           
            return new OkObjectResult(trucks);
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var service = new TruckService();
            var truck = service.GetTruck(id);
            return new OkObjectResult(truck);
    
        }

        [HttpGet("filter")]
        public IActionResult filter(string text)
        {
            var service = new TruckService();
            var trucks = service.GetTrucks();
            var filteredTrucks = new List<Truck>();
            foreach (var truck in trucks)
            {
                if (truck.GetInformation().Contains(text))
                {
                    filteredTrucks.Add(truck);
                }
            }
            return new OkObjectResult(filteredTrucks);
        }
    }
}
