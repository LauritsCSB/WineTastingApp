using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class WineBottle
    {
        public string ?Name { get; set; }
        public Winery Winery { get; set; } = new Winery();
        public string ?Type { get; set; }

        public List<Grape> ?Grapes {  get; set; }

        public DateOnly Vintage { get; set; }

        public Appellation Appellation { get; set; } = new Appellation();

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name)) 
                throw new ArgumentException("Wine name is required");
            if (Winery == null)
                throw new ArgumentException("Winery is required");
            if (string.IsNullOrEmpty(Type))
                throw new ArgumentException("Type is required");
            if (Grapes == null || Grapes.Count == 0)
                throw new ArgumentException("At least one grape is required");
            if (Vintage == default)
                throw new ArgumentException("Vintage is required");
            if (Appellation == null)
                throw new ArgumentException("Appelation is required");

            Winery.Validate();
            Appellation.Validate();
        }
    }
}
