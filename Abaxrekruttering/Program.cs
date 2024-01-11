using System;
using Abaxrekruttering;

class Program
{
    static void Main()
    {
        // Create objects
        Car car1 = new Car("NF123456", 147, 200, "green");
        Car car2 = new Car("NF654321", 150, 195, "blue");

        Plane plane = new Plane("LN1234", 1000, 30, 2);

        Boat boat = new Boat("ABC123", 100, 30, 500);

        // Print information
        Console.WriteLine("Information about car 1:");
        Console.WriteLine($"Reg. number: {car1.RegistrationNumber}, Power: {car1.Power}kw, Max speed: {car1.MaxSpeed}km/h, Color: {car1.Color}");
        car1.Move();

        Console.WriteLine("\nInformation about car 2:");
        Console.WriteLine($"Reg. number: {car2.RegistrationNumber}, Power: {car2.Power}kw, Max speed: {car2.MaxSpeed}km/h, Color: {car2.Color}");
        car2.Move();

        // Comparison of cars
        if (car1.Equals(car2))
        {
            Console.WriteLine("\nCar 1 and car 2 are the same vehicle.");
        }
        else
        {
            Console.WriteLine("\nCar 1 and car 2 are not the same vehicle.");
        }

        Console.WriteLine("\nInformation about the plane:");
        Console.WriteLine($"Registration number: {plane.RegistrationNumber}, Power: {plane.Power}kw, Wingspan: {plane.Wingspan}m, Payload capacity: {plane.PayloadCapacity} tons");
        plane.Fly();

        Console.WriteLine("\nInformation about the boat:");
        Console.WriteLine($"Registration number: {boat.RegistrationNumber}, Power: {boat.Power}kw, Max speed: {boat.MaxSpeed} knots, Gross Tonnage: {boat.GrossTonnage}kg");
        boat.Move();
    }
}
