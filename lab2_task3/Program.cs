using System;
using System.Net;

namespace task3
{
    class Employee
    {
        public string firstName;
        public string lastName;
        double wage; /*зарплата*/
        int salary; /*оклад*/
        int experience; /*стаж*/
        int exp; /*коефіцієнт стажу*/
        int post; /*посада*/
        double tax; /*податковий збір*/

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public double Wage()
        {
            if (post == 1)
            {
                salary = 700;
            }
            else if (post == 2)
            {
                salary = 1000;
            }
            else if (post == 3)
            {
                salary = 1500;
            }

            if (experience > 0 || experience <= 2)
            {
                exp = 1;
            }
            else if (experience > 2 || experience <= 5)
            {
                exp = 2;
            }
            else if (experience > 5)
            {
                exp = 3;
            }

            wage = salary * exp;
            return wage;
        }

        public double Tax()
        {
            tax = wage / 100 * 22;
            return tax;
        }

        public static void Main()
        {
            Employee tom = new Employee("Tom", "Johnson");
            tom.firstName = "Tom";
            tom.lastName = "Johnson";
            Console.WriteLine($"Name: {tom.firstName}; Surname: {tom.lastName}");

            Console.WriteLine($"Enter your post (Choose number: Junior - 1, Middle - 2, Senior - 3): ");
            tom.post = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your experience: ");
            tom.experience = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your wage is: {tom.wage}; Tax collection is: {tom.tax}");
        }
    }
}
