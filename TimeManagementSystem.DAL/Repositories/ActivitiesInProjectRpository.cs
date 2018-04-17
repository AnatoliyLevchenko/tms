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
    class ActivitiesInProjectRpository : IRepository<ActivitiesInProject>
    {
        private SystemDB db;
        public ActivitiesInProjectRpository(SystemDB db)
        {
            this.db = db;
        }
        public void Create(ActivitiesInProject item)
        {
            db.ActivitiesInProjects.Add(item);
        }

        public void Delete(ActivitiesInProject item)
        {
            db.ActivitiesInProjects.Remove(item);
        }

        public ActivitiesInProject Get(Func<ActivitiesInProject, bool> filter)
        {
            return db.ActivitiesInProjects.Find(filter);
        }

        public IEnumerable<ActivitiesInProject> GetAll()
        {
            return db.ActivitiesInProjects;
        }

        public void Update(ActivitiesInProject item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
