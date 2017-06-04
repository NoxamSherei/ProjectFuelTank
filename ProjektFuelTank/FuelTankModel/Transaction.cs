using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class Transaction//Tranzakcja
    {
        //PK Tranzakcji
        public int TransactionId;
        //numer tranzakcji
        public int userTransactionId;
        //Cena za całosc Brutto
        public string costBrutto;
        //Ilosc (np. 20litrow)
        public string quantity;
        //Data operacji
        public string transactionDate;
        //FK typ Operacji
        public int transactionTypeId;
    }
}
