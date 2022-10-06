using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoNET1
{
    public class Repository<T> : Irepository<T> where T : class
    {

        private DbContext _context =null;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);

        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }

        public  T Remove(T entity)
        {
            return _context.Set<T>().Remove(entity);

        }

        public T Update(T entity)
        {
           return _context.Set<T>().Attach(entity);
        }
    }
}
