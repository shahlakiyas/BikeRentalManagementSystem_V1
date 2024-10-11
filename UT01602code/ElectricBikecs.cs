using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class ElectricBikecs : Bike
    {
        public ElectricBikecs(string bikeid, string brand, string modal, decimal rentalprice, string batteryCapacity, string motorpower) : base(bikeid, brand, modal, rentalprice)
        {
            BatteryCapacity = batteryCapacity;
            Motorpower = motorpower;
        }

        public string BatteryCapacity { get; set; }
        public string Motorpower { get; set; }

        /*public override string DisplayElectricBikeInfo()
        {
            return $"BatteryCapacity {batteryCapacity}, Motorpower : {Motorpower}";
        }*/
    }
}
