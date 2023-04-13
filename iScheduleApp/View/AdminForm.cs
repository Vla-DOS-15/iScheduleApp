using iScheduleApp.TableDataGateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iScheduleApp.View
{
    public partial class AdminForm : Form
    {
        AdminGateway adminGateway;
        public AdminForm()
        {
            InitializeComponent();
            GetFaculty(comboBoxRole, "RoleName", "RoleId");
        }
        public void GetFaculty(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            adminGateway = new AdminGateway();
            comboBox.DataSource = adminGateway.GetRoles();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            adminGateway = new AdminGateway();
            adminGateway.Load();
            adminGateway.AddUser(tbUserName.Text, tbEmail.Text, tbPassword.Text, comboBoxRole.Text);
            adminGateway.Load();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            adminGateway = new AdminGateway();
            adminGateway.Load();
            adminGateway.GetTableUsers(dataGridViewUsers);
            adminGateway.GetTableAuditory(dataGridViewAuditory);
            adminGateway.GetTablePairNumber(dataGridViewPairNumber);
            adminGateway.GetTableLessonType(dataGridViewLessonType);
            adminGateway.GetTableTeacher(dataGridViewTeacher);
            adminGateway.GetTableFaculty(dataGridViewFaculty);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            adminGateway = new AdminGateway();
            adminGateway.Load();
            adminGateway.AddTeacher(tbTeacherName.Text);
            adminGateway.Load();
        }

        private void btnAddFacultyName_Click(object sender, EventArgs e)
        {
            adminGateway = new AdminGateway();
            adminGateway.Load();
            adminGateway.AddFaculty(tbFacultyName.Text);
            adminGateway.Load();
        }

        private void btnAddAuditory_Click(object sender, EventArgs e)
        {
            adminGateway = new AdminGateway();
            adminGateway.Load();
            adminGateway.AddAuditory(int.Parse(numericUpDownBuildingNumber.Value.ToString()), int.Parse(numericUpDownFloor.Value.ToString()), int.Parse(numericUpDownAuditoriumNumber.Value.ToString()));
            adminGateway.Load();
        }


    }
}
