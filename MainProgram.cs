using System;

namespace VehicleRentalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalAgency agency = new RentalAgency();

            Car car = new Car("Model S", "Tesla", 2020, 200, 5, "Electric", "Automatic", true);
            Truck truck = new Truck("F-150", "Ford", 2019, 150, 1000, "Pickup", true);
            Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 100, 650, "Petrol", true);

            agency.AddVehicle(car);
            agency.AddVehicle(truck);
            agency.AddVehicle(motorcycle);

            agency.DisplayFleet();

            agency.RentVehicle(car);
            agency.DisplayFleet();

            Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
        }
    }
}
