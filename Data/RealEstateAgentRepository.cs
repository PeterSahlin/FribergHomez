namespace FribergHomez.Data
{
    //Peter
    public class RealEstateAgentRepository:IRealEstateAgent
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RealEstateAgentRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
