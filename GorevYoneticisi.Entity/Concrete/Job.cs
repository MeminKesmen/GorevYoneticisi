using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYoneticisi.Entity.Concrete
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int UserId { get; set; }
        public int DurationId { get; set; }

        public User User { get; set; }
        public Duration Duration { get; set; }

    }
}
