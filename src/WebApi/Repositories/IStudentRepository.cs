using WebApi.Models;

namespace WebApi.Repositories;

public interface IStudentRepository
{
    public Task<List<Student>> GetStudentListAsync();
    public Task<Student?> GetStudentByIdAsync(int id);
    public Task<Student> AddStudentAsync(Student student);
    public Task<int> UpdateStudentAsync(Student student);
    public Task<int> DeleteStudentAsync(int id);
}