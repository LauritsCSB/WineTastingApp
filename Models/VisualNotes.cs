using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class VisualNotes
    { 
        public enum ClarityEnum
        {
            Clear,
            Hazy,
            Cloudy
        }

        public enum IntensityEnum
        {
            Pale,
            Medium,
            Deep
        }

        public enum ColorEnum
        {
            Red,
            White,
            Rose
        }

        public ClarityEnum Clarity { get; set; }
        public IntensityEnum Intensity { get; set; }
        public ColorEnum Color { get; set; }
    }
}
