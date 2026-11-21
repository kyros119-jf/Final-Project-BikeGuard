namespace Final_Project_BikeGuard.Models.Services
{
    public class BicycleManager
    {
        private List<Bicycle> bicycles;
        public BicycleManager()
        {
            bicycles = new List<Bicycle>();
        }
        public void AddBicycle(Bicycle bicycle)
        {
            bicycles.Add(bicycle);
            Console.WriteLine($"Bicycle {bicycle.Brand} {bicycle.Model} added.");
        }
        public void RemoveBicycle(Guid id)
        {
            var bicycle = bicycles.Find(bike => bike.Id == id);
            if (bicycle != null)
            {
                bicycles.Remove(bicycle);
                Console.WriteLine($"Bicycle {bicycle.Brand} {bicycle.Model} removed.");
            }
            else
            {
                Console.WriteLine("Bicycle not found.");
            }
        }
        public void ListBicycles()
        {
            foreach (var bicycle in bicycles)
            {
                Console.WriteLine($"ID: {bicycle.Id}, Brand: {bicycle.Brand}, Model: {bicycle.Model}, Year: {bicycle.Year}, Armed: {bicycle.IsArmed}");
            }
        }
    }
}