using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class TransactionType//Typy tranzakcji
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Describe { get; set; }
        public string CostOperation { get; set; }
        public int VatId { get; set; }
    }
}
