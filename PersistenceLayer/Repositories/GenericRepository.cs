using MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext Context;
        private DbSet<T> table = null;
        public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
            table = Context.Set<T>();
        }

        public void Add(T entity)
        {
            table.Add(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            T existing  = table.Find(id);
            table.Remove(existing);
            Context.SaveChanges();
        }

        public void Edit(T obj)
        {
            table.Attach(obj);
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            if(id == null)
            {
                throw new ArgumentException("Bad Request");
            }
            return table.Find(id);
        }
    }
}
