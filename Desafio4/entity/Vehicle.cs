namespace Desafio4.entity
{
    public abstract class Vehicle(decimal loadWeight)
    {
        protected decimal loadWeight = loadWeight;

        public abstract decimal calculateCapacity();
        
    }
}