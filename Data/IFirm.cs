using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Thomas
    public interface IFirm
    {
        Task CreateFirmAsync(Firm firm);
        Task DeleteFirmAsync(int id);
        Task UpdateFirmAsync(Firm firm);
        Task<List<Firm>> GetAllFirmsAsync();
        Task<Firm> GetFirmByIdAsync(int id);
        
    }
}
