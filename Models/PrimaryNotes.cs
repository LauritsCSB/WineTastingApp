using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class PrimaryNotes
    {
        public List<PrimaryNotesEnums.Flower> Flowers { get; set; }
        public List<PrimaryNotesEnums.TreeFruit> TreeFruits { get; set; }
        public List<PrimaryNotesEnums.TropicalFruit> TropicalFruits { get; set; }
        public List<PrimaryNotesEnums.RedFruit> RedFruits { get; set; }
        public List<PrimaryNotesEnums.BlackFruit> BlackFruits { get; set; }
        public List<PrimaryNotesEnums.DriedFruit> DriedFruits { get; set; }
        public List<PrimaryNotesEnums.NobleRot> NobleRots { get; set; }
        public List<PrimaryNotesEnums.Spice> Spices { get; set; }
        public List<PrimaryNotesEnums.Vegetable> Vegetables { get; set; }
        public List<PrimaryNotesEnums.Earth> Earths { get; set; }
        public PrimaryNotes()
        {
            Flowers = new List<PrimaryNotesEnums.Flower>();
            TreeFruits = new List<PrimaryNotesEnums.TreeFruit>();
            TropicalFruits = new List<PrimaryNotesEnums.TropicalFruit>();
            RedFruits = new List<PrimaryNotesEnums.RedFruit>();
            BlackFruits = new List<PrimaryNotesEnums.BlackFruit>();
            DriedFruits = new List<PrimaryNotesEnums.DriedFruit>();
            NobleRots = new List<PrimaryNotesEnums.NobleRot>();
            Spices = new List<PrimaryNotesEnums.Spice>();
            Vegetables = new List<PrimaryNotesEnums.Vegetable>();
            Earths = new List<PrimaryNotesEnums.Earth>();
        }
    }
    
}
