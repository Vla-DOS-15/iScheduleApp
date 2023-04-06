using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduleApp.Models
{
    public class PairNumber
    {
        [Key]
        public int PairNumberId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
