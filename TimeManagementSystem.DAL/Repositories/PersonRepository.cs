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
    class PersonRepository : IRepository<Person>
    {
        SystemDB db;
        public PersonRepository(SystemDB db)
        {
            this.db = db;
        }
        public void Create(Person item)
        {
            db.Persons.Add(item);
            db.SaveChanges();
        }

        public void Delete(Person item)
        {
            db.Persons.Remove(item);
            db.SaveChanges();
        }

        public Person Get(Func<Person, bool> filter)
        {
            return db.Persons.Find(filter);
        }

        public IEnumerable<Person> GetAll()
        {
            return db.Persons;
        }

        public void Update(Person item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
