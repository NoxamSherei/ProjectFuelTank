using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class User
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
        //Tranzakcje
        public int TransactionID;
        //Rezerwacje
        public int CarWashID;
        
    }
}
