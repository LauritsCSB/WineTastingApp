using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class Appellation
    {
        public string ?Name { get; set; }
        public Region Region { get; set; } = new Region();

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("Appelation name is required");
            if (Region == null)
                throw new ArgumentException("Region data is required");
        }
    }
}
