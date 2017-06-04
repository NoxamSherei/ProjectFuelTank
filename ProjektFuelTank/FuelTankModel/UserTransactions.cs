using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class UserTransactions//Tablica łączaca użytkownika z Tranzakcjami
    {
        //PK operacji
        public int usertransactionId;
        //FK użytkownika
        public int userId;
        //FK tranzakcji
        public int transactionId;
    }
}
