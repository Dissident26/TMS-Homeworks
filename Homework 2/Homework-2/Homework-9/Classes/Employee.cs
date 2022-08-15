namespace Homework_9.Classes
{
    public delegate int GetSalary(Employee employee);
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkingExperience { get; set; }
        public bool HasHighEduacation { get; set; }

        public Employee(string name, int age, int workingExperience, bool hasHighEducation)
        {
            Name = name;
            Age = age;
            WorkingExperience = workingExperience;
            HasHighEduacation = hasHighEducation;
        }

       public static void GetSalary(List<Employee> employeesList)
        {
            foreach (var employee in employeesList)
            {
                var salaryModificator = employee.HasHighEduacation ? 1250 : 1000;
                var employeesSalary = (employee.WorkingExperience + 1) * salaryModificator;

                Console.WriteLine($"Работник: {employee.Name}, Зарплата: {employeesSalary} условных рублей");
            }
        }

        public static void GetSalary(List<Employee> employeesList, GetSalary getSalary)
        {
            foreach (var employee in employeesList)
            {
                var employeesSalary = getSalary(employee);

                Console.WriteLine($"Работник: {employee.Name}, Зарплата: {employeesSalary} условных рублей");
            }
        }
    }
}
