namespace Homework_7.Classes
{
    internal class Pill : Medicine
    {
        public int AmountInPack { get; }
        public Pill(string name, int cost, int amountInPack) : base(name, cost)
        {
            AmountInPack = amountInPack;
        }

        public override void GetApplicationMethod()
        {
            Console.WriteLine("Способ применения: пей таблетки дед!");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Штук в упаковке: {0}", AmountInPack);
        }
    }
}
