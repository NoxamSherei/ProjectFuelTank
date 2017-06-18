using FuelTankDataAcsess.Data;
using FuelTankModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankDataAcsess.Repositories
{
    public class AdressRepository : RepositoryBase<Adress>
    {
        public AdressRepository(DataContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException();
        }
    }
}
