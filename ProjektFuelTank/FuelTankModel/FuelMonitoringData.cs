using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class FuelMonitoringData
    {
        public int Id { get; set; }
        public float Fuel95Level { get; set; }
        public float Fuel98Level { get; set; }
        public float FuelONLevel { get; set; }
        public float LPGLevel { get; set; }
        public float Temperature95 { get; set; }
        public float Temperature98 { get; set; }
        public float TemperatureON { get; set; }
        public float TemperatureLPG { get; set; }
        public float PressureLPG { get; set; }
        public string SurveyDate { get; set; }
    }
}
