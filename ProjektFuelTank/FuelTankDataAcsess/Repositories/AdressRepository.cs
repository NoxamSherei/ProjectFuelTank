using FuelTankDataAcsess.Data;
using FuelTankModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankDataAcsess.Repositories
{
    public class AdressRepository
    {
        internal DataContext context;
        public AdressRepository(DataContext context)
        {
            this.context = context;
        }
        public virtual Adress GetById(object id)
        {
            return context.Adres.Find(id);
        }
        public virtual IQueryable<Adress> GetAll()
        {
            return context.Adres;
        }

        public virtual void Insert(Adress entity)
        {
            context.Adres.Add(entity);
        }
        public virtual void Update(Adress entity)
        {
            context.Adres.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(Adress entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                context.Adres.Attach(entity);

            context.Adres.Remove(entity);
        }
    }
}
