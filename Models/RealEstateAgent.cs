namespace FribergHomez.Models
{
    //Peter
    public class RealEstateAgent
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public int FirmId { get; set; } // Foreign key property
        public Firm Firm { get; set; } // Navigation property

        public string PhoneNumber { get; set; } = "";
        public string ImageUrl { get; set; } = "";

        // Note: Remove the SaleObjects navigation property

        public RealEstateAgent(string firstName, string lastName, string email, Firm firm, string phoneNumber, string imageUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Firm = firm;
            PhoneNumber = phoneNumber;
            ImageUrl = imageUrl;
        }
        public RealEstateAgent() { }
    }
}
