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
        public int carWashId;
        //DataRejesstracji
        public string dateRegistration;
        //DataRezerwacji
        public string dateReservation;
        //typ mycia
        public int transactioTypeId;
    }
}
