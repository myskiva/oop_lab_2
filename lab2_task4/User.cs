using System;
using System.Net;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            User one = new User();
            one.Login = "arsen_myskiv";
            one.Name = "Arsen";
            one.Surname = "Myskiv";
            one.Age = 18;

            one.Print();
        }
    }
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        protected static readonly DateTime fillingDate;

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        static User()
        {
            fillingDate = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"Login: {login}; Name: {name}; Surname: {surname}; Age: {age}; date of filling out the questionnaire: {fillingDate}");
        }
    }
}

