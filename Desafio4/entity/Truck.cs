namespace Desafio4.entity
{
    public class Truck(decimal loadWeight) : Vehicle(loadWeight), CalculateCostI
    {
        private const decimal MaxCapacity = 10000m;

        public override decimal calculateCapacity()
        {
            return MaxCapacity - loadWeight;
        }
        
        public decimal calculateTransport(decimal distance)
        {
            return (distance * 5.0m) + (loadWeight * 0.1m);
        }
    }
}