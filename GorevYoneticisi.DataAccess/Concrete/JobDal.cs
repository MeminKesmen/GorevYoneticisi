using GorevYoneticisi.DataAccess.Abstract;
using GorevYoneticisi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.DataAccess.Concrete
{
    public class JobDal : GenericDal<Job>, IJobDal
    {
        private readonly DbContext _context;

        public JobDal(DbContext context) : base(context)
        {
            _context = context;
        }

        public List<Job> GetAllWithDuration(Expression<Func<Job, bool>> filter = null)
        {
            
                try
                {
                var query = _context.Set<Job>().Include(j => j.Duration);
                    return filter == null ? query.ToList() : query.Where(filter).ToList();

                }
                catch (Exception)
                {

                    throw new Exception("Database GetAllWithDuration Error");
                }
            
        }
    }
}
