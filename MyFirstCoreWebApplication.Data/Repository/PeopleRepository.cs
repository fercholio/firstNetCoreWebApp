using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstCoreWebApplication.Context;
using MyFirstCoreWebApplication.Models;

namespace MyFirstCoreWebApplication.Data.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ApplicationContext _context;

        public PeopleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void Add(Person item)
        {
            _context.Persons.Add(item);
            _context.SaveChanges();
        }

        public Person Find(long key)
        {
            return _context.Persons.FirstOrDefault(p => p.Id == key);
        }

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public void Remove(long key)
        {
            var entity = _context.Persons.First(p => p.Id == key);
            if(entity == null)
            {
                throw new Exception("Error searching entity");
            }

            _context.Persons.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Person item)
        {
            _context.Persons.Update(item);
            _context.SaveChanges();
        }
    }
}
