using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementSystem_V1
{
    public class CarManager
    {
        public List<Car> cars=new List<Car>();

        public void CreateCar(Car car) 
        {
            cars.Add(car);
            Console.WriteLine("Car added successfully");
        }

        public void ReadCars()
        {
            Console.WriteLine("List of Cars :");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void UpdateCar(string id)
        {
            var car = cars.FirstOrDefault(c => c.carId == id);
            Console.WriteLine("Enter new Brand");
            car.brand = Console.ReadLine();
            Console.WriteLine("Enter new Model");
            car.model = Console.ReadLine();
            Console.WriteLine("Enter new rental Price");
            car.rentalPrice =decimal.Parse(Console.ReadLine());
            Console.WriteLine("Car updated successfully.");
        }

        public void DeleteCar(string id)
        {
            var car=cars.FirstOrDefault(c => c.carId==id);
            cars.Remove(car);
            Console.WriteLine("Car deleted successfully");
        }
    }
}
