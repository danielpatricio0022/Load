namespace Desafio4.entity;

public class Motorcycle(decimal loadWeight) : Vehicle(loadWeight), CalculateCostI
{
    private const decimal maxCapacity = 100m;

    public override decimal calculateCapacity()
    {
        return maxCapacity - loadWeight;
    }

    public decimal calculateTransport(decimal distance)
    {
        return (distance * 1.0m) + (loadWeight * 0.05m);
    }
}