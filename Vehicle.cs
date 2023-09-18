namespace Garageapplikation_Projektuppgift
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int SeatingCapacity { get; set; }
        public int Wheels { get; set; }
        public enum VehicleType
        {
            Car,
            Bus,
            Bicycle,
            Motorcycle,
            Truck,
        }

        public VehicleType Type { get; set; }

        public Vehicle(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats)
        {
            RegistrationNumber = registrationNumber;
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }
    }
}
