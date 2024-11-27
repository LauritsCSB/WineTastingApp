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

        public Tasting()
        {
            Bottle = new WineBottle();
            VisualNotes = new VisualNotes();
            SmellNotes = new SmellNotes();
            PalateNotes = new PalateNotes();
        }
        
        public void Validate()
        {
            if (Date == default(DateTime))
                throw new ArgumentException("Date is required.");
            if (string.IsNullOrEmpty(Occasion))
                throw new ArgumentException("Occasion is required.");
            if (Bottle == null)
                throw new ArgumentException("Bottle information is required");

            Bottle.Validate();
        }
    }

}
