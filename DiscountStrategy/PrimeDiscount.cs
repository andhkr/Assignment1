using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountStrategy
{
    public class PrimeDiscount:IDiscountStrategy
    {
        int discount_rate=30;
        public PrimeDiscount() { }

        public double Apply(double amount)
        {
            return discount_rate * amount/100;
        }

    }
}
