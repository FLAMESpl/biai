using BIAI.Data.Model;
using System;
using System.Data.Entity;

namespace BIAI.Data
{
    public class GlobalTerrorismContext : DbContext
    {
        public DbSet<AttackRecord> AttackRecords { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<TargetType> TargetTypes { get; set; }
        public DbSet<TargetSubtype> TargetSubtypes { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public GlobalTerrorismContext() : base("GlobalTerrorism")
        {
            Database.Log = Console.Write;
        }
    }
}
