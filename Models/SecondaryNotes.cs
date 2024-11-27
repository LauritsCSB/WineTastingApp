using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class SecondaryNotes
    {
        public List<string> Microbials {  get; set; }

        public SecondaryNotes()
        {  Microbials = new List<string>();}
    }
}
