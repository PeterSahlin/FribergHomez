using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Henrik
    public class SaleObjectRepository:ISaleObject
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SaleObjectRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateSaleObjectAsync(SaleObject saleObject)
        {
            applicationDbContext.Add(saleObject);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteSaleObjectAsync(SaleObject saleObject)
        {
            applicationDbContext.Remove(saleObject);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task EditSaleObjectAsync(SaleObject saleObject)
        {
            applicationDbContext.Update(saleObject);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<SaleObject>> GetAllSaleObjectsAsync()
        {
            return await applicationDbContext.SaleObjects.OrderBy(s => s.Id).ToListAsync();
        }

        public async Task<SaleObject> GetSaleObjectByIdAsync(int id)
        {
            return await applicationDbContext.SaleObjects.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}