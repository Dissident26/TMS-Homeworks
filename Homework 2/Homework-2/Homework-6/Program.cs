using Homework_6;

Phone[] phoneArray = new Phone[]
{
    new("123321", "Motorolla", 200d),
    new("326234", "Nokia", 200d),
    new("6796796", "Siemens", -100d),
    new("4757", "Sony", -200d)
};

foreach (var phone in phoneArray)
{
    Console.WriteLine(@"
        Номер телефона: {0};
        Модель: {1};
        Вес: {2} гр.;
", phone.Number, phone.Model, phone.Weight);

    phone.RecieveCall("Президент");
}