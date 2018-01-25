using MyFirstCoreWebApplication.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize(FirstContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
