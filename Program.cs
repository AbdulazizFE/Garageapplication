using System;
using System.Collections.Generic;
using static Garageapplikation_Projektuppgift.Vehicle;

namespace Garageapplikation_Projektuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage<Vehicle> garage = new(5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

  __          __  _                            _                                                              
  \ \        / / | |                          | |                                                             
   \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___     ___  _   _ _ __    __ _  __ _ _ __ __ _  __ _  ___ 
    \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \   / _ \| | | | '__|  / _` |/ _` | '__/ _` |/ _` |/ _ \
     \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | (_) | |_| | |    | (_| | (_| | | | (_| | (_| |  __/
      \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \___/ \__,_|_|     \__, |\__,_|_|  \__,_|\__, |\___|
                                                                              __/ |                 __/ |     
                                                                             |___/                 |___/      
                                                                                                                                                           
");

            Console.ForegroundColor= ConsoleColor.Red;


            Console.WriteLine("Find a vehicle in the garage by adding a parameter:");
            Console.Write("----------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            bool option = true;
            do
            {
                Console.WriteLine("\n1. To find with a registration number."
                         + "\n2. Find all vehicles with colour."
                         + "\n3. Find all vehicles with a specified number of wheels."
                         + "\n4. Find all vehicles with a number of seats."
                         + "\n5. List all vehicles."
                         + "\n6. List all vehicle types."
                         + "\n7. Park vehicle in garage."
                         + "\n8. Remove vehicle from garage."
                         + "\n0. Exit the finding!");
                int reply = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (reply)
                {
                    case 1:
                        Console.WriteLine("Please enter your vehicle registration number : \n");
                        List<Vehicle> fetchedVehicle = garage.GetAllFromRegistration(Console.ReadLine());
                        if (fetchedVehicle == null)
                        {
                            Console.WriteLine("\nThat vehicle does not exist.");
                        }
                        else
                        {
                            fetchedVehicle.ForEach((vehicle) => { Console.WriteLine(vehicle.ToString()); });
                        }
                        break;

                    case 2:
                        Console.WriteLine("Please enter your vehicles colour : ");
                        List<Vehicle> vehicles = garage.GetFromColor(Console.ReadLine());
                        if (vehicles == null)
                        {
                            Console.WriteLine("\nThat vehicle does not exist.");
                        }
                        else
                        {
                            vehicles.ForEach((vehicle) => { Console.WriteLine(vehicle.ToString()); });
                        }
                        break;

                    case 3:
                        Console.WriteLine("Please enter how many wheels your vehicle have :");
                        List<Vehicle> vehiclewheels = garage.GetVehiclewheels(Console.ReadLine());
                        if (vehiclewheels == null)
                        {
                            Console.WriteLine("\nThat vehicle does not exist.");
                        }
                        else
                        {
                            vehiclewheels.ForEach((vehicle) => { Console.WriteLine(vehicle.ToString()); });
                        }
                        break;

                    case 4:
                        Console.WriteLine("Please enter how many passangers you can fit in your vehicle: ");
                        List<Vehicle> vehicleseats = garage.GetVehicleseats(Console.ReadLine());
                        if (vehicleseats == null)
                        {
                            Console.WriteLine("\nThat vehicle does not exist.");
                        }
                        else
                        {
                            vehicleseats.ForEach((vehicle) => { Console.WriteLine(vehicle.ToString()); });
                        }
                        break;

                    case 5:
                        Console.WriteLine("here are vehicles located in the garage: ");
                        garage.ListVehicles();
                        break;
                    case 6:

                        garage.ListTypeOfVehicles();

                        break;
                    case 7:  // Add vehicle
                        if (garage.vehicles.Count >= garage.Capacity)
                        {
                            Console.WriteLine("Garage is full!");
                            // Garage is full, return
                            break;
                        }

                        Console.WriteLine("What type is your vehicle?:\n1. Car\n2. Motorcycle\n3. Bus\n4. Truck\n5. Bicycle");
                        string carType = Console.ReadLine();
                        int x = int.Parse(carType);
                        if (x == 1)
                        {  // Car !!
                            Console.WriteLine("\nWhat brand is your car?: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("What model is your car?: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("What year is your car?: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What color is your car?: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("What registrationnumber do you have?: ");
                            string REGNR = Console.ReadLine();
                            Console.WriteLine("What gasmilage does your car have?: ");
                            string gasmilage = Console.ReadLine();
                            Console.WriteLine("What fuel does your car take?: ");
                            string fueltype = Console.ReadLine();
                            Console.WriteLine("What's the seatingcapacity?: ");
                            int seats = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does it have?: ");
                            int wheels = int.Parse(Console.ReadLine());
                            Car car = new Car(REGNR, color, wheels, seats);
                            car.Make = brand;
                            car.Model = model;
                            car.Year = year;
                            car.GasMilage = gasmilage;
                            car.FuelType = fueltype;
                            car.Type = VehicleType.Car;
                            garage.AddVehicle(car);
                            Console.WriteLine($"\nYou added:\n{car.ToString()}");
                        }
                        else if (x == 2)
                        {  // Motorcycle!!
                            Console.WriteLine("\nWhat brand is your motorcycle?: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("What model is your motorcycle?: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("What year is your motorcycle?: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What color is your motorcycle?: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("What registrationnumber do you have?: ");
                            string REGNR = Console.ReadLine();
                            Console.WriteLine("How much horsepower does your motorcycle have?: ");
                            string HP = Console.ReadLine();
                            Console.WriteLine("What suspensionbrand does your motorcycle have?: ");
                            string suspension = Console.ReadLine();
                            Console.WriteLine("What's the seatingcapacity?: ");
                            int seats = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does it have?: ");
                            int wheels = int.Parse(Console.ReadLine());
                            MotorCycle MC = new MotorCycle(REGNR, color, wheels, seats);
                            MC.Make = brand;
                            MC.Model = model;
                            MC.Year = year;
                            MC.Type = VehicleType.Motorcycle;
                            MC.HorsePower = HP;
                            MC.SuspensionBrand = suspension;
                            garage.AddVehicle(MC);
                            Console.WriteLine($"\nYou added:\n{MC.ToString()}");
                        }
                        else if (x == 3)
                        {  // Bus!!
                            Console.WriteLine("\nWhat brand is your bus?: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("What model is your bus?: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("What year is your bus?: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What color is your bus?: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("What registrationnumber do you have?: ");
                            string REGNR = Console.ReadLine();
                            Console.WriteLine("How many doors do your bus have?: ");
                            int doors = int.Parse(Console.ReadLine());
                            Console.WriteLine("How much weight can you put on your bus?: ");
                            string load = Console.ReadLine();
                            Console.WriteLine("What's the seatingcapacity?");
                            int seats = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does it have?");
                            int wheels = int.Parse(Console.ReadLine());
                            Bus bus = new Bus(REGNR, color, wheels, seats);
                            bus.Make = brand;
                            bus.Model = model;
                            bus.Year = year;
                            bus.Doors = doors;
                            bus.LoadCapacity = load;
                            bus.Type = VehicleType.Bus;
                            garage.AddVehicle(bus);
                            Console.WriteLine($"\nYou added :\n{bus.ToString()}");
                        }
                        else if (x == 4)
                        {  // Truck!!
                            Console.WriteLine("\nWhat brand is your truck?: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("What model is your truck?: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("What year is your truck?: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What color is your truck?: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("What registrationnumber do you have?: ");
                            string REGNR = Console.ReadLine();
                            Console.WriteLine("How much can your truck towing capacity?: ");
                            string towingCapacity = Console.ReadLine();
                            Console.WriteLine("How much can your truck torque?: ");
                            string torque = Console.ReadLine();
                            Console.WriteLine("What's the seatingcapacity?");
                            int seats = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does it have?");
                            int wheels = int.Parse(Console.ReadLine());
                            Truck truck = new Truck(REGNR, color, wheels, seats);
                            truck.Make = brand;
                            truck.Model = model;
                            truck.Year = year;
                            truck.TowingCapacity = towingCapacity;
                            truck.Torque = torque;
                            truck.Type = VehicleType.Truck;
                            garage.AddVehicle(truck);
                            Console.WriteLine($"\nYou added:\n{truck.ToString()}");
                        }
                        else if (x == 5)
                        {  // Bicycle!!
                            Console.WriteLine("\nWhat brand is your bicycle?: ");
                            string brand = Console.ReadLine();
                            Console.WriteLine("What model is your bicycle?: ");
                            string model = Console.ReadLine();
                            Console.WriteLine("What year is your bicycle?: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.WriteLine("What color is your bicycle?: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("What registrationnumber do you have?: ");
                            string REGNR = Console.ReadLine();
                            Console.WriteLine("How many gears are on yours bicycle?: ");
                            int gears = int.Parse(Console.ReadLine());
                            Console.WriteLine("How much is rimSize?: ");
                            int rimSize = int.Parse(Console.ReadLine());
                            Console.WriteLine("What's the seatingcapacity?");
                            int seats = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many wheels does it have?");
                            int wheels = int.Parse(Console.ReadLine());
                            Bicycle bicycle = new Bicycle(REGNR, color, wheels, seats);
                            bicycle.Make = brand;
                            bicycle.Model = model;
                            bicycle.Year = year;
                            bicycle.Gears = gears;
                            bicycle.RimSize = rimSize;
                            bicycle.Type = VehicleType.Bicycle;
                            garage.AddVehicle(bicycle);
                            Console.WriteLine($"\nYou added:\n{bicycle.ToString()}");
                        }
                        else
                        {
                            Console.WriteLine("You have to type 1, 2, 3, 4 or 5.\nTry again!");
                        }
                        break;
                    case 8:    // Remove vehicle                                            
                        Console.WriteLine("Please enter the registrationnumber of the car you would like to remove: ");
                        Vehicle enterdVehicle = garage.GetFromRegistration(Console.ReadLine());
                        if (enterdVehicle == null)
                        {
                            Console.WriteLine("That vehicle doesn't exist");
                        }
                        else
                        {
                            Console.WriteLine("\nYou removed: " + enterdVehicle.ToString());
                            garage.RemoveVehicle(enterdVehicle);
                        }

                        break;
                    case 0:
                        Console.WriteLine("You've decided to quit.");
                        option = false;
                        break;
                    default:
                        Console.WriteLine("Please insert either 1,2,3,4,5,6,7,8 or 0.");
                        break;
                }
            } while (option);


            Console.ReadKey();
        }


    }
}