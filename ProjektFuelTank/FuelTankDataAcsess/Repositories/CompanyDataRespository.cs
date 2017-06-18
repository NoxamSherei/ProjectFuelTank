using FuelTankDataAcsess.Repositories;
using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankDataAcsess.Data;

namespace FuelTankDataAcsess.Repositories
{
    public class CompanyDataRespository : RepositoryBase<CompanyData>
    {
        public CompanyDataRespository(DataContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException();
        }
    }
}