using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class CarWashReservation//Rezerwacja do myjni
    {
        //PK rejestracji
        public int carWashId;
        // id zamawiajacego klienta
        public int clientId;
        //DataRejesstracji
        public string dateRegistration;
        //DataRezerwacji
        public string dateReservation;
        //typ mycia
        public int transactioTypeId;
    }
}
