using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Converter
    {
        private double uah;
        private double usd;
        private double eur;
        private double rub;
        public double Uah
        {
            set
            {
                uah = value;
            }
            get
            {
                return uah;
            }
        }
        public double Usd
        {
            set
            {
                usd = value;
            }
            get
            {
                return usd;
            }
        }
        public double Eur
        {
            set
            {
                eur = value;
            }
            get
            {
                return eur;
            }
        }
        public double Rub
        {
            set
            {
                rub = value;
            }
            get
            {
                return rub;
            }
        }
        public static void Main()
        {
            Converter converter = new Converter();
            double usd = 0.027;
            double eur = 0.028;
            double rub = 1.59;
            Console.WriteLine("Choose the currency (uah, usd, eur, rub)");
            string userInput = Console.ReadLine();
            if (userInput == "uah")
            {
                Console.WriteLine("Enter the amount in UAH");
                converter.uah = double.Parse(Console.ReadLine());
                Console.WriteLine(converter.uah + " UAH - " + converter.uah * usd + " dollars");
                Console.WriteLine(converter.uah + " UAH - " + converter.uah * eur + " euros");
                Console.WriteLine(converter.uah + " UAH - " + converter.uah * rub + " rubles");
            }
            else if (userInput == "usd")
            {
                Console.WriteLine("Enter the amount in USD");
                converter.usd = double.Parse(Console.ReadLine());
                Console.WriteLine(converter.usd + " USD - " + converter.usd / usd + " hryvnias");
                Console.WriteLine(converter.usd + " USD - " + converter.usd * 1.03 + " euros");
                Console.WriteLine(converter.usd + " USD - " + converter.usd * 57.96 + " rubles");
            }
            else if (userInput == "eur")
            {
                Console.WriteLine("Enter the amount in EUR");
                converter.eur = double.Parse(Console.ReadLine());
                Console.WriteLine(converter.eur + " EUR - " + converter.eur / eur + " hryvnias");
                Console.WriteLine(converter.eur + " EUR - " + converter.eur * 0.97 + " dollars");
                Console.WriteLine(converter.eur + " EUR - " + converter.eur * 56.15 + " rubles");
            }
            else if (userInput == "rub")
            {
                Console.WriteLine("Enter the amount in RUB");
                converter.rub = double.Parse(Console.ReadLine());
                Console.WriteLine(converter.rub + " RUB - " + converter.rub / rub + " hryvnias");
                Console.WriteLine(converter.rub + " RUB - " + converter.rub * 0.017 + " dollars");
                Console.WriteLine(converter.rub + " RUB - " + converter.rub * 0.018 + " euros");
            }
        }
    }
}

