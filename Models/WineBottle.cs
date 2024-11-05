using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class WineBottle
    {
        public string Name { get; set; }
        public Winery Winery { get; set; }

        public List<Grape> Grapes {  get; set; }

        public DateOnly Vintage { get; set; }

        public Appelation Appellation { get; set; }

    }
}
