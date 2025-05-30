namespace EF6CodeFirstNewDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        public int DeptId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual Department Department { get; set; }
    }
}
