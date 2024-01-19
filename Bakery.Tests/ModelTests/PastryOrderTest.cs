namespace Bakery.Models
{
    [TestClass]
    public class PastryTest
    {
        [TestMethod]
        public void PastryOrderConstructor_CreateInstanceOfPastryOrder_PastryOrder()
        {
            PastryOrder order = new(2);
            Assert.AreEqual(order.GetType(), typeof(PastryOrder));
        }

        [TestMethod]
        public void PastryOrderConstructor_GetQuantity_int()
        {
            int expected = 3;
            PastryOrder order = new(expected);
            Assert.AreEqual(order.Quantity, expected);
        }

        [TestMethod]
        public void PastryOrderConstructor_SetQuantity_PastryOrder()
        {
            PastryOrder order = new(3);
            int newQuantity = 5;
            order.Quantity = newQuantity;
            Assert.AreEqual(order.Quantity, newQuantity);
        }

        [TestMethod]
        public void PastryOrderConstructor_GetPrice_Int()
        {
            int expected = 2;
            PastryOrder order = new(1);
            Assert.AreEqual(order.Price, expected);
        }

        [TestMethod]
        public void PastryOrderConstructor_GetDiscountRate_Int()
        {
            int rate = 4;
            PastryOrder newOrder = new(3);
            Assert.AreEqual(newOrder.DiscountRate, rate);
        }
    }
}
