using Data_Access.Abstract;
using Data_Access.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repositories
{
    public class Generic<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;

        public Generic()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deleted = context.Entry(entity);
            deleted.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var add = context.Entry(entity);
            add.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var update = context.Entry(entity);
            update .State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
