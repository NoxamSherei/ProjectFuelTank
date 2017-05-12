using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public abstract class Raport
    {
        public int RaportID { get; set; }
        public string RaportName { get; set; }
        public string RaportDateTo { get; set; }
        public string RaportDateAt { get; set; }
    }
}
