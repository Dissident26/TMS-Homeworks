using Homework_8.Interfaces;

namespace Homework_8.Classes
{
    internal class MotorBike : Vehicle, ITaxi
    {
        public string DriverName { get; set; }
        public string Color { get; set; }
        public MotorBike(int stateNumber, int fuelConsumption, string driverName, string color) : base(stateNumber, fuelConsumption)
        {
            DriverName = driverName;
            Color = color;
        }
        public double GetPriceOfRide()
        {
            return 25d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.LastName} совершил поездку на {Color} мотоцикл, водитель {DriverName}");
        }

        public override string ToString()
        {
            return $"{Color} мотоцикл. Водитель: {DriverName}";
        }
    }
}
