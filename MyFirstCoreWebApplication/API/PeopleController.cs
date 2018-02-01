using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstCoreWebApplication.Data.Repository;
using MyFirstCoreWebApplication.Models;
using MyFirstCoreWebApplication.Services.Business;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstCoreWebApplication.API
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private IPeopleService peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var personList = peopleService.GetAll().Result;

            return personList.ToArray();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ObjectResult Get(long id)
        {
           var person = peopleService.Get(id);

            return Ok(person);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
