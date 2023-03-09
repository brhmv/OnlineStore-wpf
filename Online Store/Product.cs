namespace Online_Store
{
    public class Product
    {
        public string? Name { get; set; }

        public double? Price { get; set; }

        public string? Photo {get; set; }

        public Product() { }

        public Product(string? name, double price, string? photo)
        {
            Name = name;
            Price = price;
            Photo = photo;
        }
    }
}
