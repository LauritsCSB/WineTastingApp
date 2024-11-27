using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class Region
    {
        public string ?Name { get; set; }
        public Country Country { get; set; } = new Country();

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name)) 
                throw new ArgumentException("Region name is required");
            if (Country == null) 
                throw new ArgumentException("Country data is required");

            Country.Validate();
        }
    }
}
