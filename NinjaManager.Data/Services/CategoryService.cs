using NinjaManager.Data.Models;

namespace NinjaManager.Data.Services;

public class CategoryService(MainContext context)
{
    public List<Category> GetCategories()
    {
        return context.Categories.ToList();
    }
}