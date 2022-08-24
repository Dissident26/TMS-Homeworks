namespace Homework_11.Classes
{
    internal class Employee
    {
        private string _name = String.Empty;
        private int _age;
        private double _salary;
        public string Name
        {
            get { return _name; }
            set {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("Invalid name! Name should be neither null, empty string, nor consist of more than 100 characters!");
                }
                _name = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set {
                if (!IsAgeValid(value))
                {
                    throw new ArgumentException();
                }
                _age = value;
            }
        }  
        public double Salary
        {
            get { return _salary; }
            set {
                if (!IsSalaryValid(value))
                {
                    throw new ArgumentException();
                }
                _salary = value;
            }
        }
        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        private bool IsNameValid(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            if (name.Length > 100)
            {
                throw new ArgumentException();
            }
            return true;
        }
        private bool IsAgeValid(int age)
        {
            return age > 0 && age >= 18;
        }
        private bool IsSalaryValid(double salary)
        {
            return salary > 0;
        }
    }
}
