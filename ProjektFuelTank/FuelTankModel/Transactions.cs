﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    class Transactions
    {
        public int Id;
        public int ClientId;
        public decimal Price;
        public string Date;
        public enum TransactionType { E95, E98, On, Lpg, StandardWash, WaxWash }
    }
}
