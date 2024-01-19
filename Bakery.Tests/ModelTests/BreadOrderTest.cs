namespace Bakery.Models
{
    [TestClass]
    public class BreadTest
    {
        [TestMethod]
        public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
        {
            BreadOrder newOrder = new();
            Assert.AreEqual(newOrder.GetType(), typeof(BreadOrder));
        }
    }
}
