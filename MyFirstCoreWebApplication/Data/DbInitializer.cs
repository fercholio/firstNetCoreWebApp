using MyFirstCoreWebApplication.Context;
using MyFirstCoreWebApplication.Models;
using MyFirstCoreWebApplication.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApplication.Data
{
    public class DbInitializer
    {
        public static void Initialize()
        {
        }

        public static async Task Initialize(ApplicationContext context, IPeopleService peopleService)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Persons.Any())
            {
                return; // DB has been seeded
            }

            await CreateDefaultPerson(context,peopleService);
        }

        private static async Task CreateDefaultPerson(ApplicationContext context, IPeopleService peopleService)
        {
            var person = new Person
            {
                FirstName = "My first data",
                LastName = "My Lastname data",
                Age = 30
            };

           await peopleService.Insert(person);
        }
    }
}
