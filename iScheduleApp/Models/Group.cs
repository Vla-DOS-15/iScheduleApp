using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduleApp.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

    }
}
