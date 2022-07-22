using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Data
{
    public class DataAccess
    {

        private Dataobject getCar()
        {
            return new Data.Dataobject() { IndexName = "Ford", UniqueIdStripped = 4 };
        }

        private DataObjectMongol getMongolCar()
        {
            return new DataObjectMongol() { JsonKey = "{1}", NameStringValue = "Name='ricky'" };

        }


        internal Model.ICar GetCar()
        {
            var dataCar = getMongolCar();

            return new Business.Car()
            {
                Id = 1,
                Name = dataCar.NameStringValue.Substring(2)
            };
        }
    }
}
