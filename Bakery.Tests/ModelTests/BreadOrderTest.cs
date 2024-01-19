namespace Bakery.Models
{
    [TestClass]
    public class BreadTest
    {
        [TestMethod]
        public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
        {
            BreadOrder newOrder = new(4);
            Assert.AreEqual(newOrder.GetType(), typeof(BreadOrder));
        }

        [TestMethod]
        public void BreadOrderConstructor_GetQuantity_BreadOrder()
        {
            int quantity = 5;
            BreadOrder newOrder = new(quantity);
            Assert.AreEqual(newOrder.Quantity, quantity);
        }

        [TestMethod]
        public void BreadOrderConstructor_GetPrice_Int()
        {
            int expected = 5;
            BreadOrder newOrder = new(1);
            Assert.AreEqual(newOrder.Price, expected);
        }
    }
}
