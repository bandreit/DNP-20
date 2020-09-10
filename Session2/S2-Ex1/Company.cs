using System;
using System.Collections.Generic;

namespace S2_Ex1
{
    public class Company
    {
        public List<Employee> ListOfEmployees;

        public Company()
        {
            ListOfEmployees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal()
        {
            double salaryTotal = 0;
            ListOfEmployees.ForEach(emp => salaryTotal += emp.GetMonthlySalary());
            return salaryTotal;
        }

        public void HireNewEmployee(Employee emp)
        {
            ListOfEmployees.Add(emp);
        }
        
        static void Main(string[] args)
        {
            Company company = new Company();

            company.HireNewEmployee(new PartTimeEmployee("Edvinas", 120, 45));
            company.HireNewEmployee(new PartTimeEmployee("Sabina", 300, 15));
            company.HireNewEmployee(new FullTimeEmployee("Mirka", 25000));
;
            Console.Out.WriteLine(company.GetMonthlySalaryTotal());
        }
    }
}