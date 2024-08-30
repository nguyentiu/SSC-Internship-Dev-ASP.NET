using SampleBackendApp.Models;
using System.Collections.Generic;

namespace SampleBackendApp.Services
{
    public interface IExampleService
    {
        IEnumerable<Student> GetAllStudents();
        Student AddStudent(Student student);
    }
}
