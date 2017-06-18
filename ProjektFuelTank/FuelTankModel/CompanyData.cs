using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class CompanyData//Tablica z danymmi o Firmie
    {
        //PK Company
        public int CompanyId;
        //Nazwafirmy
        public string CompanyName;
        //Adress
        public string CdressId;
        // User ID szefa
        public int ChefId;
        // szerokość geograficzna
        public float Latitude;
        // długość geograficzna
        public float Longitude;
        //Bank
        public string BankName;
        //nr Konta bankowego
        public string BankNumber;
        //REGON
        public string REGON;
    }
}
