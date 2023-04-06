using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduleApp.Models
{
    public class Auditory
    {
        [Key]
        public int AuditoryId { get; set; }
        public string LessonTypeName { get; set; }
        public int BuildingNumber { get; set; }
        public int Floor { get; set; }
        public int AuditoriumNumber { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
