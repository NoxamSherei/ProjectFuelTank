﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Transaction//Tranzakcja
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CostBrutto { get; set; }
        public string Quality { get; set; }
        public string Date { get; set; }
        public int TransactionTypeId { get; set; }
    }
}
