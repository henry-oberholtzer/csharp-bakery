namespace Bakery.Models
{
    public abstract class Order
    {
        public abstract int DiscountRate { get; }
        public abstract int Price { get; }
        public int Quantity { get; set; }

        public virtual int GetTotal()
        {
            return (Quantity * Price) - (Quantity / DiscountRate);
        }
    }
}
