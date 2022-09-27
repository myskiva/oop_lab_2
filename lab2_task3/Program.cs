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
        public static void Main()
        {
            Employee tom = new Employee("Tom", "Johnson");
            tom.firstName = "Tom";
            tom.lastName = "Johnson";
            Console.WriteLine($"Name: {tom.firstName}; Surname: {tom.lastName}");

            Console.WriteLine($"Enter your post (Choose number: Junior - 1, Middle - 2, Senior - 3): ");
            tom.post = int.Parse(Console.ReadLine());
            if (tom.post == 1)
            {
                tom.salary = 700;
            }
            else if (tom.post == 2)
            {
                tom.salary = 1000;
            }
            else if (tom.post == 3)
            {
                tom.salary = 1500;
            }

            Console.WriteLine($"Enter your experience: ");
            tom.experience = int.Parse(Console.ReadLine());
            if (tom.experience > 0 && tom.experience <= 2)
            {
                tom.exp = 1;
            }
            else if (tom.experience > 2 && tom.experience <= 5)
            {
                tom.exp = 2;
            }
            else if (tom.experience > 5)
            {
                tom.exp = 3;
            }

            Console.WriteLine("Your wage is: " + tom.salary * tom.exp + "; Tax collection: " + (tom.salary * tom.exp) / 100 * 22);
        }
    }
}
