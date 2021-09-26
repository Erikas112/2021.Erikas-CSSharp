using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork6._5.Models;

namespace HomeWork6._5.ProductService
{
    public class ProductsService
    {
        public  List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product(
                "Šokoladas",
                "1342586", 
                "Skanus šokoladas", 
                3, 
                "1Choco.Jpg", 
                0.50, 
                new double()
                )
                );
            products.Add(new Product(
                "Makaronai",
                "49202940",
                "Lietuviški makaronai",
                1,
                "2Macaron.Jpg",
                0.50,
                new double()
                )
                );
            products.Add(new Product(
                "Šampunas",
                "992013030",
                "Nivea šampunas",
                7,
                "1Choco.Jpg",
                1,
                new double()
                )
                );


            return products;
        }

    }
}
