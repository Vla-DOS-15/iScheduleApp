using iScheduleApp.TableDataGateway;
using iScheduleApp.View;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace iScheduleApp
{
    public partial class LoginForm : Form
    {
        UserGateway userGateway;
        public LoginForm()
        {
            try
            {
                InitializeComponent();
                userGateway = new UserGateway();
                userGateway.Load();
                tbPassword.PasswordChar = '*';
                tbPassword.MaxLength = 12;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(userGateway.ReadRole(tbEMail.Text, tbPassword.Text).RoleName);
                userGateway = new UserGateway();
                userGateway.Load();
                if (userGateway.ReadRole(tbEMail.Text, tbPassword.Text).RoleName == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else if (userGateway.ReadRole(tbEMail.Text, tbPassword.Text).RoleName == "teacher")
                {
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.Show();
                }
                else if (userGateway.ReadRole(tbEMail.Text, tbPassword.Text).RoleName == "student")
                {
                    StudentForm studentForm = new StudentForm(userGateway.ReadUserName(tbEMail.Text, tbPassword.Text));
                    studentForm.Show();
                }
                else
                {
                    MessageBox.Show("Дані некоректні!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
