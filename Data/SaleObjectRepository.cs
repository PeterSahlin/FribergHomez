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
        public async Task<List<SaleObject>> GetAllSalesObjectsAsync()
        {
            //return await applicationDbContext.SaleObjects.ToListAsync();
            return await applicationDbContext.SaleObjects
                .Include(s => s.Municipality)
                .Include(s => s.Category)
                .Include(s => s.Firm)
                .Include(s => s.RealEstateAgent)
                .ToListAsync();
        }
        public async Task GetSalesObjectByIdAsync(int id)
        {
            await applicationDbContext.SaleObjects.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddSalesObjectAsync(SaleObject saleobject)
        {
            applicationDbContext.SaleObjects.Add(saleobject);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteSalesObjectAsync(int id)
        {
            var salesObjectToDelete = await applicationDbContext.SaleObjects.FindAsync(id);
            if (salesObjectToDelete != null)
            {
                applicationDbContext.SaleObjects.Remove(salesObjectToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateSalesObjectAsync(SaleObject saleobject)
        {
            applicationDbContext.Entry(saleobject).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }
    }
}