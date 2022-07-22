using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business
{
    public class BusinessService
    {
        Data.DataAccess dt = new Data.DataAccess();

        public Model.ICar GetCar()
        {
            return dt.GetCar();
        }
    }
}
