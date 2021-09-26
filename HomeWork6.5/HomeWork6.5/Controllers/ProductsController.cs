using HomeWork6._5.Models;
using Microsoft.AspNetCore.Mvc;
namespace HomeWork6._5.Controllers



{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpPost]

        public IActionResult Save(Product product)
        {
            if (product.Name == "")
            {
                return ValidationProblem("Nenurodete produkto pavadinimo");
            }

            if (product.Id == "")
            {
                return ValidationProblem("Nenurodete produkto numerio");

            }
            if (product.Description == "")
            {
                return ValidationProblem("Nenurodete produkto aprasymo");

            }

            if (product.FirstPrice == 0)
            {
                return ValidationProblem("Nenurodete pradines kainos");

            }
            if (product.Picture == "")
            {
                return ValidationProblem("Nenuredete prekes paveikslelio");
            }
            if (product.Discount == 0)
            {
                return ValidationProblem("Nenurodete prekes nuolaidos");
            }
            if (product.TotalPrice == 0)
            {
                return ValidationProblem("Nenurodete galutines kainos");
            }

            return Ok();
        }

       [HttpGet]
       public IActionResult List()
        {
            var service = new ProductService();
            var products = service.GetProducts();

            return new OkObjectResult(products);
        }
    }
}
