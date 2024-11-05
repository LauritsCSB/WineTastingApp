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

        public PalateNotesEnums.Sweetness Sweetness { get; set; }
        public PalateNotesEnums.Acidity Acidity { get; set; }
        public PalateNotesEnums.Tannin Tannin { get; set; }
        public PalateNotesEnums.Nature Nature { get; set; }

        public PalateNotes()
        {
            PrimaryFlavor = new PrimaryNotes();
            SecondaryFlavor = new SecondaryNotes();
            TertiaryFlavor = new TertiaryNotes();
            FaultFlavor = new FaultNotes();
        }
    }
}