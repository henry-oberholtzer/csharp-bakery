namespace Bakery.Models
{
    public class PastryOrder : Order
    {
        public override int Price => 2;

        public override int DiscountRate => 4;

        public PastryOrder(int quantity)
        {
            Quantity = quantity;
        }
    }
}
