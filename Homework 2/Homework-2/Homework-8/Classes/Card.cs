namespace Homework_8.Classes
{
    internal class Card : BaseFinances
    {
        public int CardNumber { get; }
        public Card(int cardNumber, double initBalance) : base(initBalance)
        {
            CardNumber = cardNumber;
        }
    }
}
