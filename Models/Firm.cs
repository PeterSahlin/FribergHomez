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
        public bool IsActive { get; set; } = true;

        //public List<RealEstateAgent> RealEstateAgents { get; set; }
        public Firm(string name, string presentation, string imageLocation, bool isActive/*, List<RealEstateAgent> listOfAgents*/)
        {
            Name = name;
            Presentation = presentation;
            ImageLocation = imageLocation;
            IsActive = isActive;

            //RealEstateAgents = new List<RealEstateAgent>(); // Skapar en ny lista för Realtor-objekt
        }
      /*  public Firm()
        {
            RealEstateAgents = new List<RealEstateAgent>();
        }*/
        public Firm() { }
    }
}
