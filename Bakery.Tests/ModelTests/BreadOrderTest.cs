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

        [TestMethod]
        public void BreadOrderConstructor_GetDiscountRate_Int()
        {
            int rate = 3;
            BreadOrder newOrder = new(2);
            Assert.AreEqual(newOrder.DiscountRate, rate);
        }

        [TestMethod]
        public void BreadOrderConstructor_GetTotal_int()
        {
            int expectedOne = 5;
            int expectedTwo = 10;
            int expectedThree = 10;
            int expectedFour = 15;
            BreadOrder orderOne = new(1);
            BreadOrder orderTwo = new(2);
            BreadOrder orderThree = new(3);
            BreadOrder orderFour = new(4);
            Assert.AreEqual(expectedOne, orderOne.GetTotal());
            Assert.AreEqual(expectedTwo, orderTwo.GetTotal());
            Assert.AreEqual(expectedThree, orderThree.GetTotal());
            Assert.AreEqual(expectedFour, orderFour.GetTotal());
        }
    }
}
