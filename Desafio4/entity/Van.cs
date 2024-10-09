namespace Desafio4.entity
{
    public class Van : Vehicle
    {
        private const decimal MaxCapacity = 2000m;
        public Van(decimal loadWeight) : base(loadWeight, MaxCapacity)
        {
            if (loadWeight > MaxCapacity)
            {
                throw new ArgumentException("van cannot have more than max capacity");
            }
        }
    }
}