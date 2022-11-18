using Domain.Entities;
using Domain.Wrapper;
using Domain.Filters;

namespace Infrastructure.Services;

public interface IStudentService
{
    Task<Response<Student>> AddStudent(Student student);
    Task<PagedResponse<List<Student>>> GetStudents(PaginationFilter filter);

}