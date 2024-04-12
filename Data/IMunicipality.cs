using FribergHomez.Models;

namespace FribergHomez.Data
{
    //Henrik
    public interface IMunicipality
    {
        Task<List<Municipality>> GetAllMunicipalitiesAsync();
        Task GetMunicipalityByIdAsync(int id);
        Task AddMunicipalityAsync(Municipality municipality);
        Task DeleteMunicipalityAsync(int id);
        Task UpdateMunicipalityAsync(Municipality municipality);
    }
}
