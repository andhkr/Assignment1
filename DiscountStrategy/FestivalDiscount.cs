// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace DiscountStrategy;

// Festival based Discount
public class FestivalDiscount : IDiscountStrategy
{
    private readonly int _discountrate = 20;

    public FestivalDiscount() { }

    public double Apply(double amount)
    {
        return Math.Max(0, _discountrate * amount / 100 - _discountrate);
    }

}
