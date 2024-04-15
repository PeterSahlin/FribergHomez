using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Peter
    public interface IRealEstateAgent
    {
        Task<List<RealEstateAgent>> GetAllAgentsAsync();
        Task<RealEstateAgent> GetAgentByIdAsync(int id);
        Task AddAgentAsync(RealEstateAgent agent);
        Task DeleteAgentAsync(int id);
        Task UpdateAgentAsync(RealEstateAgent agent);
    }
}
