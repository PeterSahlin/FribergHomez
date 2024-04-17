using FribergHomez.Models;

namespace FribergHomez.Data
{
    public interface ICategory
    {
        Task CreateCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(Category category);
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
    }
}
