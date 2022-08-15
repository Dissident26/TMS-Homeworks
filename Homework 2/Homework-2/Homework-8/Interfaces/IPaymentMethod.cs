namespace Homework_8.Interfaces
{
    internal interface IPaymentMethod
    {
        public bool IsPaymentPossible(double summ);
        public void MakePayment(double summ);
        public void AddMoney(double summ);
        public double GetBalance();
    }
}
