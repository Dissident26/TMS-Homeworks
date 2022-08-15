namespace Homework_8.Classes
{
    internal class Vehicle
    {
        public int StateNumber { get; }
        public int FuelConsumption { get; set; }

        public Vehicle(int stateNumber, int fuelConsumption)
        {
            StateNumber = stateNumber;
            FuelConsumption = fuelConsumption;
        }
    }
}
