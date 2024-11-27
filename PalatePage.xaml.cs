using WineTastingApp.Models;

namespace WineTastingApp
{
    public partial class PalatePage : ContentPage
    {
        private Tasting _tasting;
        public PalatePage(Tasting tasting)
        {
            InitializeComponent();
            _tasting = tasting;

            // Pre-fill pickers picker based on existing data
            SweetnessPicker.SelectedItem = _tasting.PalateNotes.Sweetness;
            AcidityPicker.SelectedItem = _tasting.PalateNotes.Acidity;
            TanninPicker.SelectedItem = _tasting.PalateNotes.Tannin;
            NaturePicker.SelectedItem = _tasting.PalateNotes.Nature;

            // Pre-fill checkboxes
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.Flowers, "PrimaryAroma:Flowers"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.TreeFruits, "PrimaryAroma:TreeFruits"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.TropicalFruits, "PrimaryAroma:TropicalFruits"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.RedFruits, "PrimaryAroma:RedFruits"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.BlackFruits, "PrimaryAroma:BlackFruits"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.DriedFruits, "PrimaryAroma:DriedFruits"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.NobleRots, "PrimaryAroma:NobleRot"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.Spices, "PrimaryAroma:Spice"); 
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.Vegetables, "PrimaryAroma:Vegetable");
            PreFillCheckBoxes(_tasting.PalateNotes.PrimaryFlavor.Earths, "PrimaryAroma:Earth");

            PreFillCheckBoxes(_tasting.PalateNotes.SecondaryFlavor.Microbials, "SecondaryAroma:Microbial");

            PreFillCheckBoxes(_tasting.PalateNotes.TertiaryFlavor.Oaks, "TertiaryAroma:Oak");
            PreFillCheckBoxes(_tasting.PalateNotes.TertiaryFlavor.GeneralAging, "TertiaryAroma:GeneralAging");

