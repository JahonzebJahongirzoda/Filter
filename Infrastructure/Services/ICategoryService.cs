using Domain.Entities;
using Domain.Wrapper;

namespace Infrastructure.Services;

public interface ICategoryService
{
    Task<Response<string>> DeleteCategory(int id);
    Task<Response<List<Category>>> GetCategories();
    Task<Response<Category>> AddCategory(Category category);
    Task<Response<Category>> UpdateCategory(Category category);
}