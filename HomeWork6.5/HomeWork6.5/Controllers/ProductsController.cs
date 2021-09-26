using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HomeWork6._5.Product;

namespace HomeWork6._5.Controllers

{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Save(Models.Product product)
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

       [HttpGet("List")]
       public IActionResult List()
        {
            var service = new ProductService();
            var products = service.GetProducts();

            return new OkObjectResult(products);
        }
        [HttpGet]
        public IActionResult Get(string id)
        {
            var service = new ProductService();
            var products = service.GetProducts();
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return new ObjectResult(product);
                }
            }
            return NotFound();
        }
        [HttpGet("filter")]
        public IActionResult filter(string text)
        {
            var service = new ProductService();
            var products = service.GetProducts();
            var filteredProducts = new List<Models.Product>();
            foreach (var product in products)
            {
                if (product.GetInformation().Contains(text))
                {
                    filteredProducts.Add(product);
                }
            }
            return new ObjectResult(filteredProducts);
        }
    }
}
