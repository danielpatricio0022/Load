namespace Desafio4.entity;

public abstract class Vehicle(decimal loadWeight, decimal maxCapacity)//primary constructor
{
    private decimal loadWeight { get;} = loadWeight; //readonly
    private decimal maxCapacity{ get;} = maxCapacity; //readonly


    public virtual decimal calculateCapacity() //virtual nâo precisa ser sobrescrito
    {
        return maxCapacity - loadWeight;
    }

    public decimal MaxCapacity => maxCapacity; //access field private get
    public decimal LoadWeight => loadWeight; //accesss field private get
}