namespace Final_Project_BikeGuard.Models;

public class Bicycle
{

    public Guid Id { get; private set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public bool IsArmed { get; private set; }


    public Bicycle(string brand, string model, int year)
    {
        Id = Guid.NewGuid();
        Brand = brand;
        Model = model;
        Year = year;

    }

    public void Arm()
    {
        if (IsArmed == true)
            Console.WriteLine("Bicycle is already armed.");
        else
        { 
            IsArmed = true;
            Console.WriteLine("Bicycle is now armed.");
        }

       
    }
    
    public void Disarm()
    {
        if (IsArmed == false)
            Console.WriteLine("Bicycle is already disarmed.");
        else
        {
            IsArmed = false;
            Console.WriteLine("Bicycle is now disarmed.");
        }
    }




}


