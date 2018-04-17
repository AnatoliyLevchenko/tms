using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManagementSystem.DAL.Entities;
using TimeManagementSystem.DAL.Interfaces;

namespace TimeManagementSystem.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private SystemDB _db;
        private ProjectRepository _projectRepository;
        private ActivitiesInProjectRepository _activitiesInProjectRepository;
        private ActivityRepository _activityRepository;
        private PersonRepository _personRepository;
        private ReportRepository _reportRepository;
        private RiskRepository _riskRepository;
        private RoleRepostory _roleRepository;
        private StatusRepository _statusRepository;
        private TaskRepository _taskRepository;
        private TeammateRepository _teammateRepository;

        public UnitOfWork(string connectionString)
        {
            _db = new SystemDB(connectionString);
        }
        public IRepository<Activity> Activities
        {
            get
            {
                (_activityRepository == null) ? (_activityRepository = new ActivityRepository(_db));
                return _activityRepository;
            }
        }

        public IRepository<ActivitiesInProject> ActivityInProject
        {
            get
            {
                (_activitiesInProjectRepository == null) ? (_activitiesInProjectRepository = new ActivitiesInProjectRepository(_db));
                return _activitiesInProjectRepository;
            }
        }

        public IRepository<Person> Persons
        {
            get
            {
                (_personRepository == null)?(_personRepository = new PersonRepository(_db));
                return _personRepository;
            }
        }

        public IRepository<Project> Projects
        {
            get
            {
                if (_projectRepository == null)
                    _projectRepository = new ProjectRepository(_db);
                return _projectRepository;
            }
        }

        public IRepository<Report> Reports
        {
            get
            {
                (_reportRepository == null) ? (_reportRepository = new ReportRepository(_db));
                return _reportRepository;
            }
        }

        public IRepository<Risk> Risks
        {
            get
            {
                (_riskRepository == null) ? (_riskRepository = new RiskRepository(_db));
                return _riskRepository;
            }
        }

        public IRepository<Role> Roles
        {
            get
            {
                (_roleRepository == null) ? (_roleRepository = new RoleRepostory(_db));
                return _roleRepository;
            }
        }

        public IRepository<Status> Statuses
        {
            get
            {
                (_statusRepository == null) ? (_statusRepository = new StatusRepository(db));
                return _statusRepository;
            }
        }

        public IRepository<Entities.Task> Tasks
        {
            get
            {
                (_taskRepository == null) ? (_taskRepository = new TaskRepository(_db));
                return _taskRepository;
            }
        }

        public IRepository<Teammate> Teammates
        {
            get
            {
                (_teammateRepository == null) ? (_teammateRepository = new TeammateRepository(_db));
                return _teammateRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
