using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankDataAcsess.Data;

namespace FuelTankDataAcsess.Repositories
{
    public class InvoiceRepository : RepositoryBase<Invoice>
    {
        public InvoiceRepository(DataContext context) : base(context)
        {

            if (context == null) throw new ArgumentNullException();
        }
    }
}
