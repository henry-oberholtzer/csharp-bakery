using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
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

        [TestMethod]
        public void PastryOrderConstructor_GetTotal_int()
        {
            int expectedOne = 4;
            int expectedTwo = 6;
            int expectedThree = 6;
            int expectedFour = 8;
            PastryOrder orderOne = new(2);
            PastryOrder orderTwo = new(3);
            PastryOrder orderThree = new(4);
            PastryOrder orderFour = new(5);
            Assert.AreEqual(expectedOne, orderOne.GetTotal());
            Assert.AreEqual(expectedTwo, orderTwo.GetTotal());
            Assert.AreEqual(expectedThree, orderThree.GetTotal());
            Assert.AreEqual(expectedFour, orderFour.GetTotal());
        }
    }
}
