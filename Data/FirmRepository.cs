namespace FribergHomez.Data
{
    //Thomas
    public class FirmRepository:IFirm
    {
        private readonly ApplicationDbContext applicationDbContext;

        public FirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
