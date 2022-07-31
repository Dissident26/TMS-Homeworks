using Homework_7.Classes;

Medicine[] medicineArray = new Medicine[] 
{ 
    new Pill("Рандомные колёса #1", 20, 100),
    new Pill("Рандомные колёса #2", 100, 20),
    new Salve("Рандомная мазь #1", 15, 250),
    new Salve("Рандомная мазь #2", 200, 250),
    new Syrup("Рандомный сироп #1", 75, "сладкий"),
    new Syrup("Рандомный сироп #2", 35, "горький"),
};

foreach (var medicine in medicineArray)
{
    medicine.Print();
    medicine.GetApplicationMethod();
    Console.WriteLine();
}