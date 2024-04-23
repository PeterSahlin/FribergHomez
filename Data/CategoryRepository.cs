using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateCategoryAsync(Category category)
        {
            applicationDbContext.Add(category);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var categoryToDelete = applicationDbContext.Categories.Where(s => s.Id == id).FirstOrDefault();
                applicationDbContext.Remove(categoryToDelete);
                await applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            applicationDbContext.Entry(category).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()                               //ienumerable?
        {
            return await applicationDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await applicationDbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
