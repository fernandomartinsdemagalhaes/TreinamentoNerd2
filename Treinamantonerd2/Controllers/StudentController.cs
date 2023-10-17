using Microsoft.AspNetCore.Mvc;
using Treinamantonerd2.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Treinamantonerd2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            Student student01 = new Student();

            student01.FirstName = value.FirstName;
            student01.LastName = value.LastName; 
            student01.Weight = value.Weight;
            student01.Height = value.Height;

            using (var contextSQL = new ContextSQL())
            {
                contextSQL.Students.Add(student01);
                contextSQL.SaveChanges();
            }


        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
