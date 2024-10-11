using BikeRentalManagementSystem_V1;

namespace UT01602code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("BIKE_001", "YAMAHA ","mt-15",10.00M);
            Console.WriteLine(bike.ToString());
        }
    }
}
