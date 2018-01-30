using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstCoreWebApplication.Context;
using MyFirstCoreWebApplication.Models;

namespace MyFirstCoreWebApplication.Data.Repository
{
    public class PeopleRepository : Repository<Person>, IPeopleRepository
    {
        public PeopleRepository(ApplicationContext context)
            : base(context)
        { }
    }
}
