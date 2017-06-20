using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class CarWashReservation//Rezerwacja do myjni
    {
        public int Id { get; set; }
        public string DateRegistration { get; set; }
        public string DateReservation { get; set; }
        public int TransactioTypeId { get; set; }
    }
}
