using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iScheduleApp.Models;

namespace iScheduleApp.TableDataGateway
{
    public class StudentGateway
    {
        private ApplicationContext db;
        public void Load()
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Schedules.Load();
                    db.Groups.Load();
                    //dataGrid.ItemsSource = db.Accountings.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Group> GetGroups()
        {
            List<Group>  list = null;
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

        public void GetTable(DataGridView dataGridView,string groupName, string day, string facultyName, string course)
        {
            using (db = new ApplicationContext())
            {
                db.Roles.Load();
                db.Users.Load();
                db.Schedules.Load();
                db.Groups.Load();

                var result = from g in db.Schedules
                             where g.Group.GroupName == groupName && g.Day == day && g.Group.Faculty.FacultyName == facultyName && g.Group.Course == int.Parse(course)

                             select new
                             {
                                 StartTime = g.PairNumber.StartTime,
                                 EndTime = g.PairNumber.EndTime,
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
