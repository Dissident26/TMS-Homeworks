using Homework_8.Interfaces;

namespace Homework_8.Classes
{
    internal class Helicopter : Vehicle, ITaxi
    {
        public string PilotName { get; set; }
        public string Color { get; set; }
        public Helicopter(int stateNumber, int fuelConsumption, string pilotName, string color) : base(stateNumber, fuelConsumption)
        {
            PilotName = pilotName;
            Color = color;
        }
        public double GetPriceOfRide()
        {
            return 500d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"{user.Name} {user.LastName} совершил поездку на {Color} вертолет, пилот {PilotName}");
        }

        public override string ToString()
        {
            return $"{Color} вертолет. Пилот: {PilotName}";
        }
    }
}
