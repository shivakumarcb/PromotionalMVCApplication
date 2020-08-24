using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class PresentPromotion
    {
        public  List<Promotion> promotions= new List<Promotion>();

        public PresentPromotion ()
        {
            //we need to add information about Product's count
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("A", 3);
            Dictionary<String, int> d2 = new Dictionary<String, int>();
            d2.Add("B", 2);
            Dictionary<String, int> d3 = new Dictionary<String, int>();
            d3.Add("C", 1);
            d3.Add("D", 1);

            promotions = new List<Promotion>()
            {
                new Promotion(1, d1, 20), // AAA - 150 but because of promotion 130, 20 less
                new Promotion(2, d2, 15), // BB --60 but because of promotion 45, 25 less
                new Promotion(3, d3, 5)     //CD --35 promotion is 30, 5 less
            };
        }

        public List<Promotion> getPromotions()
        {
            return promotions;
        }

    }
}
