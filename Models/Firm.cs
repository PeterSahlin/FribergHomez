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
        public List<RealEstateAgent> Agents { get; set; }
        public Firm(string name, string presentation, string imageLocation)
        {
            Name = name;
            Presentation = presentation;
            ImageLocation = imageLocation;
        }
        public Firm() { }
    }
}
