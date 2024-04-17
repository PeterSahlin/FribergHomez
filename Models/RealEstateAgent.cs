namespace FribergHomez.Models
{
    //Peter
    public class RealEstateAgent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string ImageUrl { get; set; } = "";

        // Foreign Keys
        public int? FirmId { get; set; }

        //Navigation Properties
        public Firm Firm { get; set; }


/*
        public RealEstateAgent(string firstName, string lastName, string email, Firm firm, string phoneNumber, string imageUrl)
        public List<SaleObject> SaleObjects { get; set; }

        public RealEstateAgent()
        {
            
        }
*/
        public RealEstateAgent(string firstName, string lastName, string email, Firm firm, string phoneNumber, string imageUrl, List<SaleObject> saleObjects)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Firm = firm;
            PhoneNumber = phoneNumber;
            ImageUrl = imageUrl;
            SaleObjects = saleObjects;
        }
        public RealEstateAgent() { }
        }
    }
}
