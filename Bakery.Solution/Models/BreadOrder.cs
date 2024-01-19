namespace Bakery.Models
{
    public class BreadOrder : Order
    {
        public override int Price => 5;

        public BreadOrder(int quantity)
        {
            Quantity = quantity;
        }
    }
}
