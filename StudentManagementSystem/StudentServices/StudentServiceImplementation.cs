using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.DatabaseConnection;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.StudentServices
{
    public class StudentServiceImplementation :StudentService
    {
        private readonly ApplicationDbContext _context;
        
        public StudentServiceImplementation(ApplicationDbContext context)
        {
            _context = context;
        }

        Task<List<Student>> StudentService.AddStudent(Student student)
        {
            _context.Students.Add(student);
            throw new NotImplementedException();
        }

        Task<List<Student>> StudentService.GetAllStudents()
        {
            _context.Students.ToListAsync();
            throw new NotImplementedException();
        }

        Task<List<Student>> StudentService.GetStudentByID(int id)
        {
            _context.Students.FindAsync(id);
            throw new NotImplementedException();
        }
    }

}
