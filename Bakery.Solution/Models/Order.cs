namespace Bakery.Models
{
    public abstract class Order
    {
        public abstract int DiscountRate { get; set; }
        public abstract int Price { get; set; }
        public int Quantity { get; set; }

        public virtual int GetTotal()
        {
            return (Quantity * Price) - Price * (Quantity / DiscountRate);
        }
    }
}
