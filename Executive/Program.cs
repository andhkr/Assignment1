using DiscountStrategy;

namespace Executive;

public class Discount
{
    IDiscountStrategy _strategy;

    public Discount(IDiscountStrategy obj)
    {
        _strategy = obj;
    }

    public double DiscountedPrice(double price)
    {
        if (price < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }

        return price - _strategy.Apply(price);
    }

}

public class Program
{
    static void Main()
    {
        //FestivalDiscount
        Discount festive = new Discount(new FestivalDiscount());
        Console.WriteLine($"Festival Discount Price : {festive.DiscountedPrice(1000)}");

        //PrimeDiscount
        Discount prime = new Discount(new PrimeDiscount());
        Console.WriteLine($"Prime Discount Price : {prime.DiscountedPrice(1000)}");

        //EventDiscount
        Discount @event = new Discount(new EventDiscount());
        Console.WriteLine($"Event Discount Price : {@event.DiscountedPrice(1000)}");
    }
}
