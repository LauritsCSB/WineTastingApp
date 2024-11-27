using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class FaultNotes
    {
        public List<string> Faults { get; set; }

        public FaultNotes() 
        {
            Faults = new List<string>();
        }
    }
}
