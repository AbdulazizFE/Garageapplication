namespace Garageapplikation_Projektuppgift
{
    public class Bus : Vehicle
    {
        public Bus(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats) :
            base(registrationNumber, vehicleColor, vehicleWheels, vehicleSeats)
        {
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }

        public int Doors { get; set; }
        public string LoadCapacity { get; set; }

        public override string ToString()
        {
            return $"\nBus\nMake : {Make} -  Model :  {Model} - Year : {Year}" +
                $" - Registration Number : {RegistrationNumber}\nColor: {Color}\nWheels: {Wheels}\nSeatingCapacity: {SeatingCapacity}\n" +
                $"LoadCapacity: {LoadCapacity}\nDoors: {Doors}";
        }
    }
}
