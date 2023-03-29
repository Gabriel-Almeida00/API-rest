using API_rest.Bussiness;
using API_rest.Bussiness.Implementation;
using API_rest.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_rest.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]/v{version:apiVersion}")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private BooksServiceImpl _booksService;

        public BookController(ILogger<BookController> logger, BooksServiceImpl booksService)
        {
            _logger = logger;
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_booksService.FindAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _booksService.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_booksService.Create(book));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null) return BadRequest();
            return Ok(_booksService.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _booksService.Delete(id);
            return NoContent();
        }
    }
}
