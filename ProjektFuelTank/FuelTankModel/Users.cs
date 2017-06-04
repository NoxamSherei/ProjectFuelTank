using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class Users
    {
        //PK uzytkownika
        public int userId;
        //Data Rejestracji
        public string registrationTime;
        //Imie
        public string name;
        //Nazwisko
        public string surname;
        //Email
        public string Email;
        //Login
        public string Login;
        //FK Adress
        public int adressId;
        //Numer Domu
        public int HouseNo;
        //typ użytkownika
        public int userTypeId;
        //Licznik punktów
        public int PointCount;
        //NIP
        public string NIP;
        //PESEL
        public string PESEL;
        //KSR
        public string KRS;
        //Telefon
        public string telephone;
        //Fax
        public string Fax;

    }
}
