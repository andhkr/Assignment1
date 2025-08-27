using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountStrategy;

// for prime members on commercial app
public class PrimeDiscount : IDiscountStrategy
{
    private readonly int _discountrate = 30;
    public PrimeDiscount() { }

    public double Apply(double amount)
    {
        return _discountrate * amount / 100;
    }

}
