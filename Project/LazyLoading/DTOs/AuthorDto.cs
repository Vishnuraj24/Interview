using LazyLoading.Models;

namespace LazyLoading.DTOs
{
    public class AuthorDto
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        //reset the properties
        public List<BookDto> Books { get; set; }
    }
}
