using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankModel;

namespace FuelTankDataAcsess.Data
{
    class DataContext : DbContext
    {
        /// <summary>
        /// you can either pass the NAME of a conenction string (e.g. from a web.config), and explicitly delcare it.
        /// </summary>
        public DataContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// any entity to be persisted must me delcared here.
        /// </summary>
        /*public DbSet<StandardUser> StandardUsers { get; set; }
        public DbSet<WorkerUser> WorkerUsers { get; set; }
        public DbSet<ReservationWasher> ReservationWashers { get; set; }
        public DbSet<SaleRaport> SaleRaports { get; set; }
        public DbSet<ServicesCosts> ServicesCostss { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<FuelRaport> FuelRaports { get; set; }*/
    }
}
