using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FribergHomez.Helper
{
    public class SeedHelper
    {
        /*
                public async Task SeedCategoriesAsync(ApplicationDbContext applicationDbContext)
                    //All
                {
                    if (!context.Realtors.Any())
                    {
                        var firm1 = new Firm("Homewise Solutions", "HomePerfected", "PerfectHomeImages");
                        var firm2 = new Firm("Urban Nest Realty", "CityScape Living", "UrbanNestImages");
                        var firm3 = new Firm("EquiHome Realtors", "BalancedDwellings", "EquiHomeGallery");

                        var agent1 = new RealEstateAgent("John", "Doe", "john@example.com", firm1, "1234567890", "image_url_here");
                        var agent2 = new RealEstateAgent("Emily", "Smith", "emily@example.com", firm2, "2345678901", "image_url_here");
                        var agent3 = new RealEstateAgent("Michael", "Johnson", "michael@example.com", firm3, "3456789012", "image_url_here");
                        var agent4 = new RealEstateAgent("Jessica", "Brown", "jessica@example.com", firm1, "4567890123", "image_url_here");
                        var agent5 = new RealEstateAgent("David", "Martinez", "david@example.com", firm2, "5678901234", "image_url_here");
                        var agent6 = new RealEstateAgent("Jennifer", "Garcia", "jennifer@example.com", firm3, "6789012345", "image_url_here");
                        var agent7 = new RealEstateAgent("Christopher", "Wilson", "chris@example.com", firm1, "7890123456", "image_url_here");
                        var agent8 = new RealEstateAgent("Ashley", "Anderson", "ashley@example.com", firm2, "8901234567", "image_url_here");
                        var agent9 = new RealEstateAgent("Matthew", "Taylor", "matthew@example.com", firm3, "9012345678", "image_url_here");
                        var agent10 = new RealEstateAgent("Jessica", "Thomas", "jessica@example.com", firm1, "0123456789", "image_url_here");


                        var municipality1 = new Municipality("Ale");
                        var municipality2 = new Municipality("Alingsås");
                        var municipality3 = new Municipality("Alvesta");
                        var municipality4 = new Municipality("Aneby");
                        var municipality5 = new Municipality("Arboga");
                        var municipality6 = new Municipality("Arjeplog");
                        var municipality7 = new Municipality("Arvidsjaur");
                        var municipality8 = new Municipality("Arvika");
                        var municipality9 = new Municipality("Askersund");
                        var municipality10 = new Municipality("Avesta");

                        var category1 = new Category("House");
                        var category2 = new Category("Cottage");
                        var category3 = new Category("Condo");
                        var category4 = new Category("Condo Terraced House"); 

                        var saleObject1 = new SaleObject
                        {
                            Address = "Storgatan 555",
                            Municipality = municipality1,
                            Category = category1,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful house with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent1
                        };
                        var saleObject2 = new SaleObject
                        {
                            Address = "Stenvägen 4",
                            Municipality = municipality2,
                            Category = category2,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful cottage with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent2
                        };
                        var saleObject3 = new SaleObject
                        {
                            Address = "Grusvägen 123",
                            Municipality = municipality3,
                            Category = category3,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful Condo with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent3
                        };
                        var saleObject4 = new SaleObject
                        {
                            Address = "Mittivägen 55",
                            Municipality = municipality4,
                            Category = category4,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "This is definitely a place where you can live",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent4
                        };
                        var saleObject5 = new SaleObject
                        {
                            Address = "NågonstansISverige 66",
                            Municipality = municipality6,
                            Category = category1,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "This is a house",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent5
                        };

                        await context.AddRangeAsync(new List<Firm> { firm1, firm2, firm3});
                        await context.AddRangeAsync(new List<RealEstateAgent> { agent1, agent2, agent3, agent4, agent5, agent6, agent7, agent8, agent9, agent10 });
                        await context.AddRangeAsync(new List<Municipality> { municipality1, municipality2, municipality3, municipality4, municipality5, municipality6, municipality7, municipality8, municipality9, municipality10 });
                        await context.AddRangeAsync(new List<Category> { category1, category2, category3, category4 });
                        await context.AddRangeAsync(new List<SaleObject> { saleObject1, saleObject2, saleObject3, saleObject4, saleObject5 });
                        await context.SaveChangesAsync();
                    }
                    }
                }
              */

        public async Task SeedCategoriesAsync(ApplicationDbContext applicationDbContext)
        {
            if(!applicationDbContext.Categories.Any())
            {
                var category1 = new Category("House");
                var category2 = new Category("Cottage");
                var category3 = new Category("Condo");
                var category4 = new Category("Condo Terraced House");
                applicationDbContext.AddRange(category1, category2, category3, category4);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task SeedSaleObjectsAsync(ApplicationDbContext applicationDbContext)
        {
            //Peter

            if (!applicationDbContext.SaleObjects.Any())
            {

                RealEstateAgent torontoAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Toronto"));
                RealEstateAgent pittsburghAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Pittsburgh"));
                RealEstateAgent coloradoAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Colorado"));

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
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality1 , Category = category1, StartingPrice = 50000000, LivingArea = 500, AncillaryArea = 100, PlotArea = 50000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 90000, OperatingCostPerYear = 7500000, YearOfConstruction = 1892, ImageUrl = imgUrl ,RealEstateAgent = torontoAgent  },
                    new SaleObject {Address = "1007 Tiny Mountain Drive", Municipality = municipality2 , Category = category2, StartingPrice = 500000, LivingArea = 50, AncillaryArea = 10, PlotArea =100, Description = "Mini-Batman's base of operations", NumberOfRooms=7, MonthlyFee = 60000, OperatingCostPerYear = 500000, YearOfConstruction = 1792, ImageUrl = imgUrl ,RealEstateAgent = coloradoAgent  },
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality3 , Category = category3, StartingPrice = 50000000, LivingArea = 500, AncillaryArea = 100, PlotArea = 45000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 40000, OperatingCostPerYear = 56700, YearOfConstruction = 1642, ImageUrl = imgUrl ,RealEstateAgent = pittsburghAgent  },
                    new SaleObject {Address = "1007 Mountain Drive", Municipality = municipality4 , Category = category4, StartingPrice = 100000, LivingArea = 400, AncillaryArea = 100, PlotArea = 50000, Description = "Batman's base of operations", NumberOfRooms=12, MonthlyFee = 120000, OperatingCostPerYear = 34000, YearOfConstruction = 1802, ImageUrl = imgUrl ,RealEstateAgent = torontoAgent  },


                };

                applicationDbContext.AddRange(saleObjectList);
                await applicationDbContext.SaveChangesAsync();
            }
        }



        public async Task SeedFirmsAndAgentsAsync(ApplicationDbContext applicationDbContext)
        {
            //Henrik
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
            if (!applicationDbContext.RealEstateAgents.Any())
            {
                Firm torontoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Toronto"));
                Firm pittsburghFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Pittsburgh"));
                Firm coloradoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Colorado"));

                var torontoAgent = new RealEstateAgent { FirstName = "Mats", LastName = "Sundin", Email = "mats@toronto.com", PhoneNumber = "555-47874", Firm = torontoFirm }; //SaleObjects = saleObjectList };

                var pittsburghAgent = new RealEstateAgent { FirstName = "Jaromir", LastName = "Jagr", Email = "jaromir@pittsburgh.com", PhoneNumber = "599-435811", Firm = pittsburghFirm }; //SaleObjects = saleObjectList };

                var coloradoAgent = new RealEstateAgent { FirstName = "Peter", LastName = "Forsberg", Email = "peter@colorado.com", PhoneNumber = "988-12447", Firm = coloradoFirm };

                applicationDbContext.AddRange(torontoAgent);
                applicationDbContext.AddRange(pittsburghAgent);
                applicationDbContext.AddRange(coloradoAgent);
                await applicationDbContext.SaveChangesAsync();

            }

        }

        public async Task SeedMunicipalitiesAsync(ApplicationDbContext applicationDbContext)
        {
            //Thomas
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



