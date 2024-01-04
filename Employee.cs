using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    internal class Employee
    {
        public string Name { get; set; }
        private double Wage { get; set; }

        public Employee(string name, double wage)
        {
            Name = name;
            Wage = wage;
        }

        // Перевантаження оператора +
        public static Employee operator +(Employee employee, int amount)
        {
            employee.Wage += amount;
            return employee;
        }

        // Перевантаження оператора -
        public static Employee operator -(Employee employee, int amount)
        {
            employee.Wage -= amount;
            return employee;
        }

        // Перевантаження оператора ==
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Wage == employee2.Wage;
        }

        // Перевантаження оператора <
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Wage < employee2.Wage;
        }

        // Перевантаження оператора >
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Wage > employee2.Wage;
        }

        // Перевантаження оператора !=
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Перевизначення методу Equals
        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return Wage == other.Wage;
            }
            return false;
        }


    }
}
