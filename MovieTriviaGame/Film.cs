using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    //Film class that contains a name, description, director, release date, image, and list of associated actors
    internal class Film
    {
        public string Name {  get; set; }

        public string Description { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Image Image {  get; set; }
        public Film(string initialName, string initialDescription, string initialDirector, DateTime initialReleaseDate, Image initialImage)
        {
            Name = initialName;
            Description = initialDescription;
            Director = initialDirector;
            ReleaseDate = initialReleaseDate;
            Image = initialImage;
        }

        public List<Celebrity> Actors { get; set; } = new List<Celebrity>();

    }
}
