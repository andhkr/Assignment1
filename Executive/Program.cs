using DiscountStrategy;

namespace Executive
{

    public class Discount
    {
        IDiscountStrategy _strategy;

        public Discount(IDiscountStrategy obj)
        {
            _strategy = obj;
        }

        public double DiscountedPrice(double price)
        {
            return Math.Max(0,price - _strategy.Apply(price));
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            //FestivalDiscount
            Discount Festive = new Discount(new FestivalDiscount());
            Console.WriteLine($"Festival Discount Price : {Festive.DiscountedPrice(1000)}");

            //PrimeDiscount
            Discount Prime = new Discount(new PrimeDiscount());
            Console.WriteLine($"Prime Discount Price : {Prime.DiscountedPrice(1000)}");

            //EventDiscount
            Discount Event = new Discount(new EventDiscount());
            Console.WriteLine($"Event Discount Price : {Event.DiscountedPrice(1000)}");
        }
    }
}
