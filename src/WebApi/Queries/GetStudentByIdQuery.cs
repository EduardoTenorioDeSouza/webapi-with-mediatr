using MediatR;
using WebApi.Models;

namespace WebApi.Queries;

public class GetStudentByIdQuery : IRequest<Student>
{
    public int Id { get; set; }
}