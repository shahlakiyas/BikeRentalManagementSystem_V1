using BikeRentalManagementSystem_V1;

namespace UT01602code
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("BIKE_001", "YAMAHA ", "mt-15", 10.00M);
            Console.WriteLine(bike.ToString());

            BikeManager manager = new BikeManager();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Bike Rental Management System:");
                Console.WriteLine("1.Add a bike");
                Console.WriteLine("2.View all bike");
                Console.WriteLine("3.Update a bike");
                Console.WriteLine("4.Delete a bike");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose an option");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        addbike(manager);
                        break;
                    case "2":
                        Console.Clear();
                        manager.viewBike();
                        break;

                    case "3":
                        Console.Clear();
                        updatebike(manager);
                        break;
                    case "4":
                        Console.Clear();
                        removebike(manager);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;






                }
                static void addbike(BikeManager manager)
                {
                    Console.WriteLine("enter bike id");
                    string bikeid = Console.ReadLine();

                    Console.WriteLine("enter bike brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("enter bike modal");
                    string modal = Console.ReadLine();

                    /*Console.WriteLine("enter rentalprice");
                    decimal rentalprice = decimal.Parse(Console.ReadLine());*/

                    var rentalprice = ValidateBikeRentalPrice(manager);

                    manager.CreateBike(bikeid, brand, modal, rentalprice);


                }

                static void updatebike(BikeManager manager)
                {
                    Console.WriteLine("enter bike id");
                    string bikeid = Console.ReadLine();

                    Console.WriteLine("enter bike brand");
                    string brand = Console.ReadLine();

                    Console.WriteLine("enter bike modal");
                    string modal = Console.ReadLine();

                    Console.WriteLine("enter rentalprice");
                    decimal rentalprice = decimal.Parse(Console.ReadLine());

                    manager.updateBike(bikeid, brand, modal, rentalprice);


                }
                static void removebike(BikeManager manager)
                {
                    Console.WriteLine("enter bike id");
                    string bikeid = Console.ReadLine();

                    manager.removebike(bikeid);
                    Console.WriteLine("bike removed success");
                }

                static void ValidateBikeRentalPrice(BikeManager manager)
                {
                    Console.WriteLine();
                    string bikeid = Console.ReadLine();


                }
            }


        }
    }
}
