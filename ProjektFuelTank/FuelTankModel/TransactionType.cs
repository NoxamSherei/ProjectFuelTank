using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class TransactionType//Typy tranzakcji
    {
        //PK Transaction type
        public int TransactionTypeId;
        //nazwa typu, E95 ,E98,ON,LPG,Mycie Standardowe,Mycie z woskowaniem
        public string TransactionTypeName;
        //opis usługi
        public string Describe;
        //Koszt operacji Netto
        public string CostOperation;
        //Poziom Vat
        public int VatId;
    }
}
