using GorevYoneticisi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Business.Abstract
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
