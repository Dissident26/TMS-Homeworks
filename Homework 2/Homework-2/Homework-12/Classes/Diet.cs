namespace Homework_12.Classes
{
    public class Diet
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Code { get; set; }
        public List<Ingridient> Ingridients { get; set; }

        public Diet(string name, string author, string code, List<Ingridient> ingridients)
        {
            Name = name;
            Author = author;
            Code = code;
            Ingridients = ingridients;
        }
    }
}
