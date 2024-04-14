using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Models
{
    //Henrik
    public class SaleObject
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
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

        //Foreign Keys
        public int RealEstateAgentId { get; set; }
        public int MunicipalityId { get; set; }
        public int CategoryId { get; set; }

        //Navigation Properties
        public RealEstateAgent RealEstateAgent { get; set; }
        public Municipality Municipality { get; set; }
        public Category Category { get; set; }

        public SaleObject() { }
    }
}
