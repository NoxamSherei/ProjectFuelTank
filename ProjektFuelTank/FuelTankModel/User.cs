using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class User
    {
        //PK uzytkownika
        public int UserId;
        //Data Rejestracji
        public string RegistrationTime;
        //Imie
        public string Name;
        //Nazwisko
        public string Surname;
        //Email
        public string Email;
        //Login
        public string Login;
        //FK Adress
        public int AdressId;
        //typ użytkownika
        public int UserTypeId;
        //Licznik punktów
        public int PointCount;
        //NIP
        [MaxLength(10)]
        public string NIP;
        //PESEL
        [MaxLength(11)]
        public string PESEL;
        //KSR
        public string KRS;
        //Telefon
        public string Telephone;
        //Fax
        public string Fax;
        //Tranzakcje
        public int TransactionID;
        //Rezerwacje
        public int CarWashID;
        
    }
}
