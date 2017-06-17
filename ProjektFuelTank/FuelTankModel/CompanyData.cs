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
        public int companyId;
        //Nazwafirmy
        public string companyName;
        //Adress
        public string adressId;
        // User ID szefa
        public int chefId;
        // szerokość geograficzna
        public float Latitude;
        // długość geograficzna
        public float Longitude;
        //Bank
        public string bankName;
        //nr Konta bankowego
        public string BankNumber;
        //REGON
        public string REGON;
    }
}
