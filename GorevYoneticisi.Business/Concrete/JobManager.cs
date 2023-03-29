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
    public class JobManager : IJobService
    {
        private readonly IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public void Add(Job entity)
        {
            _jobDal.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Job Get(Expression<Func<Job, bool>> filter)
        {
            return _jobDal.Get(filter);
        }

        public List<Job> GetAll(Expression<Func<Job, bool>> filter = null)
        {
            return _jobDal.GetAll(filter);
        }

        public List<Job> GetAllWithDuration(Expression<Func<Job, bool>> filter = null)
        {
            return _jobDal.GetAllWithDuration(filter);
        }

        public void Update(Job entity)
        {
            _jobDal.Update(entity);
        }
    }
}
