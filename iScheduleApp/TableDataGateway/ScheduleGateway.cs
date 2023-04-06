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
    public class ScheduleGateway
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
    }
}
