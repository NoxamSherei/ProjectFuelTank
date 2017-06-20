using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class Invoice//Faktura
    {
        public int Id { get; set; }
        public string CodeName { get; set; }
        public int TransactionId { get; set; }
        public int CompanyId { get; set; }
        public int ClientId { get; set; }
        public string ClientBankName { get; set; }
        public string BankNumber { get; set; }
        public string ExposureDate { get; set; }
        public string CostNetto { get; set; }
        public string CostVat { get; set; }
        public string CostBrutto { get; set; }
        public string Describe { get; set; }
    }
}
