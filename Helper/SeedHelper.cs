using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Helper
{
    public class SeedHelper
    {
        public async Task SeedCategoriesAsync(ApplicationDbContext applicationDbContext)
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

        public async Task SeedSaleObjectsAsync(ApplicationDbContext applicationDbContext)
        {
            //await SeedCategoriesAsync(applicationDbContext);

            if (!applicationDbContext.SaleObjects.Any())
            {

                //Added for testing
                Municipality municipality = new Municipality();
                municipality.Name = "Arkham";
                //municipality.SaleObjects = new List<SaleObject> { new SaleObject() };

                Firm firm = new Firm();
                firm.Name = "HousezForSale";
                firm.Presentation = "blabla";
                firm.ImageLocation = "test";
                firm.RealEstateAgents = new List<RealEstateAgent> { new RealEstateAgent() };

                List<string> imgUrl = new List<string> { "www.test.com" };
                //End test data part

                Category category =applicationDbContext.Categories.FirstOrDefault(c => c.Name == "House");




                List<SaleObject> saleObjectList = new List<SaleObject>
                {
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality , Category = category, StartingPrice = 50000000, LivingArea = 500, AncillaryArea = 100, PlotArea = 50000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 90000, OperatingCostPerYear = 7500000, YearOfConstruction = 1892, ImageUrl = imgUrl ,Firm = firm  }
                };

              


                applicationDbContext.Entry(category).State = EntityState.Unchanged;                 //category sätt entity state unchanged
                applicationDbContext.AddRange(saleObjectList);
                await applicationDbContext.SaveChangesAsync();                      
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
