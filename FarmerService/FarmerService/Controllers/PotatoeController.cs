using FarmerService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmerService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PotatoeController : ControllerBase
    {
        [HttpGet]
        public IActionResult List()
        {
            //var potatoe1 = new PotatoeModel();
            //potatoe1.Size = 50;
            //potatoe1.SoftNess = "Svelni";
            //potatoe1.Type = "Kaimiskos";
            //potatoe1.Weight = 50;
            //potatoe1.Color = "geltonos";

            //var potatoe2 = new PotatoeModel();
            //potatoe2.Size = 30;
            //potatoe2.SoftNess = "Skysta";
            //potatoe2.Type = "Miestietiskos";
            //potatoe2.Weight = 40;
            //potatoe2.Color = "rudos";


            //var potatoes = new PotatoeModel[] { potatoe1, potatoe2 };

            var potatoe1 = new Potatoe(50, "Svelni", 50, "Geltona", "Kaimiskos");
            var potatoe2 = new Potatoe(30, "Skysta", 40, "Miestietiskos", "rudos");


            //var potatoes = new Potatoe[] { potatoe1, potatoe2 };
            var potatoes = new List<Potatoe>();
            potatoes.Add(potatoe1);
            potatoes.Add(potatoe2);


            var filteredPotatoe = new List<Potatoe>();
            foreach(var potatoe in potatoes)
            {
                if(potatoe.Weight >= 50)
                {
                    filteredPotatoe.Add(potatoe);
                }
            }

            //potatoes.Remove(potatoe1);

            return new OkObjectResult(filteredPotatoe);
        }
    }
}
