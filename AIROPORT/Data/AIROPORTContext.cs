using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_AIROPORT.Models;

namespace AIROPORT.Data
{
    public class AIROPORTContext : DbContext
    {
        public AIROPORTContext (DbContextOptions<AIROPORTContext> options)
            : base(options)
        {
        }

        public DbSet<BD_AIROPORT.Models.Crews> Crew { get; set; }

        public DbSet<BD_AIROPORT.Models.Staffs> Staffs { get; set; }

        public DbSet<BD_AIROPORT.Models.Positions> Positions { get; set; }

        public DbSet<BD_AIROPORT.Models.Planes> Planes { get; set; }

        public DbSet<BD_AIROPORT.Models.TypePlanes> TypePlanes { get; set; }

        public DbSet<BD_AIROPORT.Models.Routes> Routes { get; set; }

        public DbSet<BD_AIROPORT.Models.Tickets> Tickets { get; set; }
    }
}
