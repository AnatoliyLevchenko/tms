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
    class ProjectRepository : IRepository<Project>
    {
        private SystemDB db;
        public ProjectRepository(SystemDB db)
        {
            this.db = db;
        }
        public void Create(Project item)
        {
            db.Projects.Add(item);
        }

        public void Delete(Project item)
        {
            db.Projects.Remove(item);
        }

        public Project Get(Func<Project, bool> filter)
        {
            return db.Projects.Find(filter);
        }

        public IEnumerable<Project> GetAll()
        {
            return db.Projects;
        }

        public void Update(Project item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
