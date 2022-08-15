using Homework_8.Interfaces;

namespace Homework_8.Classes
{
    internal class User
    {
        const string CASH_METHOD_KEY = "Cash";
        const string POINTS_METHOD_KEY = "Points";
        public string Name { get; }
        public string LastName { get; }
        public int PhoneNumber { get; set; }

        private Dictionary<string, IPaymentMethod> paymentMethods = new()
        {
            { POINTS_METHOD_KEY, new Points(3) }
        };

        public User(string name, string lastName, int phoneNumber, double initCash)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            paymentMethods.Add(CASH_METHOD_KEY, new Cash(initCash));
        }

        public void TopUpCash(double summ)
        {
            paymentMethods[CASH_METHOD_KEY].AddMoney(summ);
        }

        public void TopUpCard(string cardName, double summ)
        {
            var isCardExists = paymentMethods.TryGetValue(cardName, out var card);
            if (!isCardExists)
            {
                Console.WriteLine($"Card {cardName} not found!");
                return;
            }

            card.AddMoney(summ);
        }

        public void AddCard(string cardName, Card card)
        {
            var isCardExists = paymentMethods.TryAdd(cardName, card);
            if (!isCardExists)
            {
                Console.WriteLine($"Card {cardName} already added!");
                return;
            }
        }

        public void ShowAvailablePaymentMethods()
        {
            Console.WriteLine("Available payment methods: ");
            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine($"{paymentMethod.Key} : {paymentMethod.Value?.ToString()};");
            }
        }

        public bool Pay(string paymentMethodKey, double summ)
        {
            var paymentMethodExists = paymentMethods.TryGetValue(paymentMethodKey, out var paymentMethod);

            if (!paymentMethodExists)
            {
                Console.WriteLine($"Payment method {paymentMethodKey} does not exist!");
                return false;
            }
            if (!paymentMethod.IsPaymentPossible(summ))
            {
                Console.WriteLine($"Insufficient funds on {paymentMethodKey}!");
                Console.WriteLine($"Operation summ: {summ}, funds available: {paymentMethod.GetBalance()}");
                return false;
            }
            
            paymentMethod.MakePayment(summ);
            paymentMethods[POINTS_METHOD_KEY].AddMoney(5);
            Console.WriteLine("Operation successfull!");
            Console.WriteLine($"PaymentMethod: {paymentMethodKey}");
            Console.WriteLine($"Balance: {paymentMethod.GetBalance()}");
            return true;
        }
    }
}