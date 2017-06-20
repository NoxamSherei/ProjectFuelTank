using FuelTankDataAcsess.Data;
using FuelTankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankDataAcsess.Repositories
{
    public class DayWorkerGraphicRepository:RepositoryBase<DayWorkerGraphic>
    {

        public DayWorkerGraphicRepository(DataContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException();
        }
    }
}
