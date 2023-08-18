using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcrrank
{
    public class Topla
    {
        public static List<int> findMaximumValue(List<int> prices, List<int> pos, List<long> amount)
        {
            List<int> results = new List<int>();
            double totalPrice = prices.Sum();

            for (double i = 0; i < pos.Count; i++)
            {
                double cubicle = pos[(int)i];
                double budget = amount[(int)i];

                if (cubicle > prices.Count)
                {
                    results.Add(0);  
                }
                else
                {
                    if (totalPrice <= budget)
                    {
                        results.Add(prices.Count - (int)cubicle + 1);  
                    }
                    else
                    {
                        int productsPurchased = 0;
                        for (int j = (int)cubicle - 1; j < prices.Count; j++)
                        {
                            if (prices[j] <= budget)
                            {
                                productsPurchased++;
                                budget -= prices[j];
                            }
                            else
                            {
                                break;
                            }
                        }
                        results.Add(productsPurchased);
                    }
                }
            }

            return results;
        }
    }
}
