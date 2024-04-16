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

            if (!applicationDbContext.SaleObjects.Any())
            {

                //Added data
                Municipality municipality1 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Ale");
                Municipality municipality2 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Alingsås");
                Municipality municipality3 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Bengtsfors");
                Municipality municipality4 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Bjurholm");
                Municipality municipality5 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Bjuv");

                Firm firm1 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Toronto"));
                Firm firm2 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Pittsburgh"));
                Firm firm3 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Colorado"));

                List<string> imgUrl = new List<string> { "www.test.com" };
                //End of data part

                Category category1 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "House");
                Category category2 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Condo");
                Category category3 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Cottage");
                Category category4 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Condo Terraced House");




                List<SaleObject> saleObjectList = new List<SaleObject>
                {
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality1 , Category = category1, StartingPrice = 50000000, LivingArea = 500, AncillaryArea = 100, PlotArea = 50000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 90000, OperatingCostPerYear = 7500000, YearOfConstruction = 1892, ImageUrl = imgUrl ,Firm = firm1  },
                    new SaleObject {Address = "1007 Tiny Mountain Drive", Municipality = municipality2 , Category = category2, StartingPrice = 500000, LivingArea = 50, AncillaryArea = 10, PlotArea =100, Description = "Mini-Batman's base of operations", NumberOfRooms=7, MonthlyFee = 60000, OperatingCostPerYear = 500000, YearOfConstruction = 1792, ImageUrl = imgUrl ,Firm = firm2  },
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality3 , Category = category3, StartingPrice = 50000000, LivingArea = 500, AncillaryArea = 100, PlotArea = 45000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 40000, OperatingCostPerYear = 56700, YearOfConstruction = 1642, ImageUrl = imgUrl ,Firm = firm1  },
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality4 , Category = category4, StartingPrice = 100000, LivingArea = 400, AncillaryArea = 100, PlotArea = 50000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 120000, OperatingCostPerYear = 34000, YearOfConstruction = 1802, ImageUrl = imgUrl ,Firm = firm3  },


                };

                applicationDbContext.AddRange(saleObjectList);
                await applicationDbContext.SaveChangesAsync();
            }
        }



        public async Task SeedFirmsAndAgentsAsync(ApplicationDbContext applicationDbContext)
        {

            if (!applicationDbContext.Firms.Any())
            {
                var torontoFirm = new Firm
                {
                    Name = "Toronto Firm",
                    Presentation = "Toronto's finest housing",
                    ImageLocation = "MapleLeaf.img",
                    //RealEstateAgents = listOfTorontoAgents
                };

                var pittsburghFirm = new Firm
                {
                    Name = "Pittsburgh Firm",
                    Presentation = "Pittsburgh's finest housing",
                    ImageLocation = "Penguins.img",
                    //RealEstateAgents = listOfPittsburghAgents
                };
                var coloradoFirm = new Firm
                {
                    Name = "Colorado Firm",
                    Presentation = "Colorado's finest housing",
                    ImageLocation = "Avalanche.img",
                    //RealEstateAgents = listOfColoradoAgents
                };
                applicationDbContext.AddRange(torontoFirm, pittsburghFirm, coloradoFirm);
                applicationDbContext.SaveChanges();
            }


            List<SaleObject> saleObjectList = new List<SaleObject>();
            if (!applicationDbContext.Realtors.Any())
            {
                Firm torontoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Toronto"));
                Firm pittsburghFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Pittsburgh"));
                Firm coloradoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Colorado"));

                var torontoAgents = new List<RealEstateAgent>
                {
                    new RealEstateAgent { FirstName = "Mats", LastName = "Sundin", Email = "mats@sundin.com", PhoneNumber = "555-47874", Firm = torontoFirm, SaleObjects = saleObjectList },
                };

                var pittsburghAgents = new List<RealEstateAgent>
                {
                    new RealEstateAgent { FirstName = "Jaromir", LastName = "Jagr", Email = "jaromir@pittsburgh.com", PhoneNumber = "599-435811", Firm = pittsburghFirm, SaleObjects = saleObjectList },
                };

                var coloradoAgents = new List<RealEstateAgent>
                {
                    new RealEstateAgent { FirstName = "Peter", LastName = "Forsberg", Email = "peter@colorado.com", PhoneNumber = "988-12447", Firm = coloradoFirm },
                };

                applicationDbContext.AddRange(torontoAgents);
                applicationDbContext.AddRange(pittsburghAgents);
                applicationDbContext.AddRange(coloradoAgents);
                await applicationDbContext.SaveChangesAsync();

            }
         
        }

        public async Task SeedMunicipalitiesAsync(ApplicationDbContext applicationDbContext)
        {
            if (!applicationDbContext.Municipalities.Any())
            {
                List<Municipality> municipalityList = new List<Municipality>
                {
                new Municipality { Name = "Ale" },
                    new Municipality { Name = "Alingsås" },
                    new Municipality { Name = "Alvesta" },
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
                new Municipality("Bollnäs")


                };
                applicationDbContext.AddRange(municipalityList);
                applicationDbContext.SaveChanges();
            };


        }

    }
}



