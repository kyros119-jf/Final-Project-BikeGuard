using Final_Project_BikeGuard.Models;
using Final_Project_BikeGuard.Models.Services;

Bicycle gt = new Bicycle("GT", "Aggressor Pro", 2018);
Bicycle trek = new Bicycle("Trek", "Marlin 7", 2020);

BicycleManager manager = new BicycleManager();

manager.AddBicycle(gt);

Console.WriteLine();

manager.AddBicycle(trek);

Console.WriteLine();

manager.ListBicycles();

Console.WriteLine();

manager.RemoveBicycle(gt.Id);

Console.WriteLine();

manager.ListBicycles();

Console.WriteLine();

manager.RemoveBicycle(gt.Id);