using MediatR;

namespace WebApi.Commands;

public class DeleteStudentCommand : IRequest<int>
{
    public int Id { get; set; }
}