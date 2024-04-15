using FribergHomez.Models;

namespace FribergHomez.Data
{
    public interface ICategory
    {
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(Category category);
        Task DeleteCategoryAsync(int id);
        Task UpdateCategoryAsync(Category category);
    }
}
