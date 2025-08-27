using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountStrategy
{
    public class EventDiscount:IDiscountStrategy
    {
        int _discountrate = 10;
        public EventDiscount() { }

        public double Apply(double amount)
        {
            return Math.Min(_discountrate, _discountrate * amount / 100 - _discountrate);
        }

    }
}
