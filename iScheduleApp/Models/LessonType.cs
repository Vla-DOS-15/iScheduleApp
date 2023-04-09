using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduleApp.Models
{
    public class LessonType
    {
        [Key]
        public int LessonTypeId { get; set; }
        public string LessonTypeName { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
