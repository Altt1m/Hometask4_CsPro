using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Task 1
            Employee employee1 = new Employee("John", 50000);
            Employee employee2 = new Employee("Jane", 60000);

            employee1 += 5000; // Збільшення зарплати
            employee2 -= 2000; // Зменшення зарплати

            // Порівняння зарплат
            if (employee1 == employee2)
            {
                Console.WriteLine("Зарплати співробітників рівні.");
            }
            else if (employee1 > employee2)
            {
                Console.WriteLine($"{employee1.Name}'s зарплата більша за {employee2.Name}'s зарплату.");
            }
            else
            {
                Console.WriteLine($"{employee1.Name}'s зарплата менша за {employee2.Name}'s зарплату.");
            }


            // Task 2
            Town town1 = new Town("Abc", 10000);
            Town town2 = new Town("Def", 15000);

            town1 += 3000;
            town2 -= 4500;

            if (town1 == town2)
            {
                Console.WriteLine("Населення міст однакове.");
            }
            else if (town1 > town2)
            {
                Console.WriteLine($"Населення міста {town1.Name} більше за населення міста {town2.Name}");
            }
            else
            {
                Console.WriteLine($"Населення міста {town1.Name} менше за населення міста {town2.Name}");
            }


            // Task 3
            CreditCard card1 = new CreditCard("0123 4567 8901 2345", 123, 123.456789m);
            CreditCard card2 = new CreditCard("9876 5432 1098 7654", 321, 987.654321m);

            card1 += 20;
            card2 -= 50;

            if (card1 == card2)
            {
                Console.WriteLine("CVC карток однакові");
            }
            else
            {
                Console.WriteLine("CVC карток НЕ однакові");
            }

            if (card1 > card2)
            {
                Console.WriteLine("На першій картці більше бабла");
            }
            else
            {
                Console.WriteLine("На першій картці менше бабла");
            }
        }
    }
}
