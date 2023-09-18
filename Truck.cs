namespace Garageapplikation_Projektuppgift
{
    class Truck : Vehicle
    {
        public Truck(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats) : 
            base(registrationNumber, vehicleColor, vehicleWheels, vehicleSeats) {
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }

        public string TowingCapacity { get; set; }
        public string Torque { get; set; }

        public override string ToString()
        {
            return $"\nTruck\nMake : {Make} -  Model :  {Model} - Year : {Year}" +
                $" - Registration Number : {RegistrationNumber}\nColor: {Color}\nWheels: {Wheels}\nSeatingCapacity: {SeatingCapacity}\n" +
                $"TowingCapacity: {TowingCapacity}\nTorque: {Torque}";
        }
    }
}
