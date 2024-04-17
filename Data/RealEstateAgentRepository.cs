using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Peter
    public class RealEstateAgentRepository : IRealEstateAgent
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RealEstateAgentRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task AddRealEstateAgentAsync(RealEstateAgent realEstateAgent)
        {
            applicationDbContext.Add(realEstateAgent);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteRealEstateAgentAsync(int id)
        {
            var realEstateAgentToDelete = await applicationDbContext.Realtors.FindAsync(id);
            if (realEstateAgentToDelete != null)
            {
                applicationDbContext.Remove(realEstateAgentToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateRealEstateAgentAsync(RealEstateAgent realEstateAgent)
        {
            applicationDbContext.Entry(realEstateAgent).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<RealEstateAgent>> GetAllRealEstateAgentsAsync()
        {
            return await applicationDbContext.Realtors.ToListAsync();
        }

        public async Task<RealEstateAgent> GetRealEstateAgentByIdAsync(int id)
        {
            return await applicationDbContext.Realtors.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
