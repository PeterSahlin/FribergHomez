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
                var firm1 = new Firm("Test1", "Presentation1", "ImageLocation1");
                var firm2 = new Firm("Test2", "Presentation2", "ImageLocation2");

                var agent1 = new RealEstateAgent("John", "Doe", "john@example.com", firm1, "1234567890", "image_url_here");
                var agent2 = new RealEstateAgent("Jane", "Smith", "jane@example.com", firm2, "9876543210", "image_url_here");

                var municipality1 = new Municipality("Umeå");
                var municipality2 = new Municipality("Vindeln");

                var category1 = new Category("House");
                var category2 = new Category("Cottage");

                var saleObject1 = new SaleObject
                {
                    Address = "123 Main St",
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

                await context.AddRangeAsync(new List<Firm> { firm1, firm2 });
                await context.AddRangeAsync(new List<RealEstateAgent> { agent1, agent2 });
                await context.AddRangeAsync(new List<SaleObject> { saleObject1, saleObject2 });
                await context.AddRangeAsync(new List<Municipality> { municipality1, municipality2 });
                await context.AddRangeAsync(new List<Category> { category1, category2 });
                await context.SaveChangesAsync();
            }
        }
    }
}
