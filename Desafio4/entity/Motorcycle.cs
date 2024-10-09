namespace Desafio4.entity
{
    public class Motorcycle : Vehicle, CalculateCostI
    {
        private const decimal MaxCapacity = 100m;


        public Motorcycle(decimal loadWeight) : base(loadWeight, MaxCapacity)
        {
            if (loadWeight > MaxCapacity)
            {
                throw new ArgumentException("motorcycle cannot have more than max capacity");
            }
        }
        public decimal calculateTransport(decimal distance)
        {
            return (distance * 1.0m) + (LoadWeight * 0.05m);//use
        }
    }
}