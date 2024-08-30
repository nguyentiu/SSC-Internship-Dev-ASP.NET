using SampleBackendApp.Models;
using System.Collections.Generic;

namespace SampleBackendApp.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student Add(Student student)
        {
            _students.Add(student);
            return student;
        }
    }
}
