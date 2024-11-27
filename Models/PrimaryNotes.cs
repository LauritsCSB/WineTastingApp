using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class PrimaryNotes
    {
        public List<string> Flowers { get; set; }
        public List<string> TreeFruits { get; set; }
        public List<string> TropicalFruits { get; set; }
        public List<string> RedFruits { get; set; }
        public List<string> BlackFruits { get; set; }
        public List<string> DriedFruits { get; set; }
        public List<string> NobleRots { get; set; }
        public List<string> Spices { get; set; }
        public List<string> Vegetables { get; set; }
        public List<string> Earths { get; set; }
        public PrimaryNotes()
        {
            Flowers = new List<string>();
            TreeFruits = new List<string>();
            TropicalFruits = new List<string>();
            RedFruits = new List<string>();
            BlackFruits = new List<string>();
            DriedFruits = new List<string>();
            NobleRots = new List<string>();
            Spices = new List<string>();
            Vegetables = new List<string>();
            Earths = new List<string>();
        }
    }
    
}
