using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;
using WineTastingApp.Models;
using WineTastingApp.Services;

namespace WineTastingApp
{
	public partial class ViewSavedDataPage : ContentPage
	{
		public ViewSavedDataPage()
		{
			InitializeComponent();
			LoadSavedData();
		}

		private void LoadSavedData()
		{
			// Load the saved tasting using DataService
			Tasting savedTasting = DataService.LoadTastingFromJson();

			// Set the labels with the saved data
			DateLabel.Text = savedTasting.Date.ToString("d");
			OccasionLabel.Text = savedTasting.Occasion;
			WineNameLabel.Text = savedTasting.Bottle.Name;
			WineryNameLabel.Text = savedTasting.Bottle.Winery.Name;
			VintageLabel.Text = savedTasting.Bottle.Vintage.ToString("yyyy");
			AppellationLabel.Text = savedTasting.Bottle.Appellation.Name;
			RegionLabel.Text = savedTasting.Bottle.Appellation.Region.Name;
			CountryLabel.Text = savedTasting.Bottle.Appellation.Region.Country.Name;

			// Visual notes
			ClarityLabel.Text = savedTasting.VisualNotes.Clarity.ToString();
            IntensityLabel.Text = savedTasting.VisualNotes.Intensity.ToString();
            ColorLabel.Text = savedTasting.VisualNotes.Color.ToString();

			// Dynamical creation of smell notes
			CreateDynamicLabels("SmellNotesStackLayout", savedTasting.SmellNotes);

			// Dynamical creation of palate notes
			CreateDynamicLabels("PalateNotesStackLayout", savedTasting.PalateNotes);
        }

		private void CreateDynamicLabels(string stackLayoutName, object notes)
		{
			var Properties = notes.GetType().GetProperties();
            foreach (var property in Properties)
            {
				var value = property.GetValue(notes);
				if (value is List<string> list && list.Any())
				{
					foreach (var item in list)
					{
						AddLabel(stackLayoutName, item);
					}
				}
                else if (value is string str && !string.IsNullOrEmpty(str))
                {
                    AddLabel(stackLayoutName, str);
                }
            }
        }
        

		private void AddLabel (string stackLayoutName, string text)
		{
			var label = new Label
			{
				Text = text,
				FontAttributes = FontAttributes.Bold
			};

			var stackLayout = this.FindByName<StackLayout>(stackLayoutName);
			stackLayout.Children.Add(label);
		}
	}
}