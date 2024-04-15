using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    public class CategoryRepository:ICategory
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await applicationDbContext.Categories.ToListAsync();
        }
        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await applicationDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddCategoryAsync(Category category)
        {
            applicationDbContext.Categories.Add(category);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteCategoryAsync(int id)
        {
            var categoryToDelete = await applicationDbContext.Categories.FindAsync(id);
            if (categoryToDelete != null)
            {
                applicationDbContext.Categories.Remove(categoryToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateCategoryAsync(Category category)
        {
            applicationDbContext.Entry(category).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
