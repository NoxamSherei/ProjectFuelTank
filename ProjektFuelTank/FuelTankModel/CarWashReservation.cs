using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class CarWashReservation//Rezerwacja do myjni
    {
        //PK rejestracji
        public int CarWashId;
        //DataRejesstracji
        public string DateRegistration;
        //DataRezerwacji
        public string DateReservation;
        //typ mycia
        public int TransactioTypeId;
    }
}
