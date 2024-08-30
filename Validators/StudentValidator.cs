using FluentValidation;
using SampleBackendApp.Models;

namespace SampleBackendApp.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Age).GreaterThan(0).WithMessage("Age must be greater than 0.");
            RuleFor(x => x.Grade).NotEmpty().WithMessage("Grade is required.");
        }
    }
}
