using Domain.Entities;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("controller")]
public class CategoryController:ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService )
    {
        _categoryService = categoryService;
    }

    [HttpGet ("getCategory")]
    public async Task<Response<List<Category>>> GetCategory()
    {
        return await  _categoryService.GetCategories();
    }
    
    [HttpPut ("updateCategory")]
    public async Task<Response<Category>> UpdateCategory(Category category)
    {
        return await  _categoryService.UpdateCategory(category);
    }
    
    [HttpDelete ("deleteCategory")]
    public async Task<Response<string>> DeleteCategory(int id)
    {
        return await  _categoryService.DeleteCategory(id);
    }
    
    [HttpPost("addCategory")]
    public async Task<Response<Category>> AddCategory(Category category)
    {
        return await  _categoryService.AddCategory(category);
    }
    
    

}