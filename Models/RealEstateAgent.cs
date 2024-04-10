namespace FribergHomez.Models
{
    //Peter
    public class RealEstateAgent
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";

        public Firm Firm { get; set; }
        public string PhoneNumber { get; set; } = "";

        public string ImageUrl { get; set; } = "";

        public List<SaleObject> SaleObjects { get; set; }
    }
}
