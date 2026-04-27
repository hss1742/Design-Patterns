namespace src.ObserverDesignPattern.Models
{
    public class Product
    {
        public string Name{get; set;}

        public int Quantity {get; set;}

        public Product(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}