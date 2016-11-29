namespace Supermarket
{
    class DiscountCard
    {
        public bool Valid { get; private set; }
        public double Discount { get; private set; }

        public DiscountCard(double discount, bool valid = true)
        {
            Valid = valid;
            Discount = discount;
        }
    }
}
