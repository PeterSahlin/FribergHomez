namespace FribergHomez.Data
{
    //Henrik
    public class SaleObjectRepository:ISaleObject
    {
        private readonly ApplicationDbContext applicationDbContext;

        public SaleObjectRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}