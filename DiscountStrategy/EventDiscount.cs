using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountStrategy;

// some event like Independence day, Republic day based discount
public class EventDiscount:IDiscountStrategy
{
    int _discountrate = 10;
    public EventDiscount() { }

    public double Apply(double amount)
    {
        return Math.Min(100, _discountrate * amount / 100);
    }

}
