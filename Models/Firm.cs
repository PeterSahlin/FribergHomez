using System.Reflection.Metadata.Ecma335;

namespace FribergHomez.Models
{
    //Thomas
    public class Firm
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public string Presentation { get; set; } = "";

        public string ImageLocation { get; set; } = "";

        public List<RealEstateAgent> RealEstateAgents { get; set; }
        public Firm(string name, string presentation, string imageLocation, List<RealEstateAgent> listOfAgents)
        {
            Name = name;
            Presentation = presentation;
            ImageLocation = imageLocation;
            RealEstateAgents = listOfAgents;
        }
        public Firm()
        {

        }
    }
}
