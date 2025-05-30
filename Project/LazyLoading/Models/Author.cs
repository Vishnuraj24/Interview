namespace LazyLoading.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        //reset the properties
        public virtual List<Book> Books { get; set; }
    }
}
