using MyFirstCoreWebApplication.Context;
using MyFirstCoreWebApplication.Data.Repository;
using MyFirstCoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCoreWebApplication.Services.Business
{
    public class PeopleService : Repository<Person>, IPeopleService
    {
        public PeopleService(ApplicationContext context)
            : base(context)
        { }
    }
}
