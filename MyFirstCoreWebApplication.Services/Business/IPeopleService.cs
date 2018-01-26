using MyFirstCoreWebApplication.Data.Repository;
using MyFirstCoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCoreWebApplication.Services.Business
{
    
    public interface IPeopleService : IRepository<Person>    
    {
    }
}
