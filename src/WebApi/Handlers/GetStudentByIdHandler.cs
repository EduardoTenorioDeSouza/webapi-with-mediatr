using MediatR;
using WebApi.Models;
using WebApi.Queries;
using WebApi.Repositories;

namespace WebApi.Handlers;

public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
{
    private readonly IStudentRepository _studentRepository;

    public GetStudentByIdHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Student> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
    {
        return await _studentRepository.GetStudentByIdAsync(query.Id);
    }
}