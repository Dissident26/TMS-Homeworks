namespace Homework_12.Classes
{
    public class Ingridient
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double EnergyCost { get; set; }
        public string Manufacturer { get; set; }

        public Ingridient(string name, double price, double energyCost, string manufacturer)
        {
            Name = name;
            Price = price;
            EnergyCost = energyCost;
            Manufacturer = manufacturer;
        }
    }
}
