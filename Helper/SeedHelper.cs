using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Helper
{
    public static class SeedHelper
    {
        public static void SeedCategories (ApplicationDbContext applicationDbContext)
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
        //public static void SeedFirm(ApplicationDbContext applicationDbContext)
        //{
        //    if (!applicationDbContext.Firms.Any())
        //    {
        //        List<RealEstateAgent> listOfAgents = new List<RealEstateAgent>
        //        {
        //            new RealEstateAgent();
        //        };
        //        List<Firm> firmList = new List<Firm>
        //        {
        //            new Firm("Realtor firm", "test", "/test", listOfAgents)
        //        };
        //        applicationDbContext.AddRange(firmList);
        //        applicationDbContext.SaveChanges();
        //
        //    }
        //}
    }
}
