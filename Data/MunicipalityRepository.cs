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
        public async Task<List<Municipality>> GetAllMunicipalitiesAsync()
        {
            return await applicationDbContext.Municipalities.ToListAsync();
        }
        public async Task GetMunicipalityByIdAsync(int id)
        {
            await applicationDbContext.Municipalities.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task AddMunicipalityAsync(Municipality municipality)
        {
            applicationDbContext.Municipalities.Add(municipality);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteMunicipalityAsync(int id)
        {
            var municipalityToDelete = await applicationDbContext.Municipalities.FindAsync(id);
            if (municipalityToDelete != null)
            {
                applicationDbContext.Municipalities.Remove(municipalityToDelete);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task UpdateMunicipalityAsync(Municipality municipality)
        {
            applicationDbContext.Entry(municipality).State = EntityState.Modified;
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
