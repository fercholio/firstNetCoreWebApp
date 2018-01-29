using MyFirstCoreWebApplication.Context;
using MyFirstCoreWebApplication.Data.Repository;
using MyFirstCoreWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCoreWebApplication.Data.Seed
{
    public class Seed
    {
        private ApplicationContext applicationContext;

        public Seed(ApplicationContext context)
        {
            this.applicationContext = context;
        }

        public async Task SeedData()
        {
        }
    }
}
