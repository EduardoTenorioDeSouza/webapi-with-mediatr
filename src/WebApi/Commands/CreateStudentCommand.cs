using MediatR;
using WebApi.Models;

namespace WebApi.Commands;

public class CreateStudentCommand : IRequest<Student>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }

    public CreateStudentCommand(string name, string email, string address, int age)
    {
        Name = name;
        Email = email;
        Address = address;
        Age = age;
    }
}