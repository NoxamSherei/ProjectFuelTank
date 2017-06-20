using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankDataAcsess.Data;

namespace FuelTankDataAcsess.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction>
    {
        public TransactionRepository(DataContext context) : base(context)
        {

            if (context == null) throw new ArgumentNullException();
        }
    }
}
