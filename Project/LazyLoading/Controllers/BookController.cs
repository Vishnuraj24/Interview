using AutoMapper;
using LazyLoading.Data;
using LazyLoading.DTOs;
using LazyLoading.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LazyLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        
        public BookController(AppDbContext dbContext,IMapper mapper)
        {
         
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _dbContext.books.ToListAsync();

            //var books = await _dbContext.books.Include(b => b.Author).ToListAsync();

            //For executing the SP
            //_dbContext.Database.ExecuteSqlRaw()

            //List<BookDto>  = new List<BookDto>();
            
                var bookDtos = _mapper.Map<List<BookDto>>(books);
                

            return Ok(bookDtos);
             
        }
    }
}
