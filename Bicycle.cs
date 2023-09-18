namespace Garageapplikation_Projektuppgift
{
    class Bicycle : Vehicle
    {
        public Bicycle(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats) : 
            base(registrationNumber, vehicleColor, vehicleWheels, vehicleSeats) {
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }

        public int Gears { get; set; }
        public int RimSize { get; set; }

        public override string ToString()
        {
            return $"\nBicycle\nMake : {Make} -  Model :  {Model} - Year : {Year}" +
                $" - Registration Number : {RegistrationNumber}\nColor: {Color}\nWheels: {Wheels}\nSeatingCapacity: {SeatingCapacity}\n" +
                $"Gears: {Gears}\nRimSize: {RimSize}";
        }
    }
}
