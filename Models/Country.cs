using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class Country
    {
        public string Name { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("Country name is required");
        }
    }
}
