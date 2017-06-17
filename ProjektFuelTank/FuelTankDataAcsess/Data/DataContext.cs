using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankModel;

namespace FuelTankDataAcsess.Data
{
    public class DataContext : DbContext
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
        public DbSet<Adress> Adres { get; set; }
        public DbSet<CarWashReservation> CarWashRes { get; set; }
        public DbSet<CompanyData> Companys { get; set; }
        public DbSet<DayWorkerGraphic> DayGraphics { get; set; }
        public DbSet<FuelMonitoringData> FuelMonitorings { get; set; }
        public DbSet<HouseNumber> HouseNumbers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Vat> Vats { get; set; }
    }
}
