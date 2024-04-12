using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Models
{
    //Henrik
    public class SaleObject
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
        public int MunicipalityId { get; set; } // Foreign key property
        public Municipality Municipality { get; set; } // Navigation property
        public int CategoryId { get; set; } // Foreign key property
        public Category Category { get; set; } // Navigation property
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
        public int FirmId { get; set; } // Foreign key property
        public Firm Firm { get; set; } // Navigation property
        public int? RealEstateAgentId { get; set; } // Foreign key property
        public RealEstateAgent RealEstateAgent { get; set; } // Navigation property
    }
}
