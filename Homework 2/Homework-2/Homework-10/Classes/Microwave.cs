namespace Homework_10.Classes
{
    public delegate void NotifyWarmUpCompleted(string dishName);
    internal class Microwave
    {
        public event NotifyWarmUpCompleted? WarmUpCompleted;
        public string Name { get; set; }
        public Microwave(string name)
        {
            Name = name;
        }

        public void WarmUp(string dishName)
        {
            Console.WriteLine($"Подогреваю {dishName}");
            WarmUpCompleted?.Invoke(dishName);
        }
    }
}
