using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Helper
{
    public class SeedHelper
    {
        public void SeedCategories(ApplicationDbContext applicationDbContext)
        {
            if (!applicationDbContext.Categories.Any())
            {
                List<Category> categoryList = new List<Category>
                {
                    new Category("House"),
                    new Category("Condo"),
                    new Category("Cottage"),
                    new Category("Condo Terraced House"),

                };
                applicationDbContext.AddRange(categoryList);
                applicationDbContext.SaveChanges();

            }
        }
        public async Task SeedMunicipalitiesAsync(ApplicationDbContext applicationDbContext)
        {
            if (!applicationDbContext.Municipalities.Any())
            {
                List<Municipality> municipalityList = new List<Municipality>
                {
                    new Municipality("Ale"),
                    new Municipality("Alingsås"),
                    new Municipality("Alvesta"),
                    new Municipality("Aneby"),
                    new Municipality("Arboga"),
                    new Municipality("Arjeplog"),
                    new Municipality("Arvidsjaur"),
                    new Municipality("Arvika"),
                    new Municipality("Askersund"),
                    new Municipality("Avesta"),
                    new Municipality("Bengtsfors"),
                    new Municipality("Berg"),
                    new Municipality("Bjurholm"),
                    new Municipality("Bjuv"),
                    new Municipality("Boden"),
                    new Municipality("Bollebygd"),
                    new Municipality("Bollnäs"),
                };
                applicationDbContext.AddRange(municipalityList);
                applicationDbContext.SaveChanges();

            }
        }
    }
}
