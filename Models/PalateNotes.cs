using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class PalateNotes
    {
        public PrimaryNotes PrimaryFlavor { get; set; }
        public SecondaryNotes SecondaryFlavor { get; set; }
        public TertiaryNotes TertiaryFlavor { get; set; }
        public FaultNotes FaultFlavor { get; set; }

        public string Sweetness { get; set; }
        public string Acidity { get; set; }
        public string Tannin { get; set; }
        public string Nature { get; set; }

        public PalateNotes()
        {
            PrimaryFlavor = new PrimaryNotes();
            SecondaryFlavor = new SecondaryNotes();
            TertiaryFlavor = new TertiaryNotes();
            FaultFlavor = new FaultNotes();
        }
    }
}