            PreFillCheckBoxes(_tasting.PalateNotes.FaultFlavor.Faults, "FaultAroma:FaultType");
        }

        private void PreFillCheckBoxes<T>(List<T> list, string prefix)
        {
            foreach (var item in list)
            {
                string checkBoxName = prefix + ":" + item.ToString();
                var checkbox = this.FindByName<CheckBox>(checkBoxName);
                if (checkbox != null)
                {
                    checkbox.IsChecked = true;
                }
            }
        }
        // Sweetness Picker Event Handler
        private void SweetnessPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            _tasting.PalateNotes.Sweetness = (string)picker.SelectedItem;
        }

        // Acidity Picker Event Handler
        private void AcidityPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            _tasting.PalateNotes.Acidity = (string)picker.SelectedItem;
        }

        // Tannin Picker Event Handler
        private void TanninPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            _tasting.PalateNotes.Tannin = (string)picker.SelectedItem;
        }

        // Nature Picker Event Handler
        private void NaturePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            _tasting.PalateNotes.Nature = (string)picker.SelectedItem;
        }

        private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkbox = (CheckBox)sender;
            string[] classIdParts = checkbox.ClassId.Split(':');
            string noteType = classIdParts[0];
            string category = classIdParts[1];
            string note = classIdParts[2];

            if (e.Value) // If checked
            {
                AddNoteToList(noteType, category, note);
            }
            else // If unchecked
            {
                RemoveNoteFromList(noteType, category, note);
            }
        }

        private void AddNoteToList(string noteType, string category, string note)
        {
            if (noteType == "PrimaryAroma")
            {
                switch (category)
                {
                    case "Flowers":
                        _tasting.PalateNotes.PrimaryFlavor.Flowers.Add(note);
                        break;
                    case "TreeFruits":
                        _tasting.PalateNotes.PrimaryFlavor.TreeFruits.Add(note);
                        break;
                    case "TropicalFruits":
                        _tasting.PalateNotes.PrimaryFlavor.TropicalFruits.Add(note);
                        break;
                    case "RedFruits":
                        _tasting.PalateNotes.PrimaryFlavor.RedFruits.Add(note);
                        break;
                    case "BlackFruits":
                        _tasting.PalateNotes.PrimaryFlavor.BlackFruits.Add(note);
                        break;
                    case "DriedFruits":
                        _tasting.PalateNotes.PrimaryFlavor.DriedFruits.Add(note);
                        break;
                    case "NobleRot":
                        _tasting.PalateNotes.PrimaryFlavor.NobleRots.Add(note);
                        break;
                    case "Spice":
                        _tasting.PalateNotes.PrimaryFlavor.Spices.Add(note);
                        break;
                    case "Vegetable":
                        _tasting.PalateNotes.PrimaryFlavor.Vegetables.Add(note);
                        break;
                    case "Earth":
                        _tasting.PalateNotes.PrimaryFlavor.Earths.Add(note);
                        break;
                }
            }
            else if (noteType == "SecondaryAroma")
            {
                switch (category)
                {
                    case "Microbial":
                        _tasting.PalateNotes.SecondaryFlavor.Microbials.Add(note);
                        break;
                }
            }
            else if (noteType == "TertiaryAroma")
            {
                switch (category)
                {
                    case "Oak":
                        _tasting.PalateNotes.TertiaryFlavor.Oaks.Add(note);
                        break;
                    case "GeneralAging":
                        _tasting.PalateNotes.TertiaryFlavor.GeneralAging.Add(note);
                        break;
                }
            }
            else if (noteType == "FaultAroma")
            {
                switch (category)
                {
                    case "FaultType":
                        _tasting.PalateNotes.FaultFlavor.Faults.Add(note);
                        break;
                }
            }
        }

        private void RemoveNoteFromList(string noteType, string category, string note)
        {
            if (noteType == "PrimaryAroma")
            {
                switch (category)
                {
                    case "Flowers":
                        _tasting.PalateNotes.PrimaryFlavor.Flowers.Remove(note);
                        break;
                    case "TreeFruits":
                        _tasting.PalateNotes.PrimaryFlavor.TreeFruits.Remove(note);
                        break;
                    case "TropicalFruits":
                        _tasting.PalateNotes.PrimaryFlavor.TropicalFruits.Remove(note);
                        break;
                    case "RedFruits":
                        _tasting.PalateNotes.PrimaryFlavor.RedFruits.Remove(note);
                        break;
                    case "BlackFruits":
                        _tasting.PalateNotes.PrimaryFlavor.BlackFruits.Remove(note);
                        break;
                    case "DriedFruits":
                        _tasting.PalateNotes.PrimaryFlavor.DriedFruits.Remove(note);
                        break;
                    case "NobleRot":
                        _tasting.PalateNotes.PrimaryFlavor.NobleRots.Remove(note);
                        break;
                    case "Spice":
                        _tasting.PalateNotes.PrimaryFlavor.Spices.Remove(note);
                        break;
                    case "Vegetable":
                        _tasting.PalateNotes.PrimaryFlavor.Vegetables.Remove(note);
                        break;
                    case "Earth":
                        _tasting.PalateNotes.PrimaryFlavor.Earths.Remove(note);
                        break;
                }
            }
            else if (noteType == "SecondaryAroma")
            {
                switch (category)
                {
                    case "Microbial":
                        _tasting.PalateNotes.SecondaryFlavor.Microbials.Remove(note);
                        break;
                }
            }
            else if (noteType == "TertiaryAroma")
            {
                switch (category)
                {
                    case "Oak":
                        _tasting.PalateNotes.TertiaryFlavor.Oaks.Remove(note);
                        break;
                    case "GeneralAging":
                        _tasting.PalateNotes.TertiaryFlavor.GeneralAging.Remove(note);
                        break;
                }
            }
            else if (noteType == "FaultAroma")
            {
                switch (category)
                {
                    case "FaultType":
                        _tasting.PalateNotes.FaultFlavor.Faults.Remove(note);
                        break;
                }
            }
        }
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Save the Tasting data - here you would implement your saving logic, e.g., save to a database, file, etc.
            // This is just a placeholder for demonstration
            await DisplayAlert("Saved", "Your tasting notes have been saved successfully!", "OK");
            await Navigation.PopAsync();
        }

    }
}