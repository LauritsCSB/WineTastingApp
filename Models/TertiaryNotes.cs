using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class TertiaryNotes
    {
        public List<string> Oaks { get; set; }
        public List<string> GeneralAging { get; set; }

        public TertiaryNotes() 
        {
            Oaks = new List<string>();
            GeneralAging = new List<string>();
        }
    }
}
