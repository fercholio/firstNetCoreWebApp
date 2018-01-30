using MyFirstCoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApplication.Data.Repository
{
    public interface IPeopleRepository: IRepository<Person>
    {
    }
}
