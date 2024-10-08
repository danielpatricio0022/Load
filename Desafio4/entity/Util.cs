namespace Desafio4.entity
{
    public static class Util
    {
        public static void PrintCapacity(Vehicle vehicle)
        {
            decimal availableCapacity = vehicle.calculateCapacity();
            Console.WriteLine($"{vehicle.GetType().Name.ToLower()} tem capacidade  de {availableCapacity} kg");
        }

        public static void PrintTransportCost(CalculateCostI vehicle, decimal distance)
        {
            decimal cost = vehicle.calculateTransport(distance);
            Console.WriteLine($"O custo para transporte por {vehicle.GetType().Name.ToLower()} é R$ {cost:F2}.");
        }
    }
}