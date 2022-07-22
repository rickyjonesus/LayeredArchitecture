using LayeredArchitecture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business
{
    public class Car : ICar
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
