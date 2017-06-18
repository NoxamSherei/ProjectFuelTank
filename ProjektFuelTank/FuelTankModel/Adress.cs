using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Adress
    {
        //PK- id Adress
        public int AdressId;
        //Fk- Miasto
        public int TownId;
        //Kod pocztowy
        public int PostalCodeId;
        //FK- Ulica
        public int StreetId;
        //Fk- Numer mieszkania
        public int HouseNumberId;
    }
}
