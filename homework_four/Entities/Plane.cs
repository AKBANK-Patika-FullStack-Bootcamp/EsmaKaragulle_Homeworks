using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Models
{
    public class Plane:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public DateTime FlightDate { get; set; }
    }
}
