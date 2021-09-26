

namespace HomeWork6._5.Models
{
    public class Product
    {
        public Product(string name, string id, string description, double firstPrice, string picture, double discount, double totalPrice)
        {
            Name = name;
            Id = id;
            Description = description;
            FirstPrice = firstPrice;
            Picture = picture;
            Discount = discount;
            TotalPrice = firstPrice - discount;
        }

        public string Name { get; }
        public string Id   { get; }
        public string Description { get; }
        public double  FirstPrice { get; }
        public string  Picture { get; }
        public double  Discount { get; }
        public double  TotalPrice { get; }


       public string GetInformation()
        {
            return $"{Name} {Id} {Description} {FirstPrice} {Picture} {Discount} {TotalPrice}";
        }
    }
}
