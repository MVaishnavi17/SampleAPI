using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;
using System.Reflection.Metadata.Ecma335;

namespace StudentAPI.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Method to get all students.
        [HttpGet]
        [Route( "students" , Name = "GetAllStudents")]
        public IEnumerable<StudentModel> GetStudents()
        {
            return StudentRepository.Student;
        }

        [HttpGet]
        [Route("{id:int}" , Name = "GetStudentbyId")]
        public StudentModel GetStudentById(int id)
        {
            return StudentRepository.Student.FirstOrDefault( n => n.Id == id );
        }

        [HttpGet("{name:alpha}", Name = "GetStudentByName")]
        public StudentModel GetStudentByName(string name)
        {
            return StudentRepository.Student.FirstOrDefault( n => n.Name == name );
        }

        [HttpDelete("{id}", Name = "DeleteStudentById")]
        public bool DeleteStudent(int id)
        {
            var student = StudentRepository.Student.FirstOrDefault( n => n.Id == id);
            StudentRepository.Student.Remove( student );
            return true;
        }
    }
}
