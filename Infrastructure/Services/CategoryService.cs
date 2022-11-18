using Domain.Entities;
using Domain.Wrapper;
using Domain.Filters;
using Infrastructure.Context;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CategoryServices : ICategoryService
{
    private readonly DataContext _context;

    public CategoryServices(DataContext context)
    {
        _context = context;
    }

    public async Task<Response<string>> DeleteCategory(int id)
    {
        var record = await _context.Categories.FindAsync(id);
        if (record == null) return new Response<string>(System.Net.HttpStatusCode.NotFound, "not found");
        _context.Categories.Remove(record);
        return new Response<string>("success");
    }

    public async Task<Response<List<Category>>> GetCategories()
    {
        var fin = await _context.Categories.ToListAsync();
        return new Response<List<Category>>(fin.ToList());
    }

    public async Task<Response<Category>> AddCategory(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return new Response<Category>(category);
    }

    public async Task<Response<Category>> UpdateCategory(Category category)
    {
        var record = await _context.Categories.FindAsync(category.Id);
        if (record == null) return new Response<Category>(System.Net.HttpStatusCode.NotFound, "not record found");
        record.Name = category.Name;
        await _context.SaveChangesAsync();
        return new Response<Category>(record);

    }

}