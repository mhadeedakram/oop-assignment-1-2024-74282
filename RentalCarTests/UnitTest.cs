using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarLibrary;

namespace RentalCarTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Borrow_ShouldSetBorrowedToTrue()
        {
            var car = new RentalCar("Toyota", "Corolla", "Saloon");
            car.Borrow();
            //Assert.True(car.CheckBorrowed());
        }
    }
}
