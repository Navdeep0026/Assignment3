using System;
using System.Collections.Generic;

namespace VehicleRentalManagementSystem
{
    public class RentalAgency
    {
        private List<Vehicle> Fleet { get; set; }
        public decimal TotalRevenue { get; private set; }

        public RentalAgency()
        {
            Fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Fleet.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            Fleet.Remove(vehicle);
        }

        public void RentVehicle(Vehicle vehicle)
        {
            if (Fleet.Contains(vehicle))
            {
                Fleet.Remove(vehicle);
                TotalRevenue += vehicle.RentalPrice;
                Console.WriteLine($"{vehicle.Model} has been rented.");
            }
            else
            {
                Console.WriteLine($"{vehicle.Model} is not available for rent.");
            }
        }

        public void DisplayFleet()
        {
            Console.WriteLine("Fleet details:");
            foreach (var vehicle in Fleet)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
