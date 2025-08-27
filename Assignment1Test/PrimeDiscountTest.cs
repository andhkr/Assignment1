// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscountStrategy;
using Executive;

namespace Assignment1Test;

//TestCase for PrimeDiscount Strategy
[TestClass]
public class PrimeDiscountTest
{
    Discount? _applydiscount = null;

    [TestInitialize]
    public void Setup()
    {
        _applydiscount = new Discount(new PrimeDiscount());
    }

    [TestMethod]
    public void TestMethod1()
    {
        int price = 1100;

        double discounted_price = _applydiscount!.DiscountedPrice(price);

        Assert.AreEqual(770, discounted_price);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.ThrowsException<ArgumentException>(() => _applydiscount!.DiscountedPrice(-100));
    }

}
