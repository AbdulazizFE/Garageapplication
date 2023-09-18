using Garageapplikation_Projektuppgift;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Garageapplikation_Projektuppgift.Vehicle;

public class Garage<T> : IEnumerable where T : Vehicle
{
    public Garage(int capacity)
    {
        Capacity = capacity;
    }

    public int Capacity { get; set; }
    public List<T> vehicles { get; set; } = new List<T>();

    public IEnumerator<T> GetEnumerator()
    {
        return vehicles.GetEnumerator();
    }

    public void AddVehicle(T vehicle) => vehicles.Add(vehicle);
    public void RemoveVehicle(T vehicle) => vehicles.Remove(vehicle);




    public void ListVehicles()
    {
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle.ToString());
        }
    }

    public void ListTypeOfVehicles()
    {
        List<VehicleType> types = new List<VehicleType>();
        foreach (Vehicle vehicle in vehicles)
        {
            if (!types.Contains(vehicle.Type))
            {
                types.Add(vehicle.Type);
            }
        }

        for (int i = 0; i < types.Count; i++)
        {
            Console.WriteLine($"{(i + 1)}. {types[i]}");
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return vehicles.GetEnumerator();
    }


    public List<Vehicle> GetAllFromRegistration(string registrationNumber)
    {
        if (vehicles.Any(vehicle => vehicle.RegistrationNumber.ToLower() == registrationNumber.ToLower()))
        {
            return vehicles.Where(vehicle => vehicle.RegistrationNumber.ToLower() == registrationNumber.ToLower()).ToList<Vehicle>();
        }
        else
        {
            return null;
        }
    }

    public List<Vehicle> GetFromColor(string vehicleColor)
    {
        if (vehicles.Any(vehicle => vehicle.Color.ToLower() == vehicleColor.ToLower()))
        {
            return vehicles.Where(vehicle => vehicle.Color.ToLower() == vehicleColor.ToLower()).ToList<Vehicle>();
        }
        else
        {
            return null;
        }
    }

    public List<Vehicle> GetVehiclewheels(string vehicleWheels)
    {
        if (vehicles.Any(vehicle => vehicle.Wheels.ToString() == vehicleWheels.ToLower()))
        {
            return vehicles.Where(vehicle => vehicle.Wheels.ToString() == vehicleWheels.ToLower()).ToList<Vehicle>();
        }
        else
        {
            return null;
        }
    }

    public List<Vehicle> GetVehicleseats(string vehicleSeats)
    {
        if (vehicles.Any(vehicle => vehicle.SeatingCapacity.ToString() == vehicleSeats.ToLower()))
        {
            return vehicles.Where(vehicle => vehicle.SeatingCapacity.ToString() == vehicleSeats.ToLower()).ToList<Vehicle>();
        }
        else
        {
            return null;
        }
    }

    public Vehicle GetFromRegistration(string registrationNumber)
    {
        if (vehicles.Any(vehicle => vehicle.RegistrationNumber.ToLower() == registrationNumber.ToLower()))
        {
            return vehicles.First(vehicle => vehicle.RegistrationNumber.ToLower() == registrationNumber.ToLower());
        }
        else
        {
            return null;
        }
    }
}
