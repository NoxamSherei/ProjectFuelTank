using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class CompanyData//Tablica z danymmi o Firmie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AdressId { get; set; }
        public int ChefId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string REGON { get; set; }
    }
}
