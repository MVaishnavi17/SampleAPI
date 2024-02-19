using Microsoft.AspNetCore.Mvc.Testing;
using StudentAPI.Controllers;

namespace StudentAPI_Test
{
    [TestFixture]
    public class Tests
    {
        // Function to test whether the given name is same as the name with the provided id.
        [Test]
        public void TestStudentName()
        {
            var student = new StudentController();
            Assert.That( student.GetStudentById( 1 ).Name, Is.EqualTo( "Vaishnavi" ) );
        }

        // Function to test the student object is null/ not null.
        [Test]
        public void TestStudentIsNotNull()
        {
            var student = new StudentController();
            var Allstudents = student.GetStudents();
            Assert.IsNotNull( Allstudents );

        }

        // Function to test the method not throwing error while getting the student by given id.
        [Test]
        public void TestStudentNameById()
        {
            var student = new StudentController();
            Assert.DoesNotThrow( () => student.GetStudentById( 8 ) );
        }

        // Ignore test case.
        [Ignore( "Ignore test" )]
        public void IgnoreTest()
        {
            var student = new StudentController();
            Assert.DoesNotThrow( () => student.GetStudentById( 8 ) );
        }
    }
}