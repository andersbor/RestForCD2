using Microsoft.AspNetCore.Mvc;
using RestForCD2.Repositories;

namespace RestForCD2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringsController : ControllerBase
    {
        private StringsRepository repo = new();
        
        // GET: api/<StringsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return repo.GetAll();
        }

        // GET api/<StringsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StringsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            repo.Add(value);
        }

        // PUT api/<StringsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StringsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
