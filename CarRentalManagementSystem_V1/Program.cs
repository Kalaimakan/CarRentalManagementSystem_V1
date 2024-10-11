using System.Security.Cryptography.X509Certificates;

namespace CarRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();

            int option;
            do
            {
                Console.WriteLine("Car Rental Management System:");
                Console.WriteLine("1. Add a Car");
                Console.WriteLine("2. View All Cars");
                Console.WriteLine("3. Update a Car");
                Console.WriteLine("4. Delete a Car");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");
                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Car id :");
                        string car_id = Console.ReadLine();
                        Console.WriteLine("Enter Car Brand:");
                        string brand =Console.ReadLine();
                        Console.WriteLine("Enter Car model: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter Car rental price: ");
                        decimal rentalprice = carManager.ValidateCarRentalPrice();
                        Console.WriteLine("Car added successfully.");
                        Car cars = new Car(car_id, brand, model, rentalprice);
                        carManager.CreateCar(cars);
                        break;

                    case 2:
                        carManager.ReadCars();
                        break;

                    case 3:
                        Console.WriteLine("Enter the Car ID to update:");
                        string updatecar = Console.ReadLine();
                        carManager.UpdateCar(updatecar);
                        break;

                    case 4:
                        Console.WriteLine("Enter the Car ID to delete: ");
                        string deletecar=Console.ReadLine();
                        carManager.DeleteCar(deletecar);
                        break;

                    case 5:
                        Console.WriteLine("Sucessfully exit");
                        break;
                }

            }
            while (option !=5);
        }
    }
}
