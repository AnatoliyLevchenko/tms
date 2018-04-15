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
    class SqlRepository<T> : IRepository<T> where T : class
    {
        SystemDB db;
        public SqlRepository(SystemDB db)
        {
            this.db = db;
        }
        public void Create(T item)
        {
            db.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            db.Set<T>().Remove(item);
        }

        public T Get(Func<T,bool> filter)
        {
            return db.Set<T>().SingleOrDefault(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public void Update(T item)
        {
            db.Entry<T>(item).State = EntityState.Modified;
        }
    }
}
