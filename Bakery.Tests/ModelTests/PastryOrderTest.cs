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
    }
}
