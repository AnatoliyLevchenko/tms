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
                throw new NotImplementedException();
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
