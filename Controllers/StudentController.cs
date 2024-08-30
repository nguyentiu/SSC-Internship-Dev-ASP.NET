using Microsoft.AspNetCore.Mvc;
using SampleBackendApp.Models;
using SampleBackendApp.Services;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IExampleService _service;

    public StudentController(IExampleService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        var students = _service.GetAllStudents();
        return Ok(students);
    }

    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        var addedStudent = _service.AddStudent(student);
        return CreatedAtAction(nameof(GetStudents), new { id = addedStudent.Id }, addedStudent);
    }
}
