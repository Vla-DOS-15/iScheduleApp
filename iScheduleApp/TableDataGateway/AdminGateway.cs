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
    public class AdminGateway
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

        public void AddUser(string userName, string email, string password, string roleName)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Users.Load();
                    db.Roles.Load();

                    var roleId = db.Roles.FirstOrDefault(x => x.RoleName == roleName).RoleId;
                    var user = new User
                    {
                        UserName = userName,
                        Email = email,
                        Password = password,
                        IdRole = roleId
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddLessonType(string lessonTypeName)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.LessonTypes.Load();

                    var lessonType = new LessonType
                    {
                        LessonTypeName = lessonTypeName,
                    };
                    db.LessonTypes.Add(lessonType);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddTeacher(string teacherName)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Teachers.Load();

                    var teacher = new Teacher
                    {
                        FullName = teacherName,
                    };
                    db.Teachers.Add(teacher);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddAuditory(int buildingNumber, int floor, int auditoriumNumber)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Auditories.Load();

                    var auditory = new Auditory
                    {
                        BuildingNumber = buildingNumber,
                        Floor = floor,
                        AuditoriumNumber = auditoriumNumber
                    };
                    db.Auditories.Add(auditory);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddPairNumber(string startTime, string endTime)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.PairNumbers.Load();

                    var pairNumber = new PairNumber
                    {
                        StartTime = TimeSpan.Parse(startTime),
                        EndTime = TimeSpan.Parse(endTime)
                    };
                    db.PairNumbers.Add(pairNumber);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddFaculty(string facultyName)
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.PairNumbers.Load();

                    var faculty = new Faculty
                    {
                        FacultyName = facultyName
                    };
                    db.Faculties.Add(faculty);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Role> GetRoles()
        {
            List<Role> list = null;
            using (db = new ApplicationContext())
            {
                db.Users.Load();
                db.Roles.Load();
                list = db.Roles.ToList();
            }
            return list;
        }

        public void GetTableUsers(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {
               
                var result = from g in db.Users
                             
                             select new
                             {
                                 UserId = g.UserId,
                                 UserName = g.UserName,
                                 Email = g.Email,
                                 LessonType = g.Password,
                                 RoleName = g.Role.RoleName,

                             };

                dataGridView.DataSource = result.ToList();
            }
        }

        public void GetTableAuditory(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {

                var result = from g in db.Auditories

                             select new
                             {
                                 AuditoryId = g.AuditoryId,
                                 BuildingNumber = g.BuildingNumber,
                                 Floor = g.Floor,
                                 AuditoriumNumber = g.AuditoriumNumber,

                             };

                dataGridView.DataSource = result.ToList();
            }
        }

        public void GetTablePairNumber(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {

                var result = from g in db.PairNumbers

                             select new
                             {
                                 PairNumberId = g.PairNumberId,
                                 StartTime = g.StartTime,
                                 EndTime = g.EndTime,

                             };

                dataGridView.DataSource = result.ToList();
            }
        }
        public void GetTableLessonType(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {

                var result = from g in db.LessonTypes

                             select new
                             {
                                 LessonTypeId = g.LessonTypeId,
                                 LessonTypeName = g.LessonTypeName,

                             };

                dataGridView.DataSource = result.ToList();
            }
        }
        public void GetTableTeacher(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {

                var result = from g in db.Teachers

                             select new
                             {
                                 TeacherId = g.TeacherId,
                                 FullName = g.FullName,
                             };

                dataGridView.DataSource = result.ToList();
            }
        }
        public void GetTableFaculty(DataGridView dataGridView)
        {
            Load();
            using (db = new ApplicationContext())
            {

                var result = from g in db.Faculties

                             select new
                             {
                                 FacultyId = g.FacultyId,
                                 FacultyName = g.FacultyName,
                             };

                dataGridView.DataSource = result.ToList();
            }
        }
    }
}
