using MediatR;
using WebApi.Commands;
using WebApi.Repositories;

namespace WebApi.Handlers;

public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
{
    private readonly IStudentRepository _studentRepository;

    public DeleteStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<int> Handle(DeleteStudentCommand command, CancellationToken cancellationToken)
    {
        var student = await _studentRepository.GetStudentByIdAsync(command.Id);

        return await _studentRepository.DeleteStudentAsync(student.Id);
    }
}