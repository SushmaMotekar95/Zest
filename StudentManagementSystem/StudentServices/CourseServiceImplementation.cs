using Microsoft.AspNetCore.Razor.TagHelpers;
using StudentManagementSystem.DatabaseConnection;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.StudentServices
{
    public class CourseServiceImplementation : CourseService
    {
        private readonly ApplicationDbContext _context;


        Task<List<Course>> CourseService.AddStudent(Course course)
        {
            throw new NotImplementedException();
        }

        Task<List<Course>> CourseService.GetAllCourses()
        {
            throw new NotImplementedException();
        }

        Task<List<Course>> CourseService.GetStudentByID(int cid)
        {
            throw new NotImplementedException();
        }
    }
}
