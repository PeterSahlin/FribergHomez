using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Thomas
    public class FirmRepository:IFirm
    {
        private readonly ApplicationDbContext applicationDbContext;

        public FirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<Firm>> GetAllFirmsAsync()
        {
            return await applicationDbContext.Firms.ToListAsync();
        }
        public async Task<Firm> GetFirmByIdAsync(int id)
        {
            return await applicationDbContext.Firms.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddFirmAsync(Firm firm)
        {
            applicationDbContext.Firms.Add(firm);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteFirmAsync(int id)
        {
            var firmToDelete = await applicationDbContext.Firms.FindAsync(id);
            if (firmToDelete != null)
            {
                applicationDbContext.Firms.Remove(firmToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateFirmAsync(Firm firm)
        {
            applicationDbContext.Entry(firm).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
