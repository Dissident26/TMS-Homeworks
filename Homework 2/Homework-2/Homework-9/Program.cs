using Homework_9.Classes;

List<Employee> employeesList = new()
{
    new Employee("Алёша", 20, 2, false),
    new Employee("Боря", 30, 5, true),
    new Employee("Вован", 28, 4, false),
    new Employee("Гришан", 32, 8, true),
    new Employee("Димон", 19, 1, false),
};

Console.WriteLine("**** Перерасчёт дифолт ****");

Employee.GetSalary(employeesList);

Console.WriteLine("**** Перерасчёт с делегатом ****");

Employee.GetSalary(employeesList, GetSalary);

Console.WriteLine("**** Перерасчёт с лямбдой ****");

Employee.GetSalary(employeesList, (Employee employee) =>
{
    var salaryModificator = employee.HasHighEduacation ? 1500 : 1000;
    var experienceModificator = 1 + employee.WorkingExperience * 0.1;
    var employeesSalary = (employee.WorkingExperience + experienceModificator) * salaryModificator;

    return (int)employeesSalary;
});

static int GetSalary(Employee employee)
{
    return employee.WorkingExperience * 1000;
};