using SampleBackendApp.Models;
using System.Collections.Generic;

namespace SampleBackendApp.Services
{
    public class ExampleService : IExampleService
    {
        private static readonly List<Student> _students = new List<Student>(); // Make sure the list is static

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public Student AddStudent(Student student)
        {
            _students.Add(student);
            return student;
        }
    }
}
