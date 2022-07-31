namespace Homework_7.Classes
{
    internal class Salve : Medicine
    {
        public int Volume { get; }
        public Salve(string name, int cost, int volume) : base(name, cost)
        {
            Volume = volume;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Обьем: {0} мл.", Volume);
        }
        public override void GetApplicationMethod()
        {
            Console.WriteLine("Способ применения: Нанесите тонким слоем на кожу");
        }
    }
}
