namespace FribergHomez.Models
{
    public class Municipality
    {
        //Henrik
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SaleObject> SaleObjects { get; set; } = new List<SaleObject>();
    }
}
