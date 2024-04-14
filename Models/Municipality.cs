using System.Net.NetworkInformation;

namespace FribergHomez.Models
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Municipality(string name)
        {
            Name = name;
        }
        public Municipality() { }
    }

}
