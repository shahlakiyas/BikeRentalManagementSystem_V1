using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class PetrolBike : Bike
    {
        public PetrolBike(string bikeid, string brand, string modal, decimal rentalprice,string FualtankCapacity, string EngineCapacity) : base(bikeid, brand, modal, rentalprice)
        {
        }

        public string FualtankCapacity {  get; set; }
        public string EngineCapacity { get; set; }

       /* public override string DisplayPetrolBikeInfo(string FualtankCapacity, string EngineCapacity)
        {
            return $" {FualtankCapacity}, Motorpower : {EngineCapacity}";
        }*/
    }
    
}
