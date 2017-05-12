using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class ServicesCosts
    {
        public int ServiceId { get; set; }
        public float E95 { get; set; }
        public float E98 { get; set; }
        public float ON { get; set; }
        public float LPG { get; set; }
        public float WashWox { get; set; }
        public float WashStandard { get; set; }
        public string LastChanges { get; set; }
    }
}
