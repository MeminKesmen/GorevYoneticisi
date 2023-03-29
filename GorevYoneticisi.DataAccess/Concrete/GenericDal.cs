using GorevYoneticisi.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.DataAccess.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : class, new()
    {
        private readonly DbContext _context;

        public GenericDal(DbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                Save();
            }
            catch (Exception)
            {

                throw new Exception("Database Add Error");
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                Save();
            }
            catch (Exception)
            {

                throw new Exception("Database Delete Error");
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            try
            {
                return _context.Set<T>().Where(filter).FirstOrDefault();
                Save();
            }
            catch (Exception)
            {

                throw new Exception("Database Get Error");
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            try
            {
                return filter == null ? _context.Set<T>().ToList(): _context.Set<T>().Where(filter).ToList();
                
            }
            catch (Exception)
            {

                throw new Exception("Database GetAll Error");
            }
        }

        public void Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                Save();
            }
            catch (Exception)
            {

                throw new Exception("Database Update Error");
            }
        }
        void Save() => _context.SaveChanges();

    }
}
