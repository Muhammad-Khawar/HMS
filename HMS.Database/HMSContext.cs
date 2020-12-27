using HMS.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Database
{
    public class HMSContext : IdentityDbContext<HMSUser>
    {
        public HMSContext() : base("HMSConnectionString")
        {
        }
        public static HMSContext Create()
        {
            return new HMSContext();
        }

        public DbSet<AccommodationType> AccommodationType { get; set; }
        public DbSet<AccommodationPackage> AccommodationPackage { get; set; }
        public DbSet<Accommodation> Accommodation { get; set; }
        public DbSet<Booking> Booking { get; set; }

    }
}
