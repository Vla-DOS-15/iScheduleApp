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

        }
        private ApplicationContext db;

        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                GetGroup(comboBoxGroup, "GroupName", "Id");

                GetGroup(comboBoxFaculty, "Faculty", "Id");
                using (db = new ApplicationContext())
                {
                    db.Roles.Load();
                    db.Users.Load();
                    db.Schedules.Load();
                    dataGridView1.DataSource = db.Schedules.ToList();
                    dataGridView1.DataMember = "Schedules";
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
