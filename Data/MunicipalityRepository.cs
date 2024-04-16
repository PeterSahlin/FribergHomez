using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Data
{
    //Henrik
    public class MunicipalityRepository:IMunicipality
    {
        private readonly ApplicationDbContext applicationDbContext;

        public MunicipalityRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateMunicipalityAsync(Municipality municipality)
        {
            applicationDbContext.Add(municipality);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteMunicipalityAsync(Municipality municipality)
        {
            applicationDbContext.Remove(municipality);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task EditMunicipalityAsync(Municipality municipality)
        {
            applicationDbContext.Update(municipality);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task<List<Municipality>> GetAllMunicipalitiesAsync()
        {
            return await applicationDbContext.Municipalities.OrderBy(m => m.Id).ToListAsync();
        }

        public async Task<Municipality> GetMunicipalitiesByIdAsync(int id)
        {
            return await applicationDbContext.Municipalities.FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
