using MyFirstCoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApplication.Data.Repository
{
    public interface IPeopleRepository
    {
        void Add(Person item);
        IEnumerable<Person> GetAll();
        Person Find(long key);
        void Remove(long key);
        void Update(Person item);
    }
}
