using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class SmellNotes
    {
        public int Intensity { get; set; }
        public PrimaryNotes PrimaryAroma { get; set; }

        public SecondaryNotes SecondaryAroma { get; set; }
        
        public TertiaryNotes TertiaryAroma { get; set; }
        public FaultNotes FaultyAroma { get; set; }

        public SmellNotes()
        {
            PrimaryAroma = new PrimaryNotes();
            SecondaryAroma = new SecondaryNotes();
            TertiaryAroma = new TertiaryNotes();
            FaultyAroma = new FaultNotes();
        }
    }
}
