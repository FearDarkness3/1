namespace Supermarket
{
    class DiscountCard
    {
        public bool Valid { get; set; }
        public double Discount { get; set; }

        public DiscountCard(double discount, bool valid = true)
        {
            Valid = valid;
            Discount = discount;
        }
    }
}
