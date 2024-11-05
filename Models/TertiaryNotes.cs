using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class TertiaryNotes
    {
        public List<TertiaryNotesEnums.Oak> Oaks { get; set; }
        public List<TertiaryNotesEnums.GeneralAging> GeneralAging { get; set; }
    }
}
