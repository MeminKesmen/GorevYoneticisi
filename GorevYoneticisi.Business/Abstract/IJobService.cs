using GorevYoneticisi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Business.Abstract
{
    public interface IJobService : IGenericService<Job>
    {
        List<Job> GetAllWithDuration(Expression<Func<Job, bool>> filter = null);
    }
}
