using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Peter
    public class RealEstateAgentRepository:IRealEstateAgent
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RealEstateAgentRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<RealEstateAgent>> GetAllAgentsAsync()
        {
            return await applicationDbContext.Realtors
                .Include(s => s.Firm)
                .ToListAsync();
        }
        public async Task<RealEstateAgent> GetAgentByIdAsync(int id)
        {
            return await applicationDbContext.Realtors.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddAgentAsync(RealEstateAgent agent)
        {
            applicationDbContext.Realtors.Add(agent);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteAgentAsync(int id)
        {
            var agentToDelete = await applicationDbContext.Realtors.FindAsync(id);
            if (agentToDelete != null)
            {
                applicationDbContext.Realtors.Remove(agentToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateAgentAsync(RealEstateAgent agent)
        {
            applicationDbContext.Entry(agent).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
