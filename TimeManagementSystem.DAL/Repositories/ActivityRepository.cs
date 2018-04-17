using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagementSystem.DAL.Entities;
using TimeManagementSystem.DAL.Interfaces;

namespace TimeManagementSystem.DAL.Repositories
{
    class ActivityRepository : IRepository<Activity>
    {
        SystemDB db;
        public ActivityRepository(SystemDB db)
        {
            this.db = db;
        }
        public void Create(Activity item)
        {
            db.Activities.Add(item);
        }

        public void Delete(Activity item)
        {
            db.Activities.Remove(item);
        }

        public Activity Get(Func<Activity, bool> filter)
        {
            return db.Activities.Find(filter);
        }

        public IEnumerable<Activity> GetAll()
        {
            return db.Activities;
        }

        public void Update(Activity item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
