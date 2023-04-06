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
    public class UserGateway
    {
        private ApplicationContext db;
        public void Load()
        {
            try
            {
                using (db = new ApplicationContext())
                {
                    db.Roles.Load();
                    db.Users.Load();
                    //dataGrid.ItemsSource = db.Accountings.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Role ReadRole(string eMail, string password)
        {
            Role role = null;
            using (db = new ApplicationContext())
            {
                role = db.Users.Include(x => x.Role).FirstOrDefault(x => x.Email.Trim() == eMail.Trim() && x.Password.Trim() == password.Trim()).Role;
            }
            return role;
        }
        public User ReadUserName(string eMail, string password)
        {
            User userName = null;
            using (db = new ApplicationContext())
            {
                userName = db.Users.Include(x => x.Role).FirstOrDefault(x => x.Email.Trim() == eMail.Trim() && x.Password.Trim() == password.Trim());
            }
            return userName;
        }

    }
}
