using WebApi.Models;

namespace WebApi.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly List<Student> _students = new();

    public StudentRepository()
    {
        _students.Add(new Student { Id = 1, Name = "maria", Address = "rua a", Age = 16, Email = "maria@gmail.com" });
        _students.Add(new Student { Id = 2, Name = "edu", Address = "rua b", Age = 17, Email = "edu@gmail.com" });
        _students.Add(new Student { Id = 3, Name = "leo", Address = "rua c", Age = 18, Email = "leo@gmail.com" });
    }

    public Task<Student> AddStudentAsync(Student student)
    {
        _students.Add(student);
        return Task.FromResult(student);
    }

    public Task<int> DeleteStudentAsync(int id)
    {
        var result = _students.RemoveAll(c => c.Id == id);
        return Task.FromResult(result);
    }

    public Task<Student?> GetStudentByIdAsync(int id)
    {
        var student = _students.FirstOrDefault(c => c.Id == id);

        return Task.FromResult(student);
    }

    public Task<List<Student>> GetStudentListAsync()
    {
        return Task.FromResult(_students);
    }

    public Task<int> UpdateStudentAsync(Student student)
    {
        var index = _students.FindIndex(x => x.Id == student.Id);
        if (index > -1)
        {
            _students[index] = student;
        }

        return Task.FromResult(index);
    }
}