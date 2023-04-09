using iScheduleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iScheduleApp.TableDataGateway
{
    public class TeacherGateway
    {
        private ApplicationContext db;
        public void Load()
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Schedules.Load();
                    db.Faculties.Load();
                    db.Groups.Load();
                    db.Auditories.Load();
                    db.LessonTypes.Load();
                    db.PairNumbers.Load();
                    db.Teachers.Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Group> GetGroups()
        {
            List<Group> list = null;
            using (db = new ApplicationContext())
            {
                db.Schedules.Load();
                db.Groups.Load();
                list = db.Groups.ToList();
            }
            return list;
        }
        public List<Faculty> GetFaculties()
        {
            List<Faculty> list = null;
            using (db = new ApplicationContext())
            {
                db.Schedules.Load();
                db.Groups.Load();
                db.Faculties.Load();
                list = db.Faculties.ToList();
            }
            return list;
        }
        public List<PairNumber> GetStartTimePair()
        {
            List<PairNumber> list = null;
            using (db = new ApplicationContext())
            {
                db.Schedules.Load();
                db.Groups.Load();
                db.PairNumbers.Load();
                list = db.PairNumbers.ToList();
            }
            return list;
        }
        public List<LessonType> GetLessonType()
        {
            List<LessonType> list = null;
            using (db = new ApplicationContext())
            {
                db.Schedules.Load();
                db.Groups.Load();
                db.LessonTypes.Load();
                list = db.LessonTypes.ToList();
            }
            return list;
        }
        public List<Auditory> GetAuditory()
        {
            List<Auditory> list = null;
            using (db = new ApplicationContext())
            {
                db.Schedules.Load();
                db.Groups.Load();
                db.Auditories.Load();
                list = db.Auditories.ToList();
            }
            return list;
        }
        public void Add(string date, string lessonName, string startTime, string groupName, string lessonTypeName, string teacherName, int auditoriumNumber)
        {
            Load();
            using (db = new ApplicationContext())
            {
                var StartTimeId = db.PairNumbers.FirstOrDefault(x => x.StartTime == TimeSpan.Parse(startTime)).PairNumberId;
                var GroupNameId = db.Groups.FirstOrDefault(x => x.GroupName == groupName).Id;
                var LessonTypeId = db.LessonTypes.FirstOrDefault(x => x.LessonTypeName == lessonTypeName).LessonTypeId;
                var TeacherId = db.Teachers.FirstOrDefault(x => x.FullName == teacherName).TeacherId;
                var AuditoryNumberId = db.Auditories.FirstOrDefault(x => x.AuditoriumNumber == auditoriumNumber).AuditoryId;

                Schedule schedule = new Schedule
                {
                    Day = "",
                    LessonName = lessonName,
                    IdPairNumber = StartTimeId,
                    IdGroup = GroupNameId,
                    IdLessonType = LessonTypeId,
                    IdTeacher = TeacherId,
                    IdAuditory = AuditoryNumberId
                };
                db.Schedules.Add(schedule);
                db.SaveChanges();
                
            }
            Load();
        }
        public void GetTable(DataGridView dataGridView)
        {
            using (db = new ApplicationContext())
            {
                db.Roles.Load();
                db.Users.Load();
                db.Schedules.Load();
                db.Groups.Load();

                var result = from g in db.Schedules                            

                             select new
                             {
                                 Id = g.ScheduleId,
                                 StartTime = g.PairNumber.StartTime,
                                 EndTime = g.PairNumber.EndTime,
                                 Day = g.Day,
                                 LessonName = g.LessonName,
                                 LessonType = g.LessonType.LessonTypeName,
                                 GroupName = g.Group.GroupName,
                                 Teacher = g.Teacher.FullName,
                                 BuildingNumber = g.Auditory.BuildingNumber,
                                 Floor = g.Auditory.Floor,
                                 AuditoriumNumber = g.Auditory.AuditoriumNumber,
                             };

                dataGridView.DataSource = result.ToList();
            }
        }
    }
}
