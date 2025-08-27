namespace DiscountStrategy;

//interface for different Discount Strategy
public interface IDiscountStrategy
{
    public double Apply(double amount);
}
