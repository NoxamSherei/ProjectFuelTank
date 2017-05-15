using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class Invoices
    {
        public int Id;
        public int ClientId;
        public string RegistrationTime;
        public string Name;
        public string Surname;
        public string Street;
        public int HouseNo;
        public string PostalCode;
        public string Place;
        public string NIP;
        public string PESEL;
        public enum UserType { Client, Worker, Owner }
        public int PointCount;
    }
}
