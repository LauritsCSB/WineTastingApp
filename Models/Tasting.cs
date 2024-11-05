using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class Tasting
    {
        public DateTime Date { get; set; }

        public string Occasion { get; set; }
        public WineBottle Bottle { get; set; }

        public VisualNotes VisualNotes { get; set; }

        public SmellNotes SmellNotes { get; set; }

        public PalateNotes PalateNotes { get; set; }
    }
}
