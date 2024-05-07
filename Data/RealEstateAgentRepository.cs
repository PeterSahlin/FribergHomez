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

        public async Task DeleteRealEstateAgentAsync(string id)
        {
            var realEstateAgentToDelete = await applicationDbContext.RealEstateAgents.FindAsync(id);
            if (realEstateAgentToDelete != null)
            {
                realEstateAgentToDelete.IsActive = false;
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task RealEstateAgentDeletePermanently(string id)
        {
            var realEstateAgentToDelete = await applicationDbContext.RealEstateAgents.FindAsync(id);
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
            return await applicationDbContext.RealEstateAgents
                .Include(r => r.Firm)
                .ToListAsync();
        }

        public async Task<RealEstateAgent> GetRealEstateAgentByIdAsync(string id)
        {
            return await applicationDbContext.RealEstateAgents
                .Include(r => r.Firm)
                .FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
