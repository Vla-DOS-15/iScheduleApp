using iScheduleApp.Models;
using iScheduleApp.TableDataGateway;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace iScheduleApp.View
{
    public partial class StudentForm : Form
    {
        ScheduleGateway scheduleGateway;
        public StudentForm()
        {
            InitializeComponent();

            GetGroup(comboBoxFaculty, "Faculty", "Id");
            GetGroup(comboBoxGroup, "GroupName", "Id");
        }
        public StudentForm(User studentName)
        {
            InitializeComponent();
            tbNameStudent.Text = studentName.UserName;
            GetGroup(comboBoxFaculty, "Faculty", "Id");
            GetGroup(comboBoxGroup, "GroupName", "Id");
            dataGridView1.Dock = DockStyle.Fill;
        }
        private ApplicationContext db;

        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                //GetGroup(comboBoxGroup, "GroupName", "Id");

                //GetGroup(comboBoxFaculty, "Faculty", "Id");
                using (db = new ApplicationContext())
                {
                    db.Roles.Load();
                    db.Users.Load();
                    db.Schedules.Load();
                    db.Groups.Load();
                    //dataGridView1.DataSource = db.Schedules.ToList();
                    //dataGridView1.DataMember = "Schedules";
                    var result = from g in db.Schedules where g.Group.GroupName == comboBoxGroup.Text && g.Date == DateTime.Parse(dateTimePicker1.Text) && g.Group.Faculty == comboBoxFaculty.Text

                                 select new
                                 {
                                     StartTime = g.PairNumber.StartTime,
                                     EndTime = g.PairNumber.EndTime,
                                     Date = g.Date,
                                     LessonName = g.LessonName,
                                     LessonType = g.LessonType.LessonTypeName,
                                     GroupName = g.Group.GroupName,
                                     Teacher = g.Teacher.FullName,
                                     BuildingNumber = g.Auditory.BuildingNumber,
                                     Floor = g.Auditory.Floor,
                                     AuditoriumNumber = g.Auditory.AuditoriumNumber,
                                 };
                    

                    dataGridView1.DataSource = result.ToList();

                    //dataGrid.ItemsSource = db.Accountings.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetGroup(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            scheduleGateway = new ScheduleGateway();
            comboBox.DataSource = scheduleGateway.GetGroups();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}
