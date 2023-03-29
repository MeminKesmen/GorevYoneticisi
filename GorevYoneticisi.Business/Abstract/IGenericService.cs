using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Business.Abstract
{
    public interface IGenericService<T>where T:class,new()
    {
        void Add(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        void Delete(int id);
        void Update(T entity);
    }
}
