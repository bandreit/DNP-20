namespace S2_Ex1
{
    public abstract class Employee
    {
        public string Name;

        protected Employee(string name)
        {
            Name = name;
        }

        public abstract double GetMonthlySalary();
    }
}