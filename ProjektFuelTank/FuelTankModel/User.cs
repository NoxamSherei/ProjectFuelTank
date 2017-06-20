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
        public int UserId { get; set; }
        public string RegistrationTime { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public int AdressId { get; set; }
        public int UserTypeId { get; set; }
        public int PointCount { get; set; }
        [MaxLength(10)]
        public string NIP { get; set; }
        [MaxLength(11)]
        public string PESEL { get; set; }
        public string KRS { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public int TransactionID { get; set; }
        public int CarWashID { get; set; }

    }
}
