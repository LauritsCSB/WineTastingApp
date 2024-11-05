using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineTastingApp.Models
{
    public class PalateNotesEnums
    {
        public enum Sweetness
        {
            Dry,
            OffDry,
            MediumDry,
            MediumSweet,
            Sweet,
            Luscious
        }

        public enum Acidity
        {
            Low,
            MediumMinus,
            Medium,
            MediumPlus,
            High
        }

        public enum Tannin
        {
            Low,
            MediumMinus,
            Medium,
            MediumPlus,
            High
        }

        public enum Nature
        {
            Ripe,
            Soft,
            Smooth,
            Unripe,
            Green,
            Coarse,
            Stalky,
            Chalky,
            FineGrained,
        }
    }
}
