using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.StudentServices;
using StudentManagementSystem.Models;
namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents() { 
        
               await     _studentService.GetAllStudents();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student cannot be null.");
            }

            try
            {
                
                await _studentService.AddStudent(student);

                
                var students = await _studentService.GetAllStudents();

               
                return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
            }
            catch (Exception ex)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, "Error adding student: " + ex.Message);
            }
        }
        [HttpGet("/id")]
        public async Task<ActionResult<List<Student>>> GetStudentById(int id) { 
        
         var students=await _studentService.GetStudentByID(id);
            return Ok(students);
        
        
        }
    }
}
