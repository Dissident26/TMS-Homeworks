namespace Homework_7.Classes
{
    public abstract class Medicine
    {
        public string ProductName { get; }
        public int ProductCost { get; }

        public Medicine(string name, int cost)
        {
            ProductName = name;
            ProductCost = cost;
        }

        public virtual void Print()
        {
            Console.WriteLine("Название препарата: {0}", ProductName);
            Console.WriteLine("Цена препарата: {0}", ProductCost);
        }
        public abstract void GetApplicationMethod();
    }
}
