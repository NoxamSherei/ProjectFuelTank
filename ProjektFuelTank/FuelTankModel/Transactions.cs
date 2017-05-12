using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public string Client { get; set; }
        public float Cost { get; set; }
        public float Quantity { get; set; }
        public string DateOperation { get; set; }
        public string TypeTransaction { get; set; }
    }
}
