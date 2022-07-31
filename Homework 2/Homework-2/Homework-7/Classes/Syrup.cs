namespace Homework_7.Classes
{
    internal class Syrup : Medicine
    {
        public string Taste { get; }
        public Syrup(string name, int cost, string taste) : base(name, cost)
        {
            Taste = taste;
        }

        public override void GetApplicationMethod()
        {
            Console.WriteLine("Способ применения: чайную ложку перед сном");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Вкус: {0}", Taste);
        }
    }
}
