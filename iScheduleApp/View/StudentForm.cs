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
        StudentGateway scheduleGateway;
        public StudentForm()
        {
            InitializeComponent();
        }

        public StudentForm(User studentName)
        {
            InitializeComponent();
            tbNameStudent.Text = studentName.UserName;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            GetFaculty(comboBoxFaculty, "FacultyName", "FacultyId");
            GetGroup(comboBoxGroup, "GroupName", "Id");
        }

        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                scheduleGateway.GetTable(dataGridView1, comboBoxGroup.Text, comboBoxDay.Text, comboBoxFaculty.Text, comboBoxCourse.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetGroup(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            scheduleGateway = new StudentGateway();
            comboBox.DataSource = scheduleGateway.GetGroups();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public void GetFaculty(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            scheduleGateway = new StudentGateway();
            comboBox.DataSource = scheduleGateway.GetFaculties();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

    }
}
