
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication6;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForABC()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 1);
            order.AddOrders("B", 1);
            order.AddOrders("C", 1);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 100);
        }

        [TestMethod]
        public void TestForAAAAABBBBBC()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 5);
            order.AddOrders("B", 5);
            order.AddOrders("C", 1);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 370);
        }

        [TestMethod]
        public void TestForAAABBBBBCD()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 3);
            order.AddOrders("B", 5);
            order.AddOrders("C", 1);
            order.AddOrders("D", 1);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 280);
        }

        [TestMethod]
        public void TestForABCD()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 1);
            order.AddOrders("B", 1);
            order.AddOrders("C", 1);
            order.AddOrders("D", 1);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 110);
        }
        [TestMethod]
        public void TestFor3000A()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 3000);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 130000);
        }
        [TestMethod]
        public void TestFor3000AFailed()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("A", 3000);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreNotEqual(finalPrice, 150000);
        }
        [TestMethod]
        public void TestFor2000B()
        {
            PresentPromotion presentPromotions = new PresentPromotion();
            List<Promotion> promotions = presentPromotions.getPromotions();
            Order order = new Order(promotions);
            order.AddOrders("B", 2000);
            decimal finalPrice = order.GetOrderFinalPrice();
            Assert.AreEqual(finalPrice, 45000);
        }
    }
}
