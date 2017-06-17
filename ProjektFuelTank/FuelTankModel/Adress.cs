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
        public int adressId;
        //Fk- Miasto
        public int townId;
        //Kod pocztowy
        public int postalCodeID;
        //FK- Ulica
        public int streetId;
        //Fk- Numer mieszkania
        public int houseNumberId;
    }
}
