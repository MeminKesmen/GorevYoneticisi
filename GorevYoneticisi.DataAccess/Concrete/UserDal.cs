using GorevYoneticisi.DataAccess.Abstract;
using GorevYoneticisi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.DataAccess.Concrete
{
    public class UserDal : GenericDal<User>, IUserDal
    {
        public UserDal(DbContext context) : base(context)
        {
        }
    }
}
