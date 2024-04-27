using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Thomas
    public class FirmRepository : IFirm
    {
        private readonly ApplicationDbContext applicationDbContext;

        public FirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateFirmAsync(Firm firm)
        {
            applicationDbContext.Add(firm);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteFirmAsync(int id)
        {
            var firmToDelete = await applicationDbContext.Firms.FindAsync(id);
            if (firmToDelete != null)
            {
                firmToDelete.IsActive = false;
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateFirmAsync(Firm firm)
        {
            applicationDbContext.Entry(firm).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Firm>> GetAllFirmsAsync()
        {
            return await applicationDbContext.Firms.ToListAsync();
        }
        public async Task<Firm> GetFirmByIdAsync(int id)
        {
            return await applicationDbContext.Firms.FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
