using Homework_8.Classes;
using Homework_8.Interfaces;

var user1 = new User("Даздранагон", "Бедросович", 2020327, 100);

List<ITaxi> vehicleList = new()
{
    new Car(0327, 9, "Володя", "Черный"),
    new MotorBike(3321, 5, "Мишаня", "Красный"),
    new Helicopter(9999, 19, "Петюня", "Боевой"),
};
Menu(user1, vehicleList);
void Menu(User user, List<ITaxi> vehicleList)
{
    MenuItem? consoleInput = null;

    while (consoleInput != MenuItem.End)
    {
        Console.WriteLine(@"
    Выберите действие: 
        1) Добавить карту.
        2) Пополнить карту.
        3) Совершить поездку.
        9) Закончить работу программы.
        ");

        consoleInput = (MenuItem)ReadIntFromConsole();

        switch (consoleInput)
        {
            case MenuItem.AddCard: AddCard(user);
                break;
            case MenuItem.TopUpCardByName: TopUpCardByName(user);
                break;
            case MenuItem.GetARideByVehicleIndex:
                GetARideByVehicleIndex(user, vehicleList);
                break;
            case MenuItem.End: return;
            default: Console.WriteLine("Invalid Input!");
                break;
        }
    }
}

void GetARideByVehicleIndex(User user, List<ITaxi> vehicleList)
{
    GetVehicleListIndexesView(vehicleList);
    int vehicleIndexConsoleInput = ReadIntFromConsole();
    user.ShowAvailablePaymentMethods();
    var selectedVehicle = vehicleList[vehicleIndexConsoleInput];

    Console.WriteLine("Введите выбраный способ оплаты: ");
    string selectedPaymentMethodKey = Console.ReadLine();
    bool isPaymentSUccessfull = user.Pay(selectedPaymentMethodKey, selectedVehicle.GetPriceOfRide());

    if (isPaymentSUccessfull)
    {
        selectedVehicle.MakeRide(user);
    }
}
void GetVehicleListIndexesView(List<ITaxi> vehicleList)
{
    Console.WriteLine("Выберете транспортное средство: ");
    for (int i = 0; i < vehicleList.Count; i++)
    {
        Console.WriteLine($"#{i} >>> {vehicleList[i]}");
    }
}
void TopUpCardByName(User user)
{
    Console.WriteLine("Введите имя карты: ");
    string cardName = Console.ReadLine();
    Console.WriteLine("Введите сумму пополнения: ");
    int summ = ReadIntFromConsole();
    user.TopUpCard(cardName, summ);
}
void AddCard(User user)
{
    Console.WriteLine("Введите имя карты: ");
    string cardName = Console.ReadLine();
    Console.WriteLine("Введите номер карты: ");
    int cardNumber = ReadIntFromConsole();
    Console.WriteLine("Введите изначальный баланс карты: ");
    int summ = ReadIntFromConsole();
    Card card = new(cardNumber, summ);
    
    user.AddCard(cardName, card);
};
int ReadIntFromConsole()
{
    string? input = Console.ReadLine();
    bool isNumberValid = int.TryParse(input, out int number);

    if (!isNumberValid)
    {
        throw new Exception("Invalid Number Entered!");
    }

    return number;
}
enum MenuItem
{
    AddCard = 1,
    TopUpCardByName = 2,
    GetARideByVehicleIndex = 3,
    End = 9,
}