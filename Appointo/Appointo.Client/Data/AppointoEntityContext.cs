using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appointo.Library.Models;
using Appointo.Entity;

namespace Appointo
{
    public class AppointoEntityContext : DbContext
    {
        public AppointoEntityContext (DbContextOptions<AppointoEntityContext> options)
            : base(options)
        {
        }

        public DbSet<Appointo.Library.Models.Doctor> Doctor { get; set; }

        public DbSet<Appointo.Entity.Location> Location { get; set; }
    }
}
