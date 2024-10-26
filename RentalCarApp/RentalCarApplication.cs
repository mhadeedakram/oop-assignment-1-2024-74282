using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCarLibrary;

namespace RentalCarApp
{
    class RentalCarApplication
    {
        static void Main(string[] args)
        {
            RentalCar car1 = new RentalCar("Toyota", "Corolla", "Saloon", "ABC-123", 30.0);
            RentalCar car2 = new RentalCar("Honda", "Civic", "HatchBack", "XYZ-789", 35.0);
            RentalCar car3 = new RentalCar("BMW", "Z4", "Convertible");
            RentalCar car4 = new RentalCar("Nissan", "Juke", "Crossover", "DEF-456", 25.0, true);

            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();

            car1.Borrow();
            car2.Borrow();
            car4.Borrow();

            car2.ReturnRentalCar();
            car2.ChangePrice(40.0);

            Console.WriteLine($"Current price of {car2.Model}: {car2.CheckPrice():C}");
            Console.WriteLine($"{car3.Model} borrowed status: {car3.CheckBorrowed()}");
        }
    }
}
