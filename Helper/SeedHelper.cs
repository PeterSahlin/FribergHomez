using FribergHomez.Data;
using FribergHomez.Models;

namespace FribergHomez.Helper
{
    public static class SeedHelper
    {
        public static async Task SeedDataAsync(ApplicationDbContext context)
        {
            if (!context.Realtors.Any())
            {
                var firm1 = new Firm("Homewise Solutions", "HomePerfected", "PerfectHomeImages");
                var firm2 = new Firm("Urban Nest Realty", "CityScape Living", "UrbanNestImages");
                var firm3 = new Firm("EquiHome Realtors", "BalancedDwellings", "EquiHomeGallery");
                var firm4 = new Firm("Dreamscape Properties", "DreamCatcher Homes", "DreamscapeVisuals");
                var firm5 = new Firm("Skyline Ventures", "Horizon Homes", "SkylinePortfolio");
                var firm6 = new Firm("EcoVista Realty", "GreenScape Estates", "EcoVistaGallery");
                var firm7 = new Firm("Harborview Homes", "Seaside Serenity", "HarborviewGallery");
                var firm8 = new Firm("Altitude Realty Group", "Summit Living", "AltitudeVisuals");
                var firm9 = new Firm("Avenue Advantage Realty", "StreetSmart Properties", "AvenueAdvantageImages");
                var firm10 = new Firm("Prospera Properties", "FortuneFound Homes", "ProsperaVisuals");

                var agent1 = new RealEstateAgent("John", "Doe", "john@example.com", firm1, "1234567890", "image_url_here");
                var agent2 = new RealEstateAgent("Emily", "Smith", "emily@example.com", firm2, "2345678901", "image_url_here");
                var agent3 = new RealEstateAgent("Michael", "Johnson", "michael@example.com", firm3, "3456789012", "image_url_here");
                var agent4 = new RealEstateAgent("Jessica", "Brown", "jessica@example.com", firm4, "4567890123", "image_url_here");
                var agent5 = new RealEstateAgent("David", "Martinez", "david@example.com", firm5, "5678901234", "image_url_here");
                var agent6 = new RealEstateAgent("Jennifer", "Garcia", "jennifer@example.com", firm6, "6789012345", "image_url_here");
                var agent7 = new RealEstateAgent("Christopher", "Wilson", "chris@example.com", firm7, "7890123456", "image_url_here");
                var agent8 = new RealEstateAgent("Ashley", "Anderson", "ashley@example.com", firm8, "8901234567", "image_url_here");
                var agent9 = new RealEstateAgent("Matthew", "Taylor", "matthew@example.com", firm9, "9012345678", "image_url_here");
                var agent10 = new RealEstateAgent("Jessica", "Thomas", "jessica@example.com", firm10, "0123456789", "image_url_here");


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
                    Firm = firm1,
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
                    Firm = firm2,
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
                    Firm = firm3,
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
                    Firm = firm4,
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
                    Firm = firm5,
                    RealEstateAgent = agent5
                };

                await context.AddRangeAsync(new List<Firm> { firm1, firm2, firm3, firm4, firm5, firm6, firm7, firm8, firm9, firm10 });
                await context.AddRangeAsync(new List<RealEstateAgent> { agent1, agent2, agent3, agent4, agent5, agent6, agent7, agent8, agent9, agent10 });
                await context.AddRangeAsync(new List<SaleObject> { saleObject1, saleObject2, saleObject3, saleObject4, saleObject5 });
                await context.AddRangeAsync(new List<Municipality> { municipality1, municipality2, municipality3, municipality4, municipality5, municipality6, municipality7, municipality8, municipality9, municipality10 });
                await context.AddRangeAsync(new List<Category> { category1, category2, category3, category4 });
                await context.SaveChangesAsync();
            }
        }
    }
}
