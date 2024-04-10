using System.Reflection.Metadata.Ecma335;

namespace FribergHomez.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public string Presentation { get; set; } = "";

        public string ImageLocation { get; set; } = "";

        public List<string> RealEstateAgents { get; set; }
    }
}
