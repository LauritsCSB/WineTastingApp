using WineTastingApp.Models;

namespace WineTastingApp
{ 
	public partial class SmellPage : ContentPage
	{
		private Tasting _tasting;
		public SmellPage(Tasting tasting)
		{
			InitializeComponent();
			_tasting = tasting;

            // Pre-fill checkboxes based on existing data for Primary Notes
            PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.Flowers, "PrimaryAroma:Flowers"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.TreeFruits, "PrimaryAroma:TreeFruits"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.TropicalFruits, "PrimaryAroma:TropicalFruits"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.RedFruits, "PrimaryAroma:RedFruits"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.BlackFruits, "PrimaryAroma:BlackFruits"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.DriedFruits, "PrimaryAroma:DriedFruits"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.NobleRots, "PrimaryAroma:NobleRot"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.Spices, "PrimaryAroma:Spice"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.Vegetables, "PrimaryAroma:Vegetable"); 
			PreFillCheckBoxes(_tasting.SmellNotes.PrimaryAroma.Earths, "PrimaryAroma:Earth");

            // Pre-fill Secondary Notes
            PreFillCheckBoxes(_tasting.SmellNotes.SecondaryAroma.Microbials, "SecondaryAroma:Microbial");

            //Pre-fill Tertiary Notes
            PreFillCheckBoxes(_tasting.SmellNotes.TertiaryAroma.Oaks, "TertiaryAroma:Oak");
			PreFillCheckBoxes(_tasting.SmellNotes.TertiaryAroma.GeneralAging, "TertiaryAroma:GeneralAging");

            // Pre-fill Fault Notes
            PreFillCheckBoxes(_tasting.SmellNotes.FaultyAroma.Faults, "FaultAroma:FaultType");
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

        private void OnSmellIntensitySliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            SmellIntensityValueLabel.Text = ((int)e.NewValue).ToString();
            _tasting.SmellNotes.Intensity = (int)e.NewValue;
        }


        private void OnCheckBoxCheckedChanged (object sender, CheckedChangedEventArgs e)
		{
			var checkbox = (CheckBox)sender;
			string[] classIdParts = checkbox.ClassId.Split(':');
			string noteType = classIdParts[0];
			string category = classIdParts[1];
			string note = classIdParts[2];

			if (e.Value) //If checked
			{
				AddNoteToList(noteType, category, note);
			}
			else //If unchecked
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
                        _tasting.SmellNotes.PrimaryAroma.Flowers.Add(note);
                        break;
                    case "TreeFruits":
                        _tasting.SmellNotes.PrimaryAroma.TreeFruits.Add(note);
                        break;
                    case "TropicalFruits":
                        _tasting.SmellNotes.PrimaryAroma.TropicalFruits.Add(note);
                        break;
                    case "RedFruits":
                        _tasting.SmellNotes.PrimaryAroma.RedFruits.Add(note);
                        break;
                    case "BlackFruits":
                        _tasting.SmellNotes.PrimaryAroma.BlackFruits.Add(note);
                        break;
                    case "DriedFruits":
                        _tasting.SmellNotes.PrimaryAroma.DriedFruits.Add(note);
                        break;
                    case "NobleRot":
                        _tasting.SmellNotes.PrimaryAroma.NobleRots.Add(note);
                        break;
                    case "Spice":
                        _tasting.SmellNotes.PrimaryAroma.Spices.Add(note);
                        break;
                    case "Vegetable":
                        _tasting.SmellNotes.PrimaryAroma.Vegetables.Add(note);
                        break;
                    case "Earth":
                        _tasting.SmellNotes.PrimaryAroma.Earths.Add(note);
                        break;
                }
            }
            else if (noteType == "SecondaryAroma")
            {
                switch (category)
                {
                    case "Microbial":
                        _tasting.SmellNotes.SecondaryAroma.Microbials.Add(note);
                        break;
                }
            }
            else if (noteType == "TertiaryAroma")
            {
                switch (category)
                {
                    case "Oak":
                        _tasting.SmellNotes.TertiaryAroma.Oaks.Add(note);
                        break;
                    case "GeneralAging":
                        _tasting.SmellNotes.TertiaryAroma.GeneralAging.Add(note);
                        break;
                }
            }
            else if (noteType == "FaultAroma")
            {
                switch (category)
                {
                    case "FaultType":
                        _tasting.SmellNotes.FaultyAroma.Faults.Add(note);
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
                        _tasting.SmellNotes.PrimaryAroma.Flowers.Remove(note);
                        break;
                    case "TreeFruits":
                        _tasting.SmellNotes.PrimaryAroma.TreeFruits.Remove(note);
                        break;
                    case "TropicalFruits":
                        _tasting.SmellNotes.PrimaryAroma.TropicalFruits.Remove(note);
                        break;
                    case "RedFruits":
                        _tasting.SmellNotes.PrimaryAroma.RedFruits.Remove(note);
                        break;
                    case "BlackFruits":
                        _tasting.SmellNotes.PrimaryAroma.BlackFruits.Remove(note);
                        break;
                    case "DriedFruits":
                        _tasting.SmellNotes.PrimaryAroma.DriedFruits.Remove(note);
                        break;
                    case "NobleRot":
                        _tasting.SmellNotes.PrimaryAroma.NobleRots.Remove(note);
                        break;
                    case "Spice":
                        _tasting.SmellNotes.PrimaryAroma.Spices.Remove(note);
                        break;
                    case "Vegetable":
                        _tasting.SmellNotes.PrimaryAroma.Vegetables.Remove(note);
                        break;
                    case "Earth":
                        _tasting.SmellNotes.PrimaryAroma.Earths.Remove(note);
                        break;
                }
            }
            else if (noteType == "SecondaryAroma")
            {
                switch (category)
                {
                    case "Microbial":
                        _tasting.SmellNotes.SecondaryAroma.Microbials.Remove(note);
                        break;
                }
            }
            else if (noteType == "TertiaryAroma")
            {
                switch (category)
                {
                    case "Oak":
                        _tasting.SmellNotes.TertiaryAroma.Oaks.Remove(note);
                        break;
                    case "GeneralAging":
                        _tasting.SmellNotes.TertiaryAroma.GeneralAging.Remove(note);
                        break;
                }
            }
            else if (noteType == "FaultAroma")
            {
                switch (category)
                {
                    case "FaultType":
                        _tasting.SmellNotes.FaultyAroma.Faults.Remove(note);
                        break;
                }
            }
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Saved", "Your smell notes have been saved successfully!", "OK");
            await Navigation.PopAsync();
        }


    }
}