using Microsoft.AspNetCore.Mvc;
using RestForCD2.Models;
using RestForCD2.Repositories;

namespace RestForCD2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly TeachersRepository repo = new();

        // GET: api/<StringsController>
        [HttpGet]
        public IEnumerable<Teacher> Get([FromQuery] string? name)
        {
            return repo.Get(name);
        }

        // GET api/<StringsController>/5
        [HttpGet("{id}")]
        public Teacher? Get(int id)
        {
            return repo.GetById(id);
        }

        // POST api/<StringsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Teacher> Post([FromBody] Teacher value)
        {
            try
            {
                Teacher newTeacher = repo.Add(value);
                string uri = Url.RouteUrl(RouteData.Values) + "/" + newTeacher.Id;
                return Created(uri, newTeacher);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
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
