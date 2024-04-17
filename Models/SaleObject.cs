using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Models
{
    //Henrik
    public class SaleObject
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
/*
        public Municipality Municipality { get; set; } /*= new Municipality();
        public Category Category { get; set; } /*= new Category();
*/
        public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public int AncillaryArea { get; set; }
        public int PlotArea { get; set; }
        public string Description { get; set; } = "";
        public int NumberOfRooms { get; set; }
        public int MonthlyFee { get; set; }
        public int OperatingCostPerYear { get; set; }
        public int YearOfConstruction { get; set; }
        public List<string> ImageUrl { get; set; } = new List<string>();
/*

        //Foreign Keys
        public int? RealEstateAgentId { get; set; }
        public int MunicipalityId { get; set; }
        public int CategoryId { get; set; }

        //Navigation Properties
        public RealEstateAgent RealEstateAgent { get; set; }
        public Municipality Municipality { get; set; }
        public Category Category { get; set; }

        public SaleObject() { }
        public Firm Firm { get; set; } /*= new Firm();
*/
        //Peter
        public SaleObject(string adress, Municipality municipality, Category category, int startingPrice, 
                            int livingArea, int ancilleryArea, int plotArea, string description, int numberOfRooms, 
                            int monthlyFee, int operationCostPerYear, int yearOfConstruction, List<string> imgUrl, Firm firm)
        {
            Address = adress;
            Municipality = municipality;
            Category = category;
            StartingPrice = startingPrice;
            LivingArea = livingArea;
            AncillaryArea = ancilleryArea;
            PlotArea = plotArea;
            Description = description;
            NumberOfRooms = numberOfRooms;
            MonthlyFee = monthlyFee;
            OperatingCostPerYear = operationCostPerYear;
            YearOfConstruction = yearOfConstruction;
            ImageUrl = imgUrl;
            Firm = firm;
        }

        public SaleObject()
        {
            
        }
    }
}
