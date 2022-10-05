﻿using System;
using System.Net;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress my = new Adress();
            my.Index = 55555;
            my.Country = "Ukraine";
            my.City = "Kyiv";
            my.Street = "Khreshchatyk";
            my.House = 25;
            my.Apartment = 50;
            my.Print();
        }
    }
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
            Console.WriteLine($"Index: {index}; Country: {country}; City: {city}; Street: {street}; House: {house}; Apartment: {apartment}");
        }
    }
}

