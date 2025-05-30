namespace LazyLoading.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public int AuthorId {  get; set; }
        public string Title { get; set; } 
        public int NumberOfPages { get; set; }
        //Reset the Properties
        public virtual Author Author { get; set; }
    }
}
