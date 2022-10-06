using System;
namespace Homework_7_1_Address
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Bldg { get; set; }
        public string Apt { get; set; }
        public string Zip { get; set; }

        public void getAddress()
        {
            Console.WriteLine($"Country: {Country}\nCity: {City}\n" +
                $"Address: {Bldg}, {Street}\nApartment No: {Apt}\nZip code: {Zip} ");
        }
    }
}

