using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagementSystem.DAL.Entities;
using TimeManagementSystem.DAL.Interfaces;

namespace TimeManagementSystem.DAL.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private SystemDB db;
        private ProjectRepository projectRepository;

        public UnitOfWork(string connectionString)
        {
            db = new SystemDB(connectionString);
        }
        public IRepository<Activity> Activities
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<ActivitiesInProject> ActivityInProject
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Person> Persons
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Project> Projects
        {
            get
            {
                if (projectRepository == null)
                    projectRepository = new ProjectRepository(db);
                return projectRepository;
            }
        }

        public IRepository<Report> Reports
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Risk> Risks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Role> Roles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Status> Statutes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Entities.Task> Tasks
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IRepository<Teammate> Teammates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
