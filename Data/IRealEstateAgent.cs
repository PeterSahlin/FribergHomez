using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Peter
    public interface IRealEstateAgent
    {
        Task<List<RealEstateAgent>> GetAllRealEstateAgentsAsync();
        Task <RealEstateAgent> GetRealEstateAgentByIdAsync(Guid id);
        Task AddRealEstateAgentAsync(RealEstateAgent realEstateAgent);
        Task DeleteRealEstateAgentAsync(int id);
        Task UpdateRealEstateAgentAsync(RealEstateAgent realEstateAgent);
    }
}
