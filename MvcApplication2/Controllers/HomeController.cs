using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using MvcApplication2.Models;
using ConsoleApplication6;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "My MVC Application";

            return View();
        
        
      }

        [HttpPost]
        public ActionResult Index(CartItems model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                ModelState.Remove("OriginalPrice");
                ModelState.Remove("Discount");
                ModelState.Remove("FinalPrice");

                PresentPromotion presentPromotions = new PresentPromotion();
                List<Promotion> promotions = presentPromotions.getPromotions();
                Order order = new Order(promotions);
                order.AddOrders("A", model.AQuantity);
                order.AddOrders("B", model.BQuantity);
                order.AddOrders("C", model.CQuantity);
                order.AddOrders("D", model.DQuantity);
                decimal finalPrice = order.GetOrderFinalPrice();
                model.FinalPrice = finalPrice.ToString();
                model.OriginalPrice = order.GetOrderOriginalPrice().ToString();
                model.Discount = order.GetOrderDiscountPrice().ToString();
                ModelState.Clear();
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        public ActionResult About()
        {
            return View();
        }
    }
}
