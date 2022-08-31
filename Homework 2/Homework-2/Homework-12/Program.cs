using Homework_12.Classes;
using Newtonsoft.Json;

var ingridientsList1 = new List<Ingridient>
{
    new Ingridient("ind1", 2.5, 300.5, "manu-one"),
    new Ingridient("ind2", 3.5, 100.4, "manu-two"),
    new Ingridient("ind3", 4.5, 500.1, "manu-three")
};

var diet = new Diet("diet #1", "Author One", "ASD123", ingridientsList1);

var obj = JsonConvert.SerializeObject(diet, Formatting.Indented);

Console.WriteLine(obj);