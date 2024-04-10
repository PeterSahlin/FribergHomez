namespace FribergHomez.Data
{
    //Henrik
    public class MunicipalityRepository:IMunicipality
    {
        private readonly ApplicationDbContext applicationDbContext;

        public MunicipalityRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
    }
}
