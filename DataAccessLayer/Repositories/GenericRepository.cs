using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T item)
        {
            using var context = new Context();
            context.Set<T>().Remove(item);
            context.SaveChanges();
        }

        public T? GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var context = new Context();
            context.Set<T>().Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            using var context = new Context();
            context.Set<T>().Update(item);
            context.SaveChanges();
        }
    }
}
