using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Thomas
    public interface IFirm
    {
        Task<List<Firm>> GetAllFirmsAsync();
        Task<Firm> GetFirmByIdAsync(int id);
        Task AddFirmAsync(Firm firm);
        Task DeleteFirmAsync(int id);
        Task UpdateFirmAsync(Firm firm);
    }
}
