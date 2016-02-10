using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_DataDemo_2016_02_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory MyInventory = new Inventory();
            foreach (var item in MyInventory.GetArtworkList)
            {
                // vi vet att alla items i listan är av typen Artwork
                //Console.WriteLine(item.PresentationName);
                Console.WriteLine(item);
            }
        }
    }

    
}
 