using Homework_8.Interfaces;

namespace Homework_8.Classes
{
    internal class Points : IPaymentMethod
    {
        private double _exchangeRate;
        private double Balance { get; set; }

        public Points(double exchangeRate, double initBalance = 1500d)
        {
            _exchangeRate = exchangeRate;
            Balance = initBalance;
        }
        public void AddMoney(double summ)
        {
            Balance += summ;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public bool IsPaymentPossible(double summ)
        {
            return Balance >= summ * _exchangeRate;
        }

        public void MakePayment(double summ)
        {
            Balance -= summ * _exchangeRate;
        }
        public override string ToString()
        {
            return Balance.ToString();
        }
    }
}
