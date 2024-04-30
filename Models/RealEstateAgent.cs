

namespace FribergHomez.Models
{
    //Peter
    public class RealEstateAgent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string ImageUrl { get; set; } = "";

        //public List<SaleObject> SaleObjects { get; set; } 


        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public bool IsActive { get; set; } = true;


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
        public RealEstateAgent(string firstName, string lastName, string email, Firm firm, string phoneNumber, string imageUrl, bool isActive, int firmId) 
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Firm = firm;
            PhoneNumber = phoneNumber;
            ImageUrl = imageUrl;
            IsActive = isActive;
            FirmId = firmId;
        }
        public RealEstateAgent() { }
    }
}
