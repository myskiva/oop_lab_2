using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace task1
{
    class Adress
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get 
            { 
                return index; 
            }
            set
            {
                index = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Index: {index} Country: {country} City: {city} Street: {street} House: {house} Apartment: {apartment}");
        }
    }

    my Adress = new Adress();
    int indexAdress = my.index;
    string countryAdress = my.country;
    string cityAdress = my.city;
    string streetAdress = my.street;
    int houseAdress = my.house;
    int apartmentAdress = my.apartment;
    Console.WriteLine($"Index: {indexAdress} Country: {countryAdress} City: {cityAdress} Street: {streetAdress} House: {houseAdress} Apartment: {apartmentAdress}");
my.index = 55555;
my.country = "Ukraine";
my.city = "Kyiv";
my.street = "Khreshchatyk";
my.house = 25;
my.apartment = 50;
}