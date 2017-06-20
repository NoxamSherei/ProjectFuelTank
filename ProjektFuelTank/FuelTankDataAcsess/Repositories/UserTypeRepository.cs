using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelTankDataAcsess.Data;

namespace FuelTankDataAcsess.Repositories
{
    public class UserTypeRepository : RepositoryBase<UserType>
    {
        public UserTypeRepository(DataContext context) : base(context)
        {

            if (context == null) throw new ArgumentNullException();
        }
    }
}
