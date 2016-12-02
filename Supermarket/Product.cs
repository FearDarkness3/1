namespace Supermarket
{
    public abstract class Product : ICustomProduct
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public string Category { get; private set; }

        protected Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;

        }

        public double PriceTotal(double amount, double discount)
        {
            return Price * amount * (1 - discount * 0.01);
        }
    }
}
