namespace MinimalApiResults.Example.Entities
{
    public class Product
    {
        public Product(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
