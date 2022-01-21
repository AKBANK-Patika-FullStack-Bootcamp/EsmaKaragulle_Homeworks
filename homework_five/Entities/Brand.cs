using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Models
{
    public class Brand:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
