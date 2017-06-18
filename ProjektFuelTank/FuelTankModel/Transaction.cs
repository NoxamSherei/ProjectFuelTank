using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Transaction//Tranzakcja
    {
        //PK Tranzakcji
        public int TransactionId;
        //numer tranzakcji
        public int UserTransactionId;
        //Cena za całosc Brutto
        public string CostBrutto;
        //Ilosc (np. 20litrow)
        public string Quality;
        //Data operacji
        public string TransactionDate;
        //FK typ Operacji
        public int TransactionTypeId;
    }
}
