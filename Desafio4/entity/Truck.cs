namespace Desafio4.entity
{
    public class Truck : Vehicle, CalculateCostI
    {
        private const decimal MaxCapacity = 10000m;
        
        public Truck(decimal loadWeight) : base(loadWeight, MaxCapacity)
        {
            if (loadWeight > MaxCapacity)
            {
                throw new ArgumentException("truck load weight cannot be greater than max capacity");
            }
        }
        public decimal calculateTransport(decimal distance)
        {
            return (distance * 5.0m) + (LoadWeight * 0.1m);
        }
    }
}