using Airliness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Statu { get; set; }
   
    }
}
