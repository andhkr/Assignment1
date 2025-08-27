// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using DiscountStrategy;
using Executive;

namespace Assignment1Test;

// Testcase for FestivalDiscount Strategy
[TestClass]
public class FestivalDiscountTest
{
    Discount? _applydiscount = null;

    [TestInitialize]
    public void Setup()
    {
        _applydiscount = new Discount(new FestivalDiscount());
    }

    [TestMethod]
    public void TestMethod1()
    {
        int price = 1000;

        double discounted_price = _applydiscount!.DiscountedPrice(price);

        Assert.AreEqual(820, discounted_price);
    }

    [TestMethod]
    public void TestMethod2()
    {
        int price = 90;

        double dicounted_price = _applydiscount!.DiscountedPrice(price);

        Assert.AreEqual(90, dicounted_price);
    }
}
