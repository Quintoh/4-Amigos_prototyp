using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_DataDemo_2016_02_10
{
    public class Artwork
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public string PresentationName
        {
            get { return $"Konstverket {Title} är gjort av {Artist} "; }
        }

        public override string ToString()
        {
            return PresentationName;
        }

    }

    public class Inventory
    {
        //This is a varible
        private List<Artwork> ArtworkList = new List<Artwork>() {
        new Artwork() { id=10, Artist="Kalle", Title="kvack"},
        new Artwork() { id=12, Artist="Pelle", Title="lol" },
        new Artwork() { id=13, Artist="Anton", Title="nope" },
        new Artwork() { id=15, Artist="Macus", Title="WMC" },
        new Artwork() { id=16, Artist="Thomas", Title="MVC" },

        };

        public List<Artwork> GetArtworkList
        {
            get { return ArtworkList; }
        }
    }
}
