using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduleApp.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public int IdPairNumber { get; set; }
        [ForeignKey("IdPairNumber")]
        public PairNumber PairNumber { get; set; }

        public int IdGroup { get; set; }
        [ForeignKey("IdGroup")]
        public Group Group { get; set; }

        public int IdLessonType { get; set; }
        [ForeignKey("IdLessonType")]
        public LessonType LessonType { get; set; }

        public int IdTeacher { get; set; }
        [ForeignKey("IdTeacher")]
        public Teacher Teacher { get; set; }

        public int IdAuditory { get; set; }
        [ForeignKey("IdAuditory")]
        public Auditory Auditory { get; set; }
    }
}
