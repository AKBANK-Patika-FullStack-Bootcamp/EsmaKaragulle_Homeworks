using Airliness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.AuthModel
{
    public class APIAuthority:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

    }
}
