﻿using Microsoft.EntityFrameworkCore;

namespace FribergHomez.Models
{
    //Henrik
    public class SaleObject
    {
        public int Id { get; set; }
        public string Address { get; set; } = "";
        public Municipality Municipality { get; set; } = new Municipality();
        public Category Category { get; set; } = new Category();
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
        public Firm Firm { get; set; } = new Firm();

    }
}
