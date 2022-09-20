class Adress
{
    public int index = "Undefined";
    public string country = "Undefined";
    public string city = "Undefined";
    public string street = "Undefined";
    public int house = "Undefined";
    public int apartment = "Undefined";

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
Console.WriteLine($"Index: {indeAdressx} Country: {countryAdress} City: {cityAdress} Street: {streetAdress} House: {houseAdress} Apartment: {apartmentAdress}");
my.index = 55555;
my.country = "Ukraine";
my.city = "Kyiv";
my.street = "Khreshchatyk";
my.house = 25;
my.apartment = 50;