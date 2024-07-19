using System;

namespace VehicleRentalManagementSystem
{
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
            : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four-Wheel Drive: {FourWheelDrive}");
        }
    }
}
