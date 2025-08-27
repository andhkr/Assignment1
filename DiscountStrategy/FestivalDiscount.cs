using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountStrategy
{
    public class FestivalDiscount:IDiscountStrategy
    {
        int _discountrate = 20;
        public FestivalDiscount() { }

        public double Apply(double amount)
        {
            return Math.Max(0,_discountrate * amount / 100 - _discountrate);
        }

    }
}
