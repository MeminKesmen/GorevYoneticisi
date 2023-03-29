using GorevYoneticisi.Business.Abstract;
using GorevYoneticisi.DataAccess.Abstract;
using GorevYoneticisi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Business.Concrete
{
    public class DurationManager : IDurationService
    {
        private readonly IDurationDal _durationDal;

        public DurationManager(IDurationDal durationDal)
        {
            _durationDal = durationDal;
        }
        public void Add(Duration entity)
        {
            _durationDal.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Duration Get(Expression<Func<Duration, bool>> filter)
        {
            return _durationDal.Get(filter);
        }

        public List<Duration> GetAll(Expression<Func<Duration, bool>> filter = null)
        {
            return _durationDal.GetAll(filter);
        }

        public void Update(Duration entity)
        {
            throw new NotImplementedException();
        }
    }
}
