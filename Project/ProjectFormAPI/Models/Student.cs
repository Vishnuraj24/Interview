namespace ProjectFormAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int Age { get; set; }
        public int Standard { get; set; }

    }
}
