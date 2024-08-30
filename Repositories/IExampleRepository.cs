using SampleBackendApp.Models;
using System.Collections.Generic;

namespace SampleBackendApp.Repositories
{
    public interface IExampleRepository
    {
        IEnumerable<Student> GetAll();
        Student Add(Student student);
    }
}
