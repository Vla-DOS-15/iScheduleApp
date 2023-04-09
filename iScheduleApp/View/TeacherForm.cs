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
    public partial class TeacherForm : Form
    {
        TeacherGateway teacherGateway;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            teacherGateway = new TeacherGateway();
            GetPairNumber(comboBoxPairNumber, "StartTime", "PairNumberId");
            GetLessonType(comboBoxLessonType, "LessonTypeName", "LessonTypeId");
            GetGroupName(comboBoxGroupName, "GroupName", "Id");
            GetAuditoryNumber(comboBoxAuditoriumNumber, "AuditoriumNumber", "AuditoryId");
            teacherGateway.GetTable(dataGridView1);

        }
        public void GetPairNumber(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DataSource = teacherGateway.GetStartTimePair();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public void GetLessonType(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DataSource = teacherGateway.GetLessonType();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public void GetGroupName(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DataSource = teacherGateway.GetGroups();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        public void GetAuditoryNumber(System.Windows.Forms.ComboBox comboBox, string displayMember, string valueMember)
        {
            comboBox.DataSource = teacherGateway.GetAuditory();

            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                teacherGateway.Add(dateTimePicker1.Text, tbLessonName.Text, comboBoxPairNumber.Text, comboBoxGroupName.Text, comboBoxLessonType.Text, tbNameTeacher.Text, int.Parse(comboBoxAuditoriumNumber.Text));
                teacherGateway.GetTable(dataGridView1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
