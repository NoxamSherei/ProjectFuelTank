using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class CarWashReservation
    {
        public int Id;
        public int ClientId;
        public string Date;
        public enum CarWashType { StandardWash, WaxWash }
    }
}
