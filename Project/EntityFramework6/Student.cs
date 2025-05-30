namespace EntityFramework6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string StudentName { get; set; }

        [Required]
        [StringLength(255)]
        public string StudentGender { get; set; }

        public int Age { get; set; }

        public int Standard { get; set; }

        [Required]
        [StringLength(255)]
        public string FatherName { get; set; }
    }
}
