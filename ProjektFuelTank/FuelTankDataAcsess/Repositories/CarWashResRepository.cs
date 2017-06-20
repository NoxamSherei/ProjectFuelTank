using FuelTankDataAcsess.Data;
using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankDataAcsess.Repositories
{
    public class CarWashResRepository: RepositoryBase<CarWashReservation>
    {
        public CarWashResRepository(DataContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException();
        }
    }
}
