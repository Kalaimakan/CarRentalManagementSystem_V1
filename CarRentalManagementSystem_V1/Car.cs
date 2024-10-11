using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class Car
    {
        public string carId;
        public string brand;
        public string model;
        public decimal rentalPrice;

        public Car(string CarId, string Brand, string Model, decimal RentalPrice)
        {
            carId = CarId;
            brand = Brand;
            model = Model;
            rentalPrice = RentalPrice;
        }

        public override string ToString()
        {
            return $"Id:{carId},Brand:{brand},Model:{model},RentalPrice:{rentalPrice}";
        }

        
    }
}
