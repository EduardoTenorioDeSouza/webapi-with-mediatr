using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Commands;
using WebApi.Models;
using WebApi.Queries;

namespace WebApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Student>> GetStudentListAsync()
        {
            var student = await _mediator.Send(new GetStudentListQuery());

            return student;
        }

        [HttpGet("id")]
        public async Task<Student> GetStudentByIdAsync(int id)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery { Id = id });

            return student;
        }

        [HttpPost]
        public async Task<Student> AddStudentAsync(Student student)
        {
            var studentResponse = await _mediator.Send(new CreateStudentCommand(
                student.Name,
                student.Email,
                student.Address,
                student.Age));

            return studentResponse;
        }

        [HttpPut]
        public async Task<int> UpdateStudentAsync(Student student)
        {
            var isStudentUpdated = await _mediator.Send(new UpdateStudentCommand(
                student.Id,
                student.Name,
                student.Email,
                student.Address,
                student.Age));

            return isStudentUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int id)
        {
            return await _mediator.Send(new DeleteStudentCommand { Id = id });
        }
    }
}
