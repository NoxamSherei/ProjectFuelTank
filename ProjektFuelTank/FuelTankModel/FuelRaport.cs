using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class FuelRaport: Raport
    {
        public List<string> MothSelles { get; set; }
        public float FuelLevel95 { get; set; }
        public float FuelLevel98 { get; set; }
        public float FuelLevelON { get; set; }
        public float FuelLevelLPG { get; set; }
        public float FuelTemperature95 { get; set; }
        public float FuelTemperature98 { get; set; }
        public float FuelTemperatureON { get; set; }
        public float FuelTemperatureLPG { get; set; }
        public float FuelPresureLPG { get; set; }
    }
}
