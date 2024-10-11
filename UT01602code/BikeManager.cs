using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public  class BikeManager
    {
       public List<Bike> bikes= new List<Bike> (){ };

        public BikeManager() {
        
        
        }

        public void CreateBike(string bikeid,string brand,string modal,decimal rentalprice)
        {
            Bike bike = new Bike(bikeid,brand,modal,rentalprice);
            bikes.Add(bike);
            Console.WriteLine("bike added");


        }
        public void viewBike()
        {   if (bikes.Count == 0)
            {
                Console.WriteLine("Bikes not found");
            }
            else {
            foreach (Bike bike in bikes)
                {
                    Console.WriteLine (bike.ToString());
                }
            }

        }
        public void updateBike(string bikeid, string brand, string modal, decimal rentalprice)
        {
            bikes.Find(b => b.bikeid == bikeid);
           brand = brand;
            modal = modal;
            rentalprice = rentalprice;
            Console.WriteLine("bike updated successfully");


        }
        public void removebike(string bikeid)
        {
           var bike =  bikes.Find(b=>b.bikeid == bikeid);
            bikes.Remove(bike);
        }

        public void ValidateBikeRentalPrice(decimal rentalprice)
        {
            Console.WriteLine("enter rental price");
            var price = decimal.Parse(Console.ReadLine());
             
            if (decimal.TryParse(Console.ReadLine(), out price)&& price > 0)
            {
                rentalprice = price;
            }
            else
            {
                Console.WriteLine("enter a positive value");
            }
        }
    }
}
