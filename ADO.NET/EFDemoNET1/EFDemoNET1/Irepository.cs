using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoNET1
{
    internal interface Irepository<T>
    {
        void Add(T entity); 
        T Update(T entity);
        T Remove(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
