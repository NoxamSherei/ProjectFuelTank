using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class CompanyData//Tablica z danymmi o Firmie
    {
        //PK Company
        public int companyId;
        //Nazwafirmy
        public string companyName;
        //Adress
        public string adressId;
        // User ID szefa
        public int chefId;
        // numer domu
        public int HouseNo;
        // szerokość geograficzna
        public float lat;
        // długość geograficzna
        public float lng;
        //Bank
        public string bankName;
        //nr Konta bankowego
        public string BankNumber;
    }
}
