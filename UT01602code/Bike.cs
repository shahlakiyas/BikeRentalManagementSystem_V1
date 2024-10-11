using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {
        public string bikeid;
        public string brand;
        public string modal;
        public decimal rentalprice;
        public Bike(string bikeid, string brand, string modal, decimal rentalprice)
        {
            this.bikeid = bikeid;
            this.brand = brand;
            this.modal = modal;
            this.rentalprice = rentalprice;

        }

    } public override string ToString()
    {
        return $"bikeId :{bikeid},brand: {brand}, model: {modal}, rentalPrice: {rentalprice}";
    }

    
}
