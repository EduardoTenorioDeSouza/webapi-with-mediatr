using MediatR;
using WebApi.Commands;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Handlers;

public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
{
    private readonly IStudentRepository _studentRepository;

    public CreateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
    {
        var studentDetails = new Student
        {
            Name = command.Name,
            Email = command.Email,
            Address = command.Address,
            Age = command.Age
        };

        return await _studentRepository.AddStudentAsync(studentDetails);
    }
}