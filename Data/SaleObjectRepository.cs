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
            
            return await applicationDbContext.SaleObjects
                .Include(s => s.Municipality)
                .Include(s => s.Category)
                .Include(s => s.RealEstateAgent)
                .Include(s => s.RealEstateAgent.Firm)
                .ToListAsync();
        }
        public async Task<List<SaleObject>> GetActiveSalesObjectsAsync()
        {
            return await applicationDbContext.SaleObjects
                .Include(s => s.Municipality)
                .Include(s => s.Category)
                .Include(s => s.RealEstateAgent)
                .Include(s => s.RealEstateAgent.Firm)
                .Where(s=>s.IsActive==true)
                .ToListAsync();
        }

        public async Task UpdateSalesObjectAsync(SaleObject saleobject)
        {
            applicationDbContext.Entry(saleobject).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<SaleObject> GetSalesObjectByIdAsync(int id)
        {
            return await applicationDbContext.SaleObjects
                .Include(s => s.Municipality)
                .Include(s => s.Category)
                .Include(s => s.RealEstateAgent)
                .Include(s => s.RealEstateAgent.Firm)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddSalesObjectAsync(SaleObject saleobject)
        {
           
            applicationDbContext.SaleObjects.Add(saleobject);
            //applicationDbContext.Entry(saleobject.Category).State = EntityState.Detached;
            //applicationDbContext.Entry(saleobject.Municipality).State = EntityState.Detached;
            //applicationDbContext.Entry(saleobject.RealEstateAgent).State = EntityState.Detached;
            try
            {
                await applicationDbContext.SaveChangesAsync();
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        public async Task DeleteSalesObjectAsync(int id)
        {
            var salesObjectToDelete = await applicationDbContext.SaleObjects.FindAsync(id);
            if (salesObjectToDelete != null)
            {
                salesObjectToDelete.IsActive = false;
                await applicationDbContext.SaveChangesAsync();
            }
        }
    }
}