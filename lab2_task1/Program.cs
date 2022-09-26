using System;
using System.Net;

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
        public static void Main()
        {
            Adress my = new Adress();
            my.index = 55555;
            my.country = "Ukraine";
            my.city = "Kyiv";
            my.street = "Khreshchatyk";
            my.house = 25;
            my.apartment = 50;
            Console.WriteLine($"Index: {my.index}; Country: {my.country}; City: {my.city}; Street: {my.street}; House: {my.house}; Apartment: {my.apartment}");
        }
    }
}

