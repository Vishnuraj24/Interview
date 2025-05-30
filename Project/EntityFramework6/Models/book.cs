namespace EntityFramework6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class book
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }

        [Required]
        public string Title { get; set; }

        public int NumberOfPages { get; set; }

        public virtual author author { get; set; }
    }
}
