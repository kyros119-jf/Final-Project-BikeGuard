using Final_Project_BikeGuard.Models;

Bicycle myBike = new Bicycle("GT", "Aggressor Pro", 2018);
Console.WriteLine($"Bicycle ID: {myBike.Id}");
Console.WriteLine($"Brand: {myBike.Brand}");
Console.WriteLine($"Model: {myBike.Model}");
Console.WriteLine($"Year: {myBike.Year}");
Console.WriteLine($"Armed: {myBike.IsArmed}");

myBike.Arm();
myBike.Disarm();    