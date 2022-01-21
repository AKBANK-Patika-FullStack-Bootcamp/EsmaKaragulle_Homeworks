using Airliness.Models;
using Entities.AuthModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airliness.Dal.Concrete
{
    public class AirlinessContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Airliness;Trusted_connection=true");
        }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<APIAuthority> APIAuthority { get; set; }

    }
}
