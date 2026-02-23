using Microsoft.AspNetCore.Mvc;
using RESTWithASPNET10.Model;
using RESTWithASPNET10.Service;

namespace RESTWithASPNET10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personServices.FindById(id);
            if(person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var createdPerson = _personServices.Create(person);
            if (createdPerson == null) return NotFound();
            return Ok(createdPerson);
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var createdPerson = _personServices.Update(person);
            if (createdPerson == null) return NotFound();
            return Ok(createdPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personServices.Delete(id);
            return NoContent();
        }

    }
}
