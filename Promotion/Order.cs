using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Order
    {
        private List<Product> Products= new List<Product>();
         public List<Promotion> promotions;

         public Order(List<Promotion> presentPromotions)
         {
             promotions = presentPromotions;
         }
        public void AddOrders(string item, int quantity)
        {
            if (quantity >= 0)
            {
                for (int i = 1; i <= quantity; i++)
                {
                    Product p = new Product(item);
                    Products.Add(p);
                }
                
            }
        }

        public decimal GetOrderFinalPrice()
        {
            List<decimal> promoprices = promotions
          .Select(promo => GetDiscountForPromtion(Products, promo))
          .ToList();
            decimal origprice = Products.Sum(x => x.Price);
            decimal promoprice = promoprices.Sum();
            return origprice-promoprice ;
        }

        public decimal GetOrderOriginalPrice()
        {
         
            decimal origprice = Products.Sum(x => x.Price);
         
            return origprice ;
        }
        public decimal GetOrderDiscountPrice()
        {
            List<decimal> promoprices = promotions
          .Select(promo => GetDiscountForPromtion(Products, promo))
          .ToList();
         
            decimal promoprice = promoprices.Sum();
            return  promoprice;
        }

        private decimal GetDiscountForPromtion(List<Product> _prods, Promotion prom)
        {
            decimal d = 0M;
            //get count of promoted products in order
            var copp = _prods
                .GroupBy(x => x.Id)
                .Where(grp => prom.ProductInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();
            //get count of promoted products from promotion
            int ppc = prom.ProductInfo.Sum(kvp => kvp.Value);
            while (copp >= ppc)
            {
                d += prom.PromoPrice;
                copp -= ppc;
            }
            return d;
        }
    }
}
