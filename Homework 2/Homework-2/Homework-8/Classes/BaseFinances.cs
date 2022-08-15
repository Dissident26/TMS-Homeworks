using Homework_8.Interfaces;

namespace Homework_8.Classes
{
    internal class BaseFinances : IPaymentMethod
    {
        private double Balance
        { get; set; }

        public BaseFinances(double initBalance = 0)
        {
            Balance = initBalance;
        }
        public void AddMoney(double summ)
        {
            Balance += summ;
        }

        public bool IsPaymentPossible(double summ)
        {
            return Balance >= summ;
        }

        public void MakePayment(double summ)
        {
            Balance -= summ;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public override string ToString()
        {
            return Balance.ToString();
        }
    }
}
