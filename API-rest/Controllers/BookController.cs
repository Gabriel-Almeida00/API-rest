using API_rest.Bussiness;
using API_rest.Bussiness.Implementation;
using API_rest.Data.VO;
using API_rest.HyperMedia.Filters;
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_booksService.FindAll());
        }


        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var book = _booksService.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);
        }


        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] BookVO book)
        {
            if (book == null) return BadRequest();
            return Ok(_booksService.Create(book));
        }


        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] BookVO book)
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
