using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Business
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
    }
}
