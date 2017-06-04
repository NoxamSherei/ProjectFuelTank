using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class WorkerGraphic
    {
        //PK Grafiku
        public int workerGraphicId;
        //Data; do dnia
        public string dateComplex;
        public int date;
        public string month;
        public int day;
        //przypisani użytkownicy
        public int userId;
        //czas rozpoczecia
        public int startTime;
        //Czas zakonczenia
        public int endTime;
    }
}
