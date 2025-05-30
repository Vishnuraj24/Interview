using LazyLoading.Models;

namespace LazyLoading.DTOs
{
    public class BookDto
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }

        public AuthorDto Author { get; set; }

    }
}
