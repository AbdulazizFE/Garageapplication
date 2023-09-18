namespace Garageapplikation_Projektuppgift
{
    class MotorCycle : Vehicle
    {
        public MotorCycle(string registrationNumber, string vehicleColor, int vehicleWheels, int vehicleSeats) :
            base(registrationNumber, vehicleColor, vehicleWheels, vehicleSeats)
        {
            Color = vehicleColor;
            Wheels = vehicleWheels;
            SeatingCapacity = vehicleSeats;
        }

        public string HorsePower { get; set; }
        public string SuspensionBrand { get; set; }

        public override string ToString()
        {
            return $"\nMotorcycle\nMake : {Make} -  Model :  {Model} - Year : {Year}" +
                $" - Registration Number : {RegistrationNumber}\nColor: {Color}\nWheels: {Wheels}\nSeatingCapacity: {SeatingCapacity}\n" +
                $"HorsePower: {HorsePower}\nSuspensionBrand: {SuspensionBrand}";
        }
    }
}
