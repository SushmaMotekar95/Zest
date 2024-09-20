namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string contact;
        public string Email { get; set; }
        public string Address { get; set; } = string.Empty;
        public Course Course { get; set; }
        public Student() { }

        public Student(int id, string name, string contact, string email, string adress, Course course)
        {
            Id = id;
            Name = name;
            this.contact = contact;
            Email = email;
            this.Address = adress;
            Course = course;
        }
    }
}
