using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class TransactionType//Typy tranzakcji
    {
        //PK Transaction type
        public int transactioTypeId;
        //nazwa typu, E95 ,E98,ON,LPG,Mycie Standardowe,Mycie z woskowaniem
        public string transactionTypeName;
        //opis usługi
        public string describe;
        //Koszt operacji Netto
        public string costOperation;
        //Poziom Vat
        public int vatId;
    }
}
