using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Entity.Concrete
{
    public class Duration
    {
        public int DurationId { get; set; }
        public string Name { get; set; }

        public IEnumerable<Job> Jobs { get; set; }
    }
}
