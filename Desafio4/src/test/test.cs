using Desafio4.entity;

namespace Desafio4.test;

public class test
{
    static void Main(string[] args)
    {
        Truck truck = new Truck(2000m);
        Van van = new Van(100m);
        Motorcycle motorcycle = new Motorcycle(50m);
            

        Util.PrintCapacity(truck);
        Util.PrintCapacity(van);
        Util.PrintCapacity(motorcycle);
        Console.WriteLine();
        Util.PrintTransportCost( truck, 100);
        Util.PrintTransportCost(motorcycle, 10);
    }
}