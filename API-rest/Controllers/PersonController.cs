using API_rest.Model;
using API_rest.Bussiness;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API_rest.Data.VO;

namespace API_rest.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]/v{version:apiVersion}")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        private IPersonService _personService;

      
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

    
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindByID(id);
            if (person == null) return NotFound();
            return Ok(person);
        }


        [HttpPost]
        public IActionResult Post([FromBody] PersonVO PersonVO)
        {
            if (PersonVO == null) return BadRequest();
            return Ok(_personService.Create(PersonVO));
        }

  
        [HttpPut]
        public IActionResult Put([FromBody] PersonVO PersonVO)
        {
            if (PersonVO == null) return BadRequest();
            return Ok(_personService.Update(PersonVO));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
