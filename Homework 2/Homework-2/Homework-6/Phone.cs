namespace Homework_6
{
    public class Phone
    {
        public string Number { get; set; }
        public string Model { get; }
        public double Weight { get; }


        public Phone(string number, string model, double weight)
        {
            Number = number;
            Model = model;

            if(weight < 0)
            {
                Weight = 0;
                return;
            }
            Weight = weight;
        }

        public void RecieveCall(string callerName)
        {
            Console.WriteLine("Вам звонит {0}", callerName);
        }
    }
}