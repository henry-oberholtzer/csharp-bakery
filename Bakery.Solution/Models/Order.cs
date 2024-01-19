namespace Bakery.Models
{
    public abstract class Order
    {
        public abstract int Price { get; }
        public int Quantity { get; set; }
        // public abstract int GetCost();
    }
}
