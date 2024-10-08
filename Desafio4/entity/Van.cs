namespace Desafio4.entity;

public class Van(decimal currentLoadWeight) : Vehicle(currentLoadWeight)
{
    private const decimal maxCapacity = 2000m;

    public override decimal calculateCapacity()
    {
        return maxCapacity - loadWeight;
    }
}