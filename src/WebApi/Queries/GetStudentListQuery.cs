using MediatR;
using WebApi.Models;

namespace WebApi.Queries;

public class GetStudentListQuery : IRequest<List<Student>>
{
}