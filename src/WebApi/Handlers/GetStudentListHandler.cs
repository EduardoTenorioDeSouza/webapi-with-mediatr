using MediatR;
using WebApi.Models;
using WebApi.Queries;
using WebApi.Repositories;

namespace WebApi.Handlers;

public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
{
    private readonly IStudentRepository _studentRepository;

    public GetStudentListHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<List<Student>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
    {
        return await _studentRepository.GetStudentListAsync();
    }
}