
using StudentManagementSystem.Models;

namespace StudentManagementSystem.StudentServices
{
    public interface CourseService
    {

        Task<List<Course>> GetAllCourses();
       

        Task<List<Course>> AddStudent(Course course);

        Task<List<Course>> GetStudentByID(int cid);

    }
}
