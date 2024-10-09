namespace Desafio4.entity
{
    public abstract class Vehicle
    {
        private decimal LoadWeight { get; } //readonly
        private decimal MaxCapacity { get; } //readonly
        
        protected Vehicle(decimal loadWeight, decimal maxCapacity)
        {
            LoadWeight = loadWeight; 
            MaxCapacity = maxCapacity; 
        }

        public virtual decimal CalculateCapacity() // virtual nao pode ser sobrescrito
        {
            return MaxCapacity - LoadWeight;
        }
        
        public decimal loadWeight => LoadWeight; //accesss field private get
    }
}