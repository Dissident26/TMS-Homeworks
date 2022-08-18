using Homework_10.Classes;

var microwave1 = new Microwave("1");

microwave1.WarmUpCompleted += (string dishName) => Console.WriteLine($"Посетитель #1, Ваша еда готова: {dishName}");
microwave1.WarmUpCompleted += (string dishName) => Console.WriteLine($"Посетитель #2, Ваша еда готова: {dishName}");

microwave1.WarmUp("Пирожок");
