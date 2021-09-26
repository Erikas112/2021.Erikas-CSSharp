
using System;
using System.Collections.Generic;
namespace HomeWork6._5.Product
{
    public class ProductService
    {
        public  List<Models.Product> GetProducts()
        {
            var products = new List<Models.Product>();
            products.Add(new Models.Product(
                "Šokoladas",
                "1342586", 
                "Skanus šokoladas", 
                3, 
                "1Choco.Jpg", 
                0.50, 
                new double(
                    )
                  )
                );
            products.Add(new Models.Product(
                "Makaronai",
                "49202940",
                "Lietuviški makaronai",
                1,
                "2Macaron.Jpg",
                0.50,
                new double(
                    )
                  )
                );
            products.Add(new Models.Product(
                "Šampunas",
                "992013030",
                "Nivea šampunas",
                7,
                "3sampunas.Jpg",
                1,
                new double(
                    )
                  )
                );
            return products;
        }
    }
}
