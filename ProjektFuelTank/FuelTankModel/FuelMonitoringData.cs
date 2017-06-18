using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class FuelMonitoringData
    {
        //PK monitoringu
        public int FuelMonitoringDataId;
        //Poziom E95
        public float Fuel95Level;
        //Poziom E98
        public float Fuel98Level;
        //Poziom ON
        public float FuelONLevel;
        //Poziom LPG
        public float LPGLevel;
        //Temperatura E95
        public float Temperature95;
        //Temperatura E98
        public float Temperature98;
        //Temperatura ON
        public float TemperatureON;
        //Temperatura LPG
        public float TemperatureLPG;
        //Ciśnienie LPG
        public float PressureLPG;
        //Data pomiaru
        public string SurveyDate;
    }
}
