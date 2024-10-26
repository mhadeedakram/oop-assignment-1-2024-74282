using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarLibrary
{
    public class RentalCar
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string RegistrationNumber { get; set; }
        public double Price { get; set; }
        public bool Borrowed { get; private set; }

        public RentalCar(string manufacturer, string model, string bodyType,
                         string registrationNumber, double price, bool borrowed)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        public RentalCar(string manufacturer, string model, string bodyType,
                         string registrationNumber, double price)
            : this(manufacturer, model, bodyType, registrationNumber, price, false) { }

        public RentalCar(string manufacturer, string model, string bodyType)
            : this(manufacturer, model, bodyType, "N/A", 0.0, false) { }

        public void Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine($"{Model} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Error: {Model} is already on loan.");
            }
        }

        public void ReturnRentalCar()
        {
            Borrowed = false;
            Console.WriteLine($"{Model} has been returned.");
        }

        public void ChangePrice(double price)
        {
            Price = price;
            Console.WriteLine($"Price updated to {Price:C}.");
        }

        public double CheckPrice() => Price;
        public bool CheckBorrowed() => Borrowed;

        public void Display()
        {
            Console.WriteLine("");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Borrowed: {(Borrowed ? "Yes" : "No")}");
            Console.WriteLine("\n");
        }
    }
}
