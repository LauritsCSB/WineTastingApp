using System;
using System.Linq;
using WineTastingApp.Models;
using WineTastingApp.Services;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WineTastingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InitializePickers();
        }

        private void InitializePickers()
        {
            //TODO Pickers related to tasting that arent "notes"

            // Smell Primary Notes
            SmellPrimaryFlowerPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Flower)).ToList();
            SmellPrimaryTreeFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.TreeFruit)).ToList();
            SmellPrimaryTropicalFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.TropicalFruit)).ToList();
            SmellPrimaryRedFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.RedFruit)).ToList();
            SmellPrimaryBlackFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.BlackFruit)).ToList();
            SmellPrimaryDriedFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.DriedFruit)).ToList();
            SmellPrimaryNobleRotPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.NobleRot)).ToList();
            SmellPrimarySpicePicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Spice)).ToList();
            SmellPrimaryVegetablePicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Vegetable)).ToList();
            SmellPrimaryEarthPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Earth)).ToList();

            // Smell Secondary Notes
            SmellSecondaryMicrobialPicker.ItemsSource = Enum.GetNames(typeof(SecondaryNotesEnums.Microbial)).ToList();

            // Smell Tertiary Notes
            SmellTertiaryOakAgingPicker.ItemsSource = Enum.GetNames(typeof(TertiaryNotesEnums.Oak)).ToList();
            SmellTertiaryGeneralAgingPicker.ItemsSource = Enum.GetNames(typeof(TertiaryNotesEnums.GeneralAging)).ToList();

            // Palate Primary Notes
            PalatePrimaryFlowerPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Flower)).ToList();
            PalatePrimaryTreeFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.TreeFruit)).ToList();
            PalatePrimaryTropicalFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.TropicalFruit)).ToList();
            PalatePrimaryRedFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.RedFruit)).ToList();
            PalatePrimaryBlackFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.BlackFruit)).ToList();
            PalatePrimaryDriedFruitPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.DriedFruit)).ToList();
            PalatePrimaryNobleRotPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.NobleRot)).ToList();
            PalatePrimarySpicePicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Spice)).ToList();
            PalatePrimaryVegetablePicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Vegetable)).ToList();
            PalatePrimaryEarthPicker.ItemsSource = Enum.GetNames(typeof(PrimaryNotesEnums.Earth)).ToList();

            //Palate Notes
            PalateSweetnessPicker.ItemsSource = Enum.GetNames(typeof(PalateNotesEnums.Sweetness)).ToList();
            PalateAcidityPicker.ItemsSource = Enum.GetNames(typeof(PalateNotesEnums.Acidity)).ToList();
            PalateTanninPicker.ItemsSource = Enum.GetNames(typeof(PalateNotesEnums.Tannin)).ToList();
            PalateNaturePicker.ItemsSource = Enum.GetNames(typeof(PalateNotesEnums.Nature)).ToList();

            // Palate Secondary Notes
            PalateSecondaryMicrobialPicker.ItemsSource = Enum.GetNames(typeof(SecondaryNotesEnums.Microbial)).ToList();

            // Palate Tertiary Notes
            PalateTertiaryOakAgingPicker.ItemsSource = Enum.GetNames(typeof(TertiaryNotesEnums.Oak)).ToList();
            PalateTertiaryGeneralAgingPicker.ItemsSource = Enum.GetNames(typeof(TertiaryNotesEnums.GeneralAging)).ToList();
        }
        //TODO OnSaveClicked
        private void OnSaveClicked(object sender, EventArgs e)
        {
            var visualNotes = new VisualNotes
            {
                Clarity = (VisualNotes.ClarityEnum)Enum.Parse(typeof(VisualNotes.ClarityEnum), (string)ClarityPicker.SelectedItem),
                Intensity = (VisualNotes.IntensityEnum)Enum.Parse(typeof(VisualNotes.IntensityEnum), (string)IntensityPicker.SelectedItem),
                Color = (VisualNotes.ColorEnum)Enum.Parse(typeof(VisualNotes.ColorEnum), (string)ColorPicker.SelectedItem),
                OtherObservations = new List<string>()
            };

            var smellNotes = new SmellNotes
            {
                Intensity = (int)SmellIntensitySlider.Value,

                PrimaryAroma = new PrimaryNotes
                {
                    Flowers = GetSelectedItems<PrimaryNotesEnums.Flower>(SmellPrimaryFlowerPicker),
                    TreeFruits = GetSelectedItems<PrimaryNotesEnums.TreeFruit>(SmellPrimaryTreeFruitPicker),
                    TropicalFruits = GetSelectedItems<PrimaryNotesEnums.TropicalFruit>(SmellPrimaryTropicalFruitPicker),
                    RedFruits = GetSelectedItems<PrimaryNotesEnums.RedFruit>(SmellPrimaryRedFruitPicker),
                    BlackFruits = GetSelectedItems<PrimaryNotesEnums.BlackFruit>(SmellPrimaryBlackFruitPicker),
                    DriedFruits = GetSelectedItems<PrimaryNotesEnums.DriedFruit>(SmellPrimaryDriedFruitPicker),
                    NobleRots = GetSelectedItems<PrimaryNotesEnums.NobleRot>(SmellPrimaryNobleRotPicker),
                    Spices = GetSelectedItems<PrimaryNotesEnums.Spice>(SmellPrimarySpicePicker),
                    Vegetables = GetSelectedItems<PrimaryNotesEnums.Vegetable>(SmellPrimaryVegetablePicker),
                    Earths = GetSelectedItems<PrimaryNotesEnums.Earth>(SmellPrimaryEarthPicker)
                },
                SecondaryAroma = new SecondaryNotes
                {
                    Microbials = GetSelectedItems<SecondaryNotesEnums.Microbial>(SmellSecondaryMicrobialPicker)
                },
                TertiaryAroma = new TertiaryNotes
                {
                    Oaks = GetSelectedItems<TertiaryNotesEnums.Oak>(SmellTertiaryOakAgingPicker),
                    GeneralAging = GetSelectedItems<TertiaryNotesEnums.GeneralAging>(SmellTertiaryGeneralAgingPicker)
                },
                FaultyAroma = new FaultNotes
                {
                    Faults = GetSelectedItems<FaultNotesEnums.FaultType>(SmellFaultPicker)
                }
            };

            var palateNotes = new PalateNotes
            {
                Sweetness = (PalateNotesEnums.Sweetness)Enum.Parse(typeof(PalateNotesEnums.Sweetness), PalateSweetnessPicker.SelectedItem.ToString()),
                Acidity = (PalateNotesEnums.Acidity)Enum.Parse(typeof(PalateNotesEnums.Acidity), PalateAcidityPicker.SelectedItem.ToString()),
                Tannin = (PalateNotesEnums.Tannin)Enum.Parse(typeof(PalateNotesEnums.Tannin), PalateTanninPicker.SelectedItem.ToString()),
                Nature = (PalateNotesEnums.Nature)Enum.Parse(typeof(PalateNotesEnums.Nature), PalateNaturePicker.SelectedItem.ToString()),

                PrimaryFlavor = new PrimaryNotes
                {
                    Flowers = GetSelectedItems<PrimaryNotesEnums.Flower>(PalatePrimaryFlowerPicker),
                    TreeFruits = GetSelectedItems<PrimaryNotesEnums.TreeFruit>(PalatePrimaryTreeFruitPicker),
                    TropicalFruits = GetSelectedItems<PrimaryNotesEnums.TropicalFruit>(PalatePrimaryTropicalFruitPicker),
                    RedFruits = GetSelectedItems<PrimaryNotesEnums.RedFruit>(PalatePrimaryRedFruitPicker),
                    BlackFruits = GetSelectedItems<PrimaryNotesEnums.BlackFruit>(PalatePrimaryBlackFruitPicker),
                    DriedFruits = GetSelectedItems<PrimaryNotesEnums.DriedFruit>(PalatePrimaryDriedFruitPicker),
                    NobleRots = GetSelectedItems<PrimaryNotesEnums.NobleRot>(PalatePrimaryNobleRotPicker),
                    Spices = GetSelectedItems<PrimaryNotesEnums.Spice>(PalatePrimarySpicePicker),
                    Vegetables = GetSelectedItems<PrimaryNotesEnums.Vegetable>(PalatePrimaryVegetablePicker),
                    Earths = GetSelectedItems<PrimaryNotesEnums.Earth>(PalatePrimaryEarthPicker)
                }
            };
        }

        //TODO OnViewClicked
        private void OnViewClicked(object sender, EventArgs e)
        {
            try
            {
                var tasting = DataService.LoadTastingFromJson();
                DisplayTastingData(tasting);
            }
            catch
            {
                DisplayAlert("Error", "No saved data found.", "OK");
            }
        }

        private void DisplayTastingData(Tasting tasting)
        {
            var tastingDataDetails = new System.Text.StringBuilder();

            // Basic information
            tastingDataDetails.AppendLine($"Date: {tasting.Date}");
            tastingDataDetails.AppendLine($"Occasion: {tasting.Occasion}");
            tastingDataDetails.AppendLine($"Wine Name: {tasting.Bottle.Name}");
            tastingDataDetails.AppendLine($"Winery: {tasting.Bottle.Winery}");
            tastingDataDetails.AppendLine($"Vintage: {tasting.Bottle.Vintage}");

            // Loops to interate each property list
            AppendNotes(tastingDataDetails, "Visual Notes", tasting.VisualNotes);
            AppendNotes(tastingDataDetails, "Smell Notes", tasting.SmellNotes);
            AppendNotes(tastingDataDetails, "Palate Notes", tasting.PalateNotes);

            
            
        }

        private void AppendNotes(StringBuilder tastingDetails, string sectionTitle, object notes)
        {
            tastingDetails.AppendLine($"{sectionTitle}");

            foreach (var property in notes.GetType().GetProperties())
            {
                var value = property.GetValue(notes);

                if (value is IList list)
                {
                    tastingDetails.AppendLine($"{property.Name}");
                    foreach (var item in list)
                    {
                        tastingDetails.AppendLine($"{item}");
                    }
                }
                else
                {
                    tastingDetails.AppendLine($"{property.Name}: {value}");
                }
            }
        }

        private List<T> GetSelectedItems<T>(Picker picker)
        {
            var selectedItems = new List<T>();
            foreach (var item in picker.ItemsSource)
            {
                selectedItems.Add((T)Enum.Parse(typeof(T), item.ToString()));
            }
            return selectedItems;
        }
        
    }
}
