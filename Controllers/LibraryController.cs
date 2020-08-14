using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.models;
using LibraryAPI.repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        private readonly ILibraryRepository _repo;
        public LibraryController(ILibraryRepository repo)
        {
            _repo = repo;
        }
        // GET api/todos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            return new ObjectResult(await _repo.GetAllBooks());
        }
        // GET api/book/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            var book = await _repo.GetBook(id);
            if (book == null)
                return new NotFoundResult();

            return new ObjectResult(book);
        }
        // POST api/book
        [HttpPost]
        public async Task<ActionResult<Book>> Post([FromBody] Book book)
        {
            //book.ISBN =(int) await _repo.GetNextId();
            await _repo.Create(book);
            return new OkObjectResult(book);
        }
        // PUT api/book/1
        [HttpPut]
        public async Task<ActionResult<Book>> Put([FromBody] Book book)
        {
            var bookFromDb = await _repo.GetBook(book.Id);
            if (bookFromDb == null)
                return new NotFoundResult();
            book.Id = bookFromDb.Id;
            await _repo.Update(book);
            return new OkObjectResult(book);
        }
        // DELETE api/book/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await _repo.GetBook(id);
            if (post == null)
                return new NotFoundResult();
            await _repo.Delete(id);
            return new OkResult();
        }
    }
}
