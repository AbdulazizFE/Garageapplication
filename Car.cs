namespace Garageapplikation_Projektuppgift
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats) : 
            base(registrationNumber, vehicleColor, vehicleWheels, vehicleSeats) {
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }

        public string GasMilage { get; set; }
        public string FuelType { get; set; }

        public override string ToString()
        {
            return $"\nCar\nMake : {Make} -  Model :  {Model} - Year : {Year}" +
                $" - Registration Number : {RegistrationNumber}\nColor: {Color}\nWheels: {Wheels}\nSeatingCapacity: {SeatingCapacity}\n" +
                $"GasMilage: {GasMilage}\nFuelType: {FuelType}";
        }

    }
}
