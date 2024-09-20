using StudentManagementSystem.Models;
namespace StudentManagementSystem.StudentServices
{
    public interface StudentService
    {
       Task<List<Student>> GetAllStudents();

        Task<List<Student>> AddStudent(Student student);

       Task<List<Student>> GetStudentByID(int id);
    }
}
