using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class ReservationWasher
    {
        public int ReservationId { get; set; }
        public string DateReservation { get; set; }
        public int Client { get; set; }
        public string WashType { get; set; }
    }
}
