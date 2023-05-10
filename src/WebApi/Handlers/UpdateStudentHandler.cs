using MediatR;
using WebApi.Commands;
using WebApi.Repositories;

namespace WebApi.Handlers;

public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
{
    private readonly IStudentRepository _studentRepository;

    public UpdateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<int> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
    {
        var student = await _studentRepository.GetStudentByIdAsync(command.Id);

        student.Name = command.Name;
        student.Email = command.Email;
        student.Address = command.Address;
        student.Age = command.Age;

        return await _studentRepository.UpdateStudentAsync(student);
    }
}