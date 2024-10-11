using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class Car
    {
        private string carId;
        private string brand;
        private string model;
        private decimal rentalPrice;

        public Car(string CarId, string Brand, string Model, decimal RentalPrice)
        {
            carId = CarId;
            brand = Brand;
            model = Model;
            rentalPrice = RentalPrice;
        }

        public virtual string ToString()
        {
            return $"Id:{carId},Brand:{brand},Model:{model},RentalPrice:{rentalPrice}";
        }
    }
}
