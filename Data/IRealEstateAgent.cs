using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Peter
    public interface IRealEstateAgent
    {
        Task<List<RealEstateAgent>> GetAllRealEstateAgentsAsync();
        Task <RealEstateAgent> GetRealEstateAgentByIdAsync(string id);
        Task AddRealEstateAgentAsync(RealEstateAgent realEstateAgent);
        Task DeleteRealEstateAgentAsync(string id);
        Task RealEstateAgentDeletePermanently(string id);
        Task UpdateRealEstateAgentAsync(RealEstateAgent realEstateAgent);
    }
}